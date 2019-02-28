namespace ServiceStationManager
{
    partial class FormWorkHoursRepairs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvWorkHoursRepairs = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьРаботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбраннуюСменуСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkHoursRepairs)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWorkHoursRepairs
            // 
            this.dgvWorkHoursRepairs.AllowUserToAddRows = false;
            this.dgvWorkHoursRepairs.AllowUserToDeleteRows = false;
            this.dgvWorkHoursRepairs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvWorkHoursRepairs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvWorkHoursRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkHoursRepairs.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWorkHoursRepairs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkHoursRepairs.Location = new System.Drawing.Point(0, 24);
            this.dgvWorkHoursRepairs.Name = "dgvWorkHoursRepairs";
            this.dgvWorkHoursRepairs.ReadOnly = true;
            this.dgvWorkHoursRepairs.Size = new System.Drawing.Size(1103, 499);
            this.dgvWorkHoursRepairs.TabIndex = 7;
            this.dgvWorkHoursRepairs.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvWorkHoursRepairs_CellMouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaShell;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРаботуToolStripMenuItem,
            this.удалитьВыбраннуюСменуСотрудникаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1103, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьРаботуToolStripMenuItem
            // 
            this.добавитьРаботуToolStripMenuItem.Name = "добавитьРаботуToolStripMenuItem";
            this.добавитьРаботуToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.добавитьРаботуToolStripMenuItem.Text = "Добавить работу...";
            this.добавитьРаботуToolStripMenuItem.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // удалитьВыбраннуюСменуСотрудникаToolStripMenuItem
            // 
            this.удалитьВыбраннуюСменуСотрудникаToolStripMenuItem.Name = "удалитьВыбраннуюСменуСотрудникаToolStripMenuItem";
            this.удалитьВыбраннуюСменуСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(234, 20);
            this.удалитьВыбраннуюСменуСотрудникаToolStripMenuItem.Text = "Удалить выбранную смену сотрудника";
            this.удалитьВыбраннуюСменуСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // FormWorkHoursRepairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(1103, 523);
            this.Controls.Add(this.dgvWorkHoursRepairs);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormWorkHoursRepairs";
            this.Text = "Расписание ремнотных работ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkHoursRepairs)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvWorkHoursRepairs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьРаботуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбраннуюСменуСотрудникаToolStripMenuItem;
    }
}