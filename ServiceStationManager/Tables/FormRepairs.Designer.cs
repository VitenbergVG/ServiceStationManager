namespace ServiceStationManager
{
    partial class FormRepairs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьРемонтунюРаботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбраннуюРаботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(886, 549);
            this.dataGridView1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaShell;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРемонтунюРаботуToolStripMenuItem,
            this.удалитьВыбраннуюРаботуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьРемонтунюРаботуToolStripMenuItem
            // 
            this.добавитьРемонтунюРаботуToolStripMenuItem.Name = "добавитьРемонтунюРаботуToolStripMenuItem";
            this.добавитьРемонтунюРаботуToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.добавитьРемонтунюРаботуToolStripMenuItem.Text = "Добавить работу...";
            this.добавитьРемонтунюРаботуToolStripMenuItem.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // удалитьВыбраннуюРаботуToolStripMenuItem
            // 
            this.удалитьВыбраннуюРаботуToolStripMenuItem.Name = "удалитьВыбраннуюРаботуToolStripMenuItem";
            this.удалитьВыбраннуюРаботуToolStripMenuItem.Size = new System.Drawing.Size(172, 20);
            this.удалитьВыбраннуюРаботуToolStripMenuItem.Text = "Удалить выбранную работу";
            this.удалитьВыбраннуюРаботуToolStripMenuItem.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // FormRepairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(886, 573);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRepairs";
            this.Text = "Ремонтные работы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьРемонтунюРаботуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбраннуюРаботуToolStripMenuItem;
    }
}