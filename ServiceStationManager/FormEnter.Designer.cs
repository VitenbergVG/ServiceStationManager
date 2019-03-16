namespace ServiceStationManager
{
    partial class FormEnter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnter));
            this.btEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbLoginDB = new System.Windows.Forms.TextBox();
            this.tbPassDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.запуститьПрограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEnter
            // 
            this.btEnter.BackColor = System.Drawing.Color.SeaShell;
            this.btEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnter.Location = new System.Drawing.Point(299, 233);
            this.btEnter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(153, 57);
            this.btEnter.TabIndex = 0;
            this.btEnter.Text = "Войти";
            this.btEnter.UseVisualStyleBackColor = false;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя пользователя БД";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbLoginDB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPassDB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbIP, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbPort, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbLogin, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbPass, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(436, 198);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tbLoginDB
            // 
            this.tbLoginDB.Location = new System.Drawing.Point(214, 4);
            this.tbLoginDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLoginDB.Name = "tbLoginDB";
            this.tbLoginDB.Size = new System.Drawing.Size(205, 22);
            this.tbLoginDB.TabIndex = 2;
            this.tbLoginDB.Text = "root";
            // 
            // tbPassDB
            // 
            this.tbPassDB.Location = new System.Drawing.Point(214, 36);
            this.tbPassDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassDB.Name = "tbPassDB";
            this.tbPassDB.Size = new System.Drawing.Size(205, 22);
            this.tbPassDB.TabIndex = 3;
            this.tbPassDB.Text = "0689";
            this.tbPassDB.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль БД";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(214, 68);
            this.tbIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(205, 22);
            this.tbIP.TabIndex = 4;
            this.tbIP.Text = "localhost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Порт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Логин в системе";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(214, 100);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPort.MaxLength = 10;
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(205, 22);
            this.tbPort.TabIndex = 9;
            this.tbPort.Text = "3306";
            this.tbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPort_KeyPress);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(214, 132);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(205, 22);
            this.tbLogin.TabIndex = 10;
            this.tbLogin.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP-адрес БД";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Пароль в системе";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(214, 164);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(205, 22);
            this.tbPass.TabIndex = 12;
            this.tbPass.Text = "admin";
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Система управления СТО";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьПрограммуToolStripMenuItem,
            this.добавитьКлиентаToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(234, 114);
            // 
            // запуститьПрограммуToolStripMenuItem
            // 
            this.запуститьПрограммуToolStripMenuItem.Name = "запуститьПрограммуToolStripMenuItem";
            this.запуститьПрограммуToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.запуститьПрограммуToolStripMenuItem.Text = "Запустить программу";
            this.запуститьПрограммуToolStripMenuItem.Click += new System.EventHandler(this.запуститьПрограммуToolStripMenuItem_Click);
            // 
            // добавитьКлиентаToolStripMenuItem
            // 
            this.добавитьКлиентаToolStripMenuItem.Image = global::ServiceStationManager.Properties.Resources.user_add;
            this.добавитьКлиентаToolStripMenuItem.Name = "добавитьКлиентаToolStripMenuItem";
            this.добавитьКлиентаToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.добавитьКлиентаToolStripMenuItem.Text = "Добавить клиента";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Image = global::ServiceStationManager.Properties.Resources.help;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::ServiceStationManager.Properties.Resources.cross;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // FormEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(463, 305);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEnter";
            this.Text = "Вход";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbLoginDB;
        private System.Windows.Forms.TextBox tbPassDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem запуститьПрограммуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

