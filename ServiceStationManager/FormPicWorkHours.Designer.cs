﻿namespace ServiceStationManager
{
    partial class FormPicWorkHours
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
            this.btSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvWorkHours = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkHours)).BeginInit();
            this.SuspendLayout();
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.SeaShell;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Location = new System.Drawing.Point(554, 12);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(98, 37);
            this.btSearch.TabIndex = 13;
            this.btSearch.Text = "Поиск";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(37, 21);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(490, 20);
            this.tbSearch.TabIndex = 12;
            // 
            // dgvWorkHours
            // 
            this.dgvWorkHours.AllowUserToAddRows = false;
            this.dgvWorkHours.AllowUserToDeleteRows = false;
            this.dgvWorkHours.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvWorkHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkHours.Location = new System.Drawing.Point(12, 61);
            this.dgvWorkHours.Name = "dgvWorkHours";
            this.dgvWorkHours.ReadOnly = true;
            this.dgvWorkHours.Size = new System.Drawing.Size(776, 377);
            this.dgvWorkHours.TabIndex = 11;
            this.dgvWorkHours.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // FormPicWorkHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvWorkHours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPicWorkHours";
            this.Text = "Кликните дважды по нужной рабочей смене";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbSearch;
        public System.Windows.Forms.DataGridView dgvWorkHours;
    }
}