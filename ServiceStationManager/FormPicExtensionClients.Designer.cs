namespace ServiceStationManager
{
    partial class FormPicExtensionClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPicExtensionClients));
            this.dgvExtentionWorks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtentionWorks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExtentionWorks
            // 
            this.dgvExtentionWorks.AllowUserToAddRows = false;
            this.dgvExtentionWorks.AllowUserToDeleteRows = false;
            this.dgvExtentionWorks.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvExtentionWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtentionWorks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExtentionWorks.Location = new System.Drawing.Point(0, 0);
            this.dgvExtentionWorks.Name = "dgvExtentionWorks";
            this.dgvExtentionWorks.ReadOnly = true;
            this.dgvExtentionWorks.Size = new System.Drawing.Size(761, 387);
            this.dgvExtentionWorks.TabIndex = 9;
            this.dgvExtentionWorks.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvExtentionWorks_CellMouseDoubleClick);
            // 
            // FormPicExtensionClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(761, 387);
            this.Controls.Add(this.dgvExtentionWorks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPicExtensionClients";
            this.Text = "Кликните два раза по нужному клиенту";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtentionWorks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvExtentionWorks;
    }
}