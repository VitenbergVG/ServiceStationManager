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
            this.dgvInfoCurrentRepairs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoCurrentRepairs)).BeginInit();
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
            this.dgvInfoCurrentRepairs.Location = new System.Drawing.Point(12, 12);
            this.dgvInfoCurrentRepairs.Name = "dgvInfoCurrentRepairs";
            this.dgvInfoCurrentRepairs.ReadOnly = true;
            this.dgvInfoCurrentRepairs.Size = new System.Drawing.Size(1124, 192);
            this.dgvInfoCurrentRepairs.TabIndex = 1;
            // 
            // FormAboutCurrentRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(1151, 217);
            this.Controls.Add(this.dgvInfoCurrentRepairs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAboutCurrentRepair";
            this.Text = "Полная информация о проведённых работах";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoCurrentRepairs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfoCurrentRepairs;
    }
}