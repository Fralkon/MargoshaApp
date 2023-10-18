namespace MargoshaApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сверитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьPOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показыватьЗеленыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminDataGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.верноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обьеденитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.POSDataGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.верноToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обьеденитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDataGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.POSDataGrid)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.действиеToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1471, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // действиеToolStripMenuItem
            // 
            this.действиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сверитьToolStripMenuItem,
            this.очиститьAdminToolStripMenuItem,
            this.очиститьPOSToolStripMenuItem,
            this.очиститьВсеToolStripMenuItem,
            this.посчитатьToolStripMenuItem});
            this.действиеToolStripMenuItem.Name = "действиеToolStripMenuItem";
            this.действиеToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действиеToolStripMenuItem.Text = "Действие";
            // 
            // сверитьToolStripMenuItem
            // 
            this.сверитьToolStripMenuItem.Name = "сверитьToolStripMenuItem";
            this.сверитьToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.сверитьToolStripMenuItem.Text = "Сверить";
            this.сверитьToolStripMenuItem.Click += new System.EventHandler(this.сверитьToolStripMenuItem_Click);
            // 
            // очиститьAdminToolStripMenuItem
            // 
            this.очиститьAdminToolStripMenuItem.Name = "очиститьAdminToolStripMenuItem";
            this.очиститьAdminToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.очиститьAdminToolStripMenuItem.Text = "Очистить Admin";
            this.очиститьAdminToolStripMenuItem.Click += new System.EventHandler(this.очиститьAdminToolStripMenuItem_Click);
            // 
            // очиститьPOSToolStripMenuItem
            // 
            this.очиститьPOSToolStripMenuItem.Name = "очиститьPOSToolStripMenuItem";
            this.очиститьPOSToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.очиститьPOSToolStripMenuItem.Text = "Очистить POS";
            this.очиститьPOSToolStripMenuItem.Click += new System.EventHandler(this.очиститьPOSToolStripMenuItem_Click);
            // 
            // очиститьВсеToolStripMenuItem
            // 
            this.очиститьВсеToolStripMenuItem.Name = "очиститьВсеToolStripMenuItem";
            this.очиститьВсеToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.очиститьВсеToolStripMenuItem.Text = "Очистить все";
            this.очиститьВсеToolStripMenuItem.Click += new System.EventHandler(this.очиститьВсеToolStripMenuItem_Click);
            // 
            // посчитатьToolStripMenuItem
            // 
            this.посчитатьToolStripMenuItem.Name = "посчитатьToolStripMenuItem";
            this.посчитатьToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.посчитатьToolStripMenuItem.Text = "Посчитать";
            this.посчитатьToolStripMenuItem.Click += new System.EventHandler(this.посчитатьToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показыватьЗеленыеToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // показыватьЗеленыеToolStripMenuItem
            // 
            this.показыватьЗеленыеToolStripMenuItem.Name = "показыватьЗеленыеToolStripMenuItem";
            this.показыватьЗеленыеToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.показыватьЗеленыеToolStripMenuItem.Text = "Показывать зеленые";
            this.показыватьЗеленыеToolStripMenuItem.Click += new System.EventHandler(this.показыватьЗеленыеToolStripMenuItem_Click);
            // 
            // AdminDataGrid
            // 
            this.AdminDataGrid.AllowDrop = true;
            this.AdminDataGrid.AllowUserToAddRows = false;
            this.AdminDataGrid.AllowUserToDeleteRows = false;
            this.AdminDataGrid.AllowUserToResizeColumns = false;
            this.AdminDataGrid.AllowUserToResizeRows = false;
            this.AdminDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AdminDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AdminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminDataGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.AdminDataGrid.Location = new System.Drawing.Point(12, 56);
            this.AdminDataGrid.Name = "AdminDataGrid";
            this.AdminDataGrid.ReadOnly = true;
            this.AdminDataGrid.RowHeadersVisible = false;
            this.AdminDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AdminDataGrid.Size = new System.Drawing.Size(709, 492);
            this.AdminDataGrid.TabIndex = 1;
            this.AdminDataGrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.AdminDataGrid_RowPostPaint);
            this.AdminDataGrid.SelectionChanged += new System.EventHandler(this.AdminDataGrid_SelectionChanged);
            this.AdminDataGrid.SizeChanged += new System.EventHandler(this.AdminDataGrid_SizeChanged);
            this.AdminDataGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.AdminDataGrid_DragDrop);
            this.AdminDataGrid.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataGrid_DragEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.верноToolStripMenuItem,
            this.обьеденитьToolStripMenuItem,
            this.удалитьToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // верноToolStripMenuItem
            // 
            this.верноToolStripMenuItem.Name = "верноToolStripMenuItem";
            this.верноToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.верноToolStripMenuItem.Text = "Верно";
            this.верноToolStripMenuItem.Click += new System.EventHandler(this.верноToolStripMenuItem_Click);
            // 
            // обьеденитьToolStripMenuItem
            // 
            this.обьеденитьToolStripMenuItem.Name = "обьеденитьToolStripMenuItem";
            this.обьеденитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обьеденитьToolStripMenuItem.Text = "Обьеденить";
            this.обьеденитьToolStripMenuItem.Click += new System.EventHandler(this.обьеденитьToolStripMenuItem_Click);
            // 
            // POSDataGrid
            // 
            this.POSDataGrid.AllowDrop = true;
            this.POSDataGrid.AllowUserToAddRows = false;
            this.POSDataGrid.AllowUserToDeleteRows = false;
            this.POSDataGrid.AllowUserToResizeColumns = false;
            this.POSDataGrid.AllowUserToResizeRows = false;
            this.POSDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.POSDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.POSDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.POSDataGrid.ContextMenuStrip = this.contextMenuStrip2;
            this.POSDataGrid.Location = new System.Drawing.Point(739, 56);
            this.POSDataGrid.Name = "POSDataGrid";
            this.POSDataGrid.ReadOnly = true;
            this.POSDataGrid.RowHeadersVisible = false;
            this.POSDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.POSDataGrid.Size = new System.Drawing.Size(720, 492);
            this.POSDataGrid.TabIndex = 2;
            this.POSDataGrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.POSDataGrid_RowPostPaint);
            this.POSDataGrid.SelectionChanged += new System.EventHandler(this.POSDataGrid_SelectionChanged);
            this.POSDataGrid.LocationChanged += new System.EventHandler(this.POSDataGrid_LocationChanged);
            this.POSDataGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.POSDataGrid_DragDrop);
            this.POSDataGrid.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataGrid_DragEnter);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.верноToolStripMenuItem1,
            this.обьеденитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(140, 70);
            // 
            // верноToolStripMenuItem1
            // 
            this.верноToolStripMenuItem1.Name = "верноToolStripMenuItem1";
            this.верноToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.верноToolStripMenuItem1.Text = "Верно";
            this.верноToolStripMenuItem1.Click += new System.EventHandler(this.верноToolStripMenuItem1_Click);
            // 
            // обьеденитьToolStripMenuItem1
            // 
            this.обьеденитьToolStripMenuItem1.Name = "обьеденитьToolStripMenuItem1";
            this.обьеденитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.обьеденитьToolStripMenuItem1.Text = "Обьеденить";
            this.обьеденитьToolStripMenuItem1.Click += new System.EventHandler(this.обьеденитьToolStripMenuItem1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(1289, 27);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(170, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Общее";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 587);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Не сходится";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(735, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Не сходится";
            this.label4.LocationChanged += new System.EventHandler(this.label6_LocationChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(735, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Общее";
            this.label6.LocationChanged += new System.EventHandler(this.label6_LocationChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(840, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "0";
            this.label8.LocationChanged += new System.EventHandler(this.label8_LocationChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 587);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(840, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "0";
            this.label2.LocationChanged += new System.EventHandler(this.label8_LocationChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 574);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Выделено";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(735, 574);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Выделено";
            this.label10.LocationChanged += new System.EventHandler(this.label6_LocationChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(112, 574);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(840, 574);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "0";
            this.label12.LocationChanged += new System.EventHandler(this.label8_LocationChanged);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 622);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.POSDataGrid);
            this.Controls.Add(this.AdminDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDataGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.POSDataGrid)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView AdminDataGrid;
        private System.Windows.Forms.DataGridView POSDataGrid;
        private System.Windows.Forms.ToolStripMenuItem действиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сверитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показыватьЗеленыеToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem очиститьAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьPOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьВсеToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem посчитатьToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem верноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обьеденитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem верноToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обьеденитьToolStripMenuItem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
    }
}

