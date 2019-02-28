namespace ServiceStationManager
{
    partial class FormWorkHours
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
            this.dgvWorkHours = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьРаботуыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбраннуюРаботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkHours)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWorkHours
            // 
            this.dgvWorkHours.AllowUserToAddRows = false;
            this.dgvWorkHours.AllowUserToDeleteRows = false;
            this.dgvWorkHours.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvWorkHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkHours.Location = new System.Drawing.Point(0, 24);
            this.dgvWorkHours.Name = "dgvWorkHours";
            this.dgvWorkHours.ReadOnly = true;
            this.dgvWorkHours.Size = new System.Drawing.Size(1103, 495);
            this.dgvWorkHours.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaShell;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРаботуыToolStripMenuItem,
            this.удалитьВыбраннуюРаботуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1103, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьРаботуыToolStripMenuItem
            // 
            this.добавитьРаботуыToolStripMenuItem.Name = "добавитьРаботуыToolStripMenuItem";
            this.добавитьРаботуыToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.добавитьРаботуыToolStripMenuItem.Text = "Добавить смену/-ы...";
            this.добавитьРаботуыToolStripMenuItem.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // удалитьВыбраннуюРаботуToolStripMenuItem
            // 
            this.удалитьВыбраннуюРаботуToolStripMenuItem.Name = "удалитьВыбраннуюРаботуToolStripMenuItem";
            this.удалитьВыбраннуюРаботуToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
            this.удалитьВыбраннуюРаботуToolStripMenuItem.Text = "Удалить выбранную смену";
            this.удалитьВыбраннуюРаботуToolStripMenuItem.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // FormWorkHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(1103, 519);
            this.Controls.Add(this.dgvWorkHours);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormWorkHours";
            this.Text = "График работы сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkHours)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvWorkHours;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьРаботуыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбраннуюРаботуToolStripMenuItem;
    }
}