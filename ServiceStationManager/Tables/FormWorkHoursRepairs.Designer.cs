﻿namespace ServiceStationManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btAdd = new System.Windows.Forms.Button();
            this.dgvWorkHoursRepairs = new System.Windows.Forms.DataGridView();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkHoursRepairs)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.SeaShell;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Location = new System.Drawing.Point(994, 22);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(98, 37);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dgvWorkHoursRepairs
            // 
            this.dgvWorkHoursRepairs.AllowUserToAddRows = false;
            this.dgvWorkHoursRepairs.AllowUserToDeleteRows = false;
            this.dgvWorkHoursRepairs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvWorkHoursRepairs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvWorkHoursRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkHoursRepairs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWorkHoursRepairs.Location = new System.Drawing.Point(12, 12);
            this.dgvWorkHoursRepairs.Name = "dgvWorkHoursRepairs";
            this.dgvWorkHoursRepairs.ReadOnly = true;
            this.dgvWorkHoursRepairs.Size = new System.Drawing.Size(965, 497);
            this.dgvWorkHoursRepairs.TabIndex = 7;
            this.dgvWorkHoursRepairs.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvWorkHoursRepairs_CellMouseDoubleClick);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.SeaShell;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Location = new System.Drawing.Point(994, 82);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(98, 37);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // FormWorkHoursRepairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(1103, 523);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgvWorkHoursRepairs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormWorkHoursRepairs";
            this.Text = "Расписание ремнотных работ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkHoursRepairs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        public System.Windows.Forms.DataGridView dgvWorkHoursRepairs;
        private System.Windows.Forms.Button btDelete;
    }
}