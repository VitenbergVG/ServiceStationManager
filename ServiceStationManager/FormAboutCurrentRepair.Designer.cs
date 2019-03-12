namespace ServiceStationManager
{
    partial class FormAboutCurrentRepair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutCurrentRepair));
            this.dgvInfoCurrentRepairs = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtDeleteRepair = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoCurrentRepairs)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInfoCurrentRepairs
            // 
            this.dgvInfoCurrentRepairs.AllowUserToAddRows = false;
            this.dgvInfoCurrentRepairs.AllowUserToDeleteRows = false;
            this.dgvInfoCurrentRepairs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInfoCurrentRepairs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInfoCurrentRepairs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvInfoCurrentRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoCurrentRepairs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInfoCurrentRepairs.Location = new System.Drawing.Point(0, 25);
            this.dgvInfoCurrentRepairs.Margin = new System.Windows.Forms.Padding(0);
            this.dgvInfoCurrentRepairs.Name = "dgvInfoCurrentRepairs";
            this.dgvInfoCurrentRepairs.ReadOnly = true;
            this.dgvInfoCurrentRepairs.Size = new System.Drawing.Size(896, 239);
            this.dgvInfoCurrentRepairs.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtDeleteRepair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(896, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtDeleteRepair
            // 
            this.toolStripBtDeleteRepair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtDeleteRepair.Image = global::ServiceStationManager.Properties.Resources.cog_delete;
            this.toolStripBtDeleteRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtDeleteRepair.Name = "toolStripBtDeleteRepair";
            this.toolStripBtDeleteRepair.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtDeleteRepair.Text = "Удалить работу";
            this.toolStripBtDeleteRepair.Click += new System.EventHandler(this.toolStripBtDeleteRepair_Click);
            // 
            // FormAboutCurrentRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(896, 264);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvInfoCurrentRepairs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAboutCurrentRepair";
            this.Text = "Полная информация о проведённых работах";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoCurrentRepairs)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfoCurrentRepairs;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtDeleteRepair;
    }
}