namespace ServiceStationManager
{
    partial class FormCars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCars));
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTBSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBtSearch = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCars.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCars.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCars.Location = new System.Drawing.Point(0, 25);
            this.dgvCars.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.Size = new System.Drawing.Size(944, 560);
            this.dgvCars.TabIndex = 11;
            this.dgvCars.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCars_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextEdit,
            this.contextDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 48);
            // 
            // contextEdit
            // 
            this.contextEdit.Name = "contextEdit";
            this.contextEdit.Size = new System.Drawing.Size(163, 22);
            this.contextEdit.Text = "Редактировать...";
            this.contextEdit.Click += new System.EventHandler(this.toolStripBtEdit_Click);
            // 
            // contextDelete
            // 
            this.contextDelete.Name = "contextDelete";
            this.contextDelete.Size = new System.Drawing.Size(163, 22);
            this.contextDelete.Text = "Удалить";
            this.contextDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SeaShell;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripBtEdit,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.toolStripTBSearch,
            this.toolStripBtSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(944, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(142, 22);
            this.toolStripButton1.Text = "Добавить автомобиль...";
            this.toolStripButton1.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(125, 22);
            this.toolStripButton2.Text = "Удалить автомобиль";
            this.toolStripButton2.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // toolStripBtEdit
            // 
            this.toolStripBtEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtEdit.Image")));
            this.toolStripBtEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtEdit.Name = "toolStripBtEdit";
            this.toolStripBtEdit.Size = new System.Drawing.Size(173, 22);
            this.toolStripBtEdit.Text = "Редактировать  автомобиль...";
            this.toolStripBtEdit.Click += new System.EventHandler(this.toolStripBtEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTBSearch
            // 
            this.toolStripTBSearch.Name = "toolStripTBSearch";
            this.toolStripTBSearch.Size = new System.Drawing.Size(300, 25);
            this.toolStripTBSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTBSearch_KeyPress);
            // 
            // toolStripBtSearch
            // 
            this.toolStripBtSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtSearch.Image")));
            this.toolStripBtSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtSearch.Name = "toolStripBtSearch";
            this.toolStripBtSearch.Size = new System.Drawing.Size(46, 22);
            this.toolStripBtSearch.Text = "Поиск";
            this.toolStripBtSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // FormCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(944, 585);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvCars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCars";
            this.Text = "Автомобили клиентов";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTBSearch;
        private System.Windows.Forms.ToolStripButton toolStripBtSearch;
        private System.Windows.Forms.ToolStripButton toolStripBtEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextEdit;
        private System.Windows.Forms.ToolStripMenuItem contextDelete;
    }
}