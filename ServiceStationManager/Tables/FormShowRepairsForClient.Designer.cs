namespace ServiceStationManager.Tables
{
    partial class FormShowRepairsForClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowRepairsForClient));
            this.dgvRepairsClient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepairsClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRepairsClient
            // 
            this.dgvRepairsClient.AllowUserToAddRows = false;
            this.dgvRepairsClient.AllowUserToDeleteRows = false;
            this.dgvRepairsClient.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRepairsClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepairsClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRepairsClient.Location = new System.Drawing.Point(0, 0);
            this.dgvRepairsClient.Name = "dgvRepairsClient";
            this.dgvRepairsClient.ReadOnly = true;
            this.dgvRepairsClient.Size = new System.Drawing.Size(800, 450);
            this.dgvRepairsClient.TabIndex = 0;
            // 
            // FormShowRepairsForClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRepairsClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormShowRepairsForClient";
            this.Text = "Работы по клиенту";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepairsClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRepairsClient;
    }
}