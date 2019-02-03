namespace ServiceStationManager
{
    partial class FormAboutCar
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
            this.dgvAboutCar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAboutCar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAboutCar
            // 
            this.dgvAboutCar.AllowUserToAddRows = false;
            this.dgvAboutCar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAboutCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAboutCar.Location = new System.Drawing.Point(12, 12);
            this.dgvAboutCar.Name = "dgvAboutCar";
            this.dgvAboutCar.Size = new System.Drawing.Size(413, 59);
            this.dgvAboutCar.TabIndex = 1;
            // 
            // FormAboutCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 86);
            this.Controls.Add(this.dgvAboutCar);
            this.Name = "FormAboutCar";
            this.Text = "FormAboutCar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAboutCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAboutCar;
    }
}