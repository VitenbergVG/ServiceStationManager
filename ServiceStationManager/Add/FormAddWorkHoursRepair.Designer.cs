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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddWorkHoursRepair));
            this.cbNameRepair = new System.Windows.Forms.ComboBox();
            this.cbCategoryRepair = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btPicWorkHours = new System.Windows.Forms.Button();
            this.btPicClient = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.cbTimeStartIsEmpty = new System.Windows.Forms.CheckBox();
            this.cbTimeFinishIsEmpty = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelWorkHours = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.cbStatusRepair = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbNameRepair
            // 
            this.cbNameRepair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameRepair.FormattingEnabled = true;
            this.cbNameRepair.Location = new System.Drawing.Point(162, 69);
            this.cbNameRepair.Name = "cbNameRepair";
            this.cbNameRepair.Size = new System.Drawing.Size(220, 21);
            this.cbNameRepair.TabIndex = 62;
            this.cbNameRepair.SelectedIndexChanged += new System.EventHandler(this.cbNameRepair_SelectedIndexChanged);
            // 
            // cbCategoryRepair
            // 
            this.cbCategoryRepair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryRepair.FormattingEnabled = true;
            this.cbCategoryRepair.Location = new System.Drawing.Point(162, 39);
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
            this.label5.Location = new System.Drawing.Point(5, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
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
            this.label4.Location = new System.Drawing.Point(5, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
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
            this.label7.Location = new System.Drawing.Point(5, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
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
            this.label2.Location = new System.Drawing.Point(5, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Категория работы";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(434, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "ID =";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "ID =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Клиент";
            // 
            // btPicWorkHours
            // 
            this.btPicWorkHours.BackColor = System.Drawing.Color.SeaShell;
            this.btPicWorkHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPicWorkHours.Location = new System.Drawing.Point(164, 4);
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
            this.btPicClient.Location = new System.Drawing.Point(164, 100);
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
            this.btAdd.Location = new System.Drawing.Point(483, 226);
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
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Смена";
            // 
            // dtpStart
            // 
            this.dtpStart.Checked = false;
            this.dtpStart.CustomFormat = "";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStart.Location = new System.Drawing.Point(162, 135);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowUpDown = true;
            this.dtpStart.Size = new System.Drawing.Size(113, 20);
            this.dtpStart.TabIndex = 81;
            // 
            // dtpFinish
            // 
            this.dtpFinish.CustomFormat = "";
            this.dtpFinish.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinish.Location = new System.Drawing.Point(162, 165);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.ShowUpDown = true;
            this.dtpFinish.Size = new System.Drawing.Size(113, 20);
            this.dtpFinish.TabIndex = 81;
            // 
            // cbTimeStartIsEmpty
            // 
            this.cbTimeStartIsEmpty.AutoSize = true;
            this.cbTimeStartIsEmpty.BackColor = System.Drawing.Color.Transparent;
            this.cbTimeStartIsEmpty.Location = new System.Drawing.Point(388, 135);
            this.cbTimeStartIsEmpty.Name = "cbTimeStartIsEmpty";
            this.cbTimeStartIsEmpty.Size = new System.Drawing.Size(87, 17);
            this.cbTimeStartIsEmpty.TabIndex = 82;
            this.cbTimeStartIsEmpty.Text = "Неизвестно";
            this.cbTimeStartIsEmpty.UseVisualStyleBackColor = false;
            this.cbTimeStartIsEmpty.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbTimeFinishIsEmpty
            // 
            this.cbTimeFinishIsEmpty.AutoSize = true;
            this.cbTimeFinishIsEmpty.BackColor = System.Drawing.Color.Transparent;
            this.cbTimeFinishIsEmpty.Location = new System.Drawing.Point(388, 165);
            this.cbTimeFinishIsEmpty.Name = "cbTimeFinishIsEmpty";
            this.cbTimeFinishIsEmpty.Size = new System.Drawing.Size(87, 17);
            this.cbTimeFinishIsEmpty.TabIndex = 83;
            this.cbTimeFinishIsEmpty.Text = "Неизвестно";
            this.cbTimeFinishIsEmpty.UseVisualStyleBackColor = false;
            this.cbTimeFinishIsEmpty.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbTimeFinishIsEmpty, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpFinish, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbNameRepair, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbCategoryRepair, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btPicWorkHours, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btPicClient, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpStart, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbTimeStartIsEmpty, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelWorkHours, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelClient, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbStatusRepair, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btAdd, 3, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 277);
            this.tableLayoutPanel1.TabIndex = 84;
            // 
            // labelWorkHours
            // 
            this.labelWorkHours.AutoSize = true;
            this.labelWorkHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorkHours.Location = new System.Drawing.Point(483, 5);
            this.labelWorkHours.Margin = new System.Windows.Forms.Padding(5);
            this.labelWorkHours.Name = "labelWorkHours";
            this.labelWorkHours.Size = new System.Drawing.Size(0, 20);
            this.labelWorkHours.TabIndex = 85;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(483, 101);
            this.labelClient.Margin = new System.Windows.Forms.Padding(5);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(0, 20);
            this.labelClient.TabIndex = 84;
            // 
            // cbStatusRepair
            // 
            this.cbStatusRepair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusRepair.FormattingEnabled = true;
            this.cbStatusRepair.Items.AddRange(new object[] {
            "Не выполнено",
            "Продлено",
            "Выполнено"});
            this.cbStatusRepair.Location = new System.Drawing.Point(162, 195);
            this.cbStatusRepair.Name = "cbStatusRepair";
            this.cbStatusRepair.Size = new System.Drawing.Size(220, 21);
            this.cbStatusRepair.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 72;
            this.label9.Text = "Статус работы";
            // 
            // FormAddWorkHoursRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(608, 277);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddWorkHoursRepair";
            this.Text = "Добавить конкретную ремонтную работу";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbNameRepair;
        private System.Windows.Forms.ComboBox cbCategoryRepair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPicWorkHours;
        private System.Windows.Forms.Button btPicClient;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.CheckBox cbTimeStartIsEmpty;
        private System.Windows.Forms.CheckBox cbTimeFinishIsEmpty;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelWorkHours;
        private System.Windows.Forms.ComboBox cbStatusRepair;
        private System.Windows.Forms.Label label9;
    }
}