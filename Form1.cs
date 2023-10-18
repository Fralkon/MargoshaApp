using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MargoshaApp
{
    public partial class Form1 : Form
    {
        DataTable dataPOS = new DataTable();
        DataTable dataAdmin = new DataTable();
        DataView dataViewAdmin;
        DataView dataViewPOS;
        public Form1()
        {
            InitializeComponent();
            dataAdmin.Columns.Add("ID");
            dataAdmin.Columns.Add("Период");
            dataAdmin.Columns.Add("Поставка", typeof(DateTime));
            dataAdmin.Columns.Add("Сумма карта",typeof(int));
            dataAdmin.Columns.Add("Сравнение");
            dataViewAdmin = new DataView(dataAdmin);
            AdminDataGrid.DataSource = dataViewAdmin;

            dataPOS.Columns.Add("Время платежа", typeof(DateTime));
            dataPOS.Columns.Add("Сумма карта", typeof(int));
            dataPOS.Columns.Add("Сравнение");
            dataViewPOS = new DataView(dataPOS);
            POSDataGrid.DataSource = dataViewPOS;
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void POSDataGrid_DragDrop(object sender, DragEventArgs e)
        {            
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1 || files.Length == 2)
            {
                foreach (string file in files)
                {
                    using (DataTable dataExcel = LoadDataTableOnFile(file))
                    {
                        if (dataExcel.Columns[0].ColumnName == "Номер транзакции")
                        {
                            foreach (DataRow rowExcel in dataExcel.Rows)
                                if (rowExcel[8].ToString() != "" && rowExcel[8].ToString() != "0")
                                    if (rowExcel[15].ToString() != "")
                                    {
                                        DataRow row = dataPOS.NewRow();
                                        row[0] = DateTime.Parse(rowExcel[2].ToString());
                                        string v = rowExcel[17].ToString();
                                        row[1] = int.Parse(v.Substring(0, v.Length - 3));
                                        row[2] = "";
                                        dataPOS.Rows.Add(row);
                                    }
                        }
                        else
                        {
                            foreach (DataRow rowExcel in dataExcel.Rows)
                                if (rowExcel[8].ToString() != "" && rowExcel[8].ToString() != "0")
                                {
                                    DataRow row = dataPOS.NewRow();
                                    row[0] = DateTime.Parse(rowExcel[1].ToString());
                                    row[1] = int.Parse(rowExcel[8].ToString());
                                    row[2] = "";
                                    dataPOS.Rows.Add(row);
                                }
                        }
                    }
                }
                Summ();
                MessageBox.Show("Загрузка завершена");
            }
            else
            {
                MessageBox.Show("Перетащите 1 файл");
            }
        }
        private void DataGrid_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
        private void AdminDataGrid_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1)
            {
                using (DataTable dataExcel = LoadDataTableOnFile(files[0]))
                {
                    foreach (DataRow rowExcel in dataExcel.Rows)
                    {
                        if (rowExcel[8].ToString() != "" && rowExcel[8].ToString() != "0")
                        {
                            DataRow row = dataAdmin.NewRow();
                            row[0] = rowExcel[0];
                            row[1] = rowExcel[2];
                            row[2] = DateTime.Parse(rowExcel[3].ToString());
                            row[3] = int.Parse(rowExcel[8].ToString());
                            row[4] = "";
                            dataAdmin.Rows.Add(row);
                        }
                    }
                }
                Summ();
                MessageBox.Show("Загрузка завершена");
            }
            else
            {
                MessageBox.Show("Перетащите 1 файл");
            }
        }
        private DataTable LoadDataTableOnFile(string file)
        {
            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file + ";Extended Properties=\"Excel 12.0;HDR=YES;\""))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;

                DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                string sheetName = String.Empty;
                try
                {
                    // dr["TABLE_NAME"] = "Table";
                    sheetName = dtSheet.Rows[0]["TABLE_NAME"].ToString();
                    // Get all rows from the Sheet
                    cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                    DataTable dt = new DataTable();
                    dt.TableName = sheetName;
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Ошибка заполнения таблицы. Error:{0}", ex.Message));
                    return null;
                }
            }
        }
        private void сверитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataPOS.Rows.Count > 0 && dataAdmin.Rows.Count > 0)
            {
                Task.Run(() =>
                {
                    progressBar1.BeginInvoke(new Action(() =>
                    {
                        progressBar1.Visible = true;
                        progressBar1.Maximum = dataAdmin.Rows.Count-1;
                    }));
                    for (int iAdmin = 0; iAdmin < dataAdmin.Rows.Count; iAdmin++)
                    {
                        progressBar1.BeginInvoke(new Action(() =>
                        {
                            progressBar1.Value = iAdmin;
                        }));
                        if (dataAdmin.Rows[iAdmin][4].ToString() == "")
                        {
                            for (int iPOS = 0; iPOS < dataPOS.Rows.Count; iPOS++)
                            {
                                if (dataPOS.Rows[iPOS][2].ToString() == "")
                                {
                                    if (int.Parse(dataAdmin.Rows[iAdmin][3].ToString()) == int.Parse(dataPOS.Rows[iPOS][1].ToString()))
                                    {
                                        dataPOS.Rows[iPOS][2] = "верно";
                                        dataAdmin.Rows[iAdmin][4] = "верно";
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    progressBar1.Value = 0;
                    Summ();
                    показыватьЗеленыеToolStripMenuItem.Checked = false;
                    показыватьЗеленыеToolStripMenuItem_Click(sender, new EventArgs());
                }); 
            }
            else
            {
                MessageBox.Show("Загрузите файлы");
            }
        }
        private void AdminDataGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            Color c;
            string value = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (value == "верно")
            {                
                c = Color.Green;
            }
            else if (value == "не верно")
            {
                c = Color.Red;
            }
            else
            {
                c = Color.Pink;
            }
            dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = c;
        }
        private void POSDataGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            Color c;
            string value = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (value == "верно")
            {
                c = Color.Green;
            }
            else if (value == "не верно")
            {
                c = Color.Red;
            }
            else
            {
                c = Color.Pink;
            }
            dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = c;
        }
        private void очиститьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataAdmin.Clear();
            dataPOS.Clear();
        }
        private void показыватьЗеленыеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!показыватьЗеленыеToolStripMenuItem.Checked) {
                показыватьЗеленыеToolStripMenuItem.Checked = true;
                dataViewAdmin.RowFilter = "Сравнение = ''";
                dataViewPOS.RowFilter = "Сравнение = ''";
            }
            else
            {
                показыватьЗеленыеToolStripMenuItem.Checked = false;
                dataViewAdmin.RowFilter = String.Empty;
                dataViewPOS.RowFilter = String.Empty;
            }
        }
        private void Summ()
        {
            if(dataAdmin.Rows.Count > 0)
            {
                int summ = 0;
                int sh = 0;
                foreach(DataRow row in dataAdmin.Rows)
                {
                    int v = int.Parse(row[3].ToString());
                    if(row[4].ToString() == "")
                        sh += v;
                    summ += v;
                }
                label7.Text = summ.ToString();
                label9.Text = sh.ToString();
            }
            if(dataPOS.Rows.Count > 0)
            {
                int summ = 0; int sh = 0;
                foreach (DataRow row in dataPOS.Rows)
                {
                    int v = int.Parse(row[1].ToString());
                    if (row[2].ToString() == "")
                        sh += v;
                    summ += v;
                }
                label8.Text = summ.ToString();
                label2.Text = sh.ToString();
            }
        }
        private void посчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Summ();
        }
        private void очиститьAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataAdmin.Clear();
        }
        private void очиститьPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataPOS.Clear();
        }
        private void POSDataGrid_LocationChanged(object sender, EventArgs e)
        {
            int w = this.Size.Width / 2 + 15;
            POSDataGrid.Location = new Point(w, 56);
            POSDataGrid.Size = new Size(w - 60, POSDataGrid.Size.Height);
        }

        private void AdminDataGrid_SizeChanged(object sender, EventArgs e)
        {
            int w = this.Size.Width / 2 - 15;
            AdminDataGrid.Size = new Size(w, AdminDataGrid.Size.Height);
        }

        private void label6_LocationChanged(object sender, EventArgs e)
        {
            int w = this.Size.Width / 2 + 15;
            ((Label)sender).Location = new Point(w, ((Label)sender).Location.Y);
        }

        private void label8_LocationChanged(object sender, EventArgs e)
        {

            int w = this.Size.Width / 2 + 15 + 105;
            ((Label)sender).Location = new Point(w, ((Label)sender).Location.Y);
        }
        private void AdminDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (AdminDataGrid.SelectedRows.Count != 0)
            {
                int summ = 0;
                foreach (DataGridViewRow row in AdminDataGrid.SelectedRows)
                {
                    summ += int.Parse(row.Cells[3].Value.ToString());
                }
                label11.Text = summ.ToString();
            }
        }
        private void POSDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (POSDataGrid.SelectedRows.Count != 0)
            {
                int summ = 0;
                foreach (DataGridViewRow row in POSDataGrid.SelectedRows)
                {
                    summ += int.Parse(row.Cells[1].Value.ToString());
                }
                label12.Text = summ.ToString();
            }
        }
        private void верноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AdminDataGrid.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in AdminDataGrid.SelectedRows)
                    row.Cells[4].Value = "верно";
            }
            AdminDataGrid.Refresh();
            Summ();
        }
        private void верноToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (POSDataGrid.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in POSDataGrid.SelectedRows)
                    row.Cells[2].Value = "верно";
            }
            Summ();
        }
        private void обьеденитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (POSDataGrid.SelectedRows.Count > 1)
            {
                int summ = 0;
                DataGridViewSelectedRowCollection rowCollection = POSDataGrid.SelectedRows;
                foreach (DataGridViewRow row in rowCollection)
                {
                    summ += int.Parse(row.Cells[1].Value.ToString());
                }
                rowCollection[0].Cells[1].Value = summ;
                for (int i = 1; i < rowCollection.Count; i++)
                {
                    POSDataGrid.Rows.Remove(rowCollection[i]);
                }
            }
        }
        private void обьеденитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AdminDataGrid.SelectedRows.Count > 1)
            {
                int summ = 0;
                DataGridViewSelectedRowCollection rowCollection = AdminDataGrid.SelectedRows;
                foreach (DataGridViewRow row in rowCollection)
                {
                    summ += int.Parse(row.Cells[3].Value.ToString());
                }
                rowCollection[0].Cells[3].Value = summ;
                for (int i = 1; i < rowCollection.Count; i++)
                {
                    AdminDataGrid.Rows.Remove(rowCollection[i]);
                }
            }
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (POSDataGrid.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in POSDataGrid.SelectedRows)
                    POSDataGrid.Rows.Remove(row);
                Summ();
            }
        }
        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (AdminDataGrid.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in AdminDataGrid.SelectedRows)
                    AdminDataGrid.Rows.Remove(row);
                Summ();
            }
        }
    }
}
