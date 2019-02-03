namespace ServiceStationManager.Add
{
    partial class FormAddWorkHoursRepair
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cbNameRepair = new System.Windows.Forms.ComboBox();
            this.cbCategoryRepair = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWorkHours = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btPicWorkHours = new System.Windows.Forms.Button();
            this.btPicClient = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(178, 274);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 78;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(178, 227);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 77;
            // 
            // cbNameRepair
            // 
            this.cbNameRepair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameRepair.FormattingEnabled = true;
            this.cbNameRepair.Location = new System.Drawing.Point(165, 110);
            this.cbNameRepair.Name = "cbNameRepair";
            this.cbNameRepair.Size = new System.Drawing.Size(220, 21);
            this.cbNameRepair.TabIndex = 62;
            this.cbNameRepair.SelectedIndexChanged += new System.EventHandler(this.cbNameRepair_SelectedIndexChanged);
            // 
            // cbCategoryRepair
            // 
            this.cbCategoryRepair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryRepair.FormattingEnabled = true;
            this.cbCategoryRepair.Location = new System.Drawing.Point(165, 57);
            this.cbCategoryRepair.Name = "cbCategoryRepair";
            this.cbCategoryRepair.Size = new System.Drawing.Size(220, 21);
            this.cbCategoryRepair.TabIndex = 63;
            this.cbCategoryRepair.SelectedIndexChanged += new System.EventHandler(this.cbCategoryRepair_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Время окончания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Время начала";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 70;
            this.label7.Text = "Название работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Категория работы";
            // 
            // labelWorkHours
            // 
            this.labelWorkHours.AutoSize = true;
            this.labelWorkHours.BackColor = System.Drawing.Color.Transparent;
            this.labelWorkHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkHours.Location = new System.Drawing.Point(337, 12);
            this.labelWorkHours.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelWorkHours.Name = "labelWorkHours";
            this.labelWorkHours.Size = new System.Drawing.Size(0, 20);
            this.labelWorkHours.TabIndex = 64;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.BackColor = System.Drawing.Color.Transparent;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.Location = new System.Drawing.Point(337, 169);
            this.labelClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(0, 20);
            this.labelClient.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(294, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "ID = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "ID = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Клиент";
            // 
            // btPicWorkHours
            // 
            this.btPicWorkHours.BackColor = System.Drawing.Color.SeaShell;
            this.btPicWorkHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPicWorkHours.Location = new System.Drawing.Point(165, 9);
            this.btPicWorkHours.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btPicWorkHours.Name = "btPicWorkHours";
            this.btPicWorkHours.Size = new System.Drawing.Size(113, 28);
            this.btPicWorkHours.TabIndex = 75;
            this.btPicWorkHours.Text = "Выбрать смену";
            this.btPicWorkHours.UseVisualStyleBackColor = false;
            this.btPicWorkHours.Click += new System.EventHandler(this.btPicWorkHours_Click);
            // 
            // btPicClient
            // 
            this.btPicClient.BackColor = System.Drawing.Color.SeaShell;
            this.btPicClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPicClient.Location = new System.Drawing.Point(165, 169);
            this.btPicClient.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btPicClient.Name = "btPicClient";
            this.btPicClient.Size = new System.Drawing.Size(113, 28);
            this.btPicClient.TabIndex = 76;
            this.btPicClient.Text = "Выбрать клиента";
            this.btPicClient.UseVisualStyleBackColor = false;
            this.btPicClient.Click += new System.EventHandler(this.btPicClient_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.SeaShell;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Location = new System.Drawing.Point(269, 340);
            this.btAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(120, 47);
            this.btAdd.TabIndex = 74;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Смена";
            // 
            // FormAddWorkHoursRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 400);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.cbNameRepair);
            this.Controls.Add(this.cbCategoryRepair);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWorkHours);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btPicWorkHours);
            this.Controls.Add(this.btPicClient);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label1);
            this.Name = "FormAddWorkHoursRepair";
            this.Text = "FormAddWorkHoursRepair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cbNameRepair;
        private System.Windows.Forms.ComboBox cbCategoryRepair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWorkHours;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPicWorkHours;
        private System.Windows.Forms.Button btPicClient;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label1;
    }
}