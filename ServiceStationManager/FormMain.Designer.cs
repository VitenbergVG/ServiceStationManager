namespace ServiceStationManager
{
    partial class FormMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.информацияОКлиентахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокАвтомобилейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОСотрудникахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеРаботToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеСервисомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокАкцийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видыРемонтныхРаботToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtNewClient = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStripBtDeleteClient = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1228, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaShell;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОКлиентахToolStripMenuItem,
            this.информацияОСотрудникахToolStripMenuItem,
            this.заявкиToolStripMenuItem,
            this.управлениеСервисомToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1228, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // информацияОКлиентахToolStripMenuItem
            // 
            this.информацияОКлиентахToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокКлиентовToolStripMenuItem,
            this.списокАвтомобилейToolStripMenuItem});
            this.информацияОКлиентахToolStripMenuItem.Name = "информацияОКлиентахToolStripMenuItem";
            this.информацияОКлиентахToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.информацияОКлиентахToolStripMenuItem.Text = "Информация о клиентах";
            // 
            // списокКлиентовToolStripMenuItem
            // 
            this.списокКлиентовToolStripMenuItem.Name = "списокКлиентовToolStripMenuItem";
            this.списокКлиентовToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.списокКлиентовToolStripMenuItem.Text = "Список клиентов";
            this.списокКлиентовToolStripMenuItem.Click += new System.EventHandler(this.списокКлиентовToolStripMenuItem_Click);
            // 
            // списокАвтомобилейToolStripMenuItem
            // 
            this.списокАвтомобилейToolStripMenuItem.Name = "списокАвтомобилейToolStripMenuItem";
            this.списокАвтомобилейToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.списокАвтомобилейToolStripMenuItem.Text = "Список автомобилей";
            this.списокАвтомобилейToolStripMenuItem.Click += new System.EventHandler(this.списокАвтомобилейToolStripMenuItem_Click);
            // 
            // информацияОСотрудникахToolStripMenuItem
            // 
            this.информацияОСотрудникахToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСотрудниковToolStripMenuItem,
            this.расписаниеToolStripMenuItem,
            this.расписаниеРаботToolStripMenuItem});
            this.информацияОСотрудникахToolStripMenuItem.Name = "информацияОСотрудникахToolStripMenuItem";
            this.информацияОСотрудникахToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            this.информацияОСотрудникахToolStripMenuItem.Text = "Информация о сотрудниках";
            // 
            // списокСотрудниковToolStripMenuItem
            // 
            this.списокСотрудниковToolStripMenuItem.Name = "списокСотрудниковToolStripMenuItem";
            this.списокСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.списокСотрудниковToolStripMenuItem.Text = "Список сотрудников";
            this.списокСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.списокСотрудниковToolStripMenuItem_Click);
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.расписаниеToolStripMenuItem.Text = "Расписание";
            this.расписаниеToolStripMenuItem.Click += new System.EventHandler(this.расписаниеToolStripMenuItem_Click);
            // 
            // расписаниеРаботToolStripMenuItem
            // 
            this.расписаниеРаботToolStripMenuItem.Name = "расписаниеРаботToolStripMenuItem";
            this.расписаниеРаботToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.расписаниеРаботToolStripMenuItem.Text = "Расписание работ";
            this.расписаниеРаботToolStripMenuItem.Click += new System.EventHandler(this.расписаниеРаботToolStripMenuItem_Click);
            // 
            // заявкиToolStripMenuItem
            // 
            this.заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            this.заявкиToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.заявкиToolStripMenuItem.Text = "Заявки";
            this.заявкиToolStripMenuItem.Click += new System.EventHandler(this.заявкиToolStripMenuItem_Click);
            // 
            // управлениеСервисомToolStripMenuItem
            // 
            this.управлениеСервисомToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокАкцийToolStripMenuItem,
            this.видыРемонтныхРаботToolStripMenuItem});
            this.управлениеСервисомToolStripMenuItem.Name = "управлениеСервисомToolStripMenuItem";
            this.управлениеСервисомToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.управлениеСервисомToolStripMenuItem.Text = "Управление сервисом";
            // 
            // списокАкцийToolStripMenuItem
            // 
            this.списокАкцийToolStripMenuItem.Name = "списокАкцийToolStripMenuItem";
            this.списокАкцийToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.списокАкцийToolStripMenuItem.Text = "Список акций";
            this.списокАкцийToolStripMenuItem.Click += new System.EventHandler(this.списокАкцийToolStripMenuItem_Click);
            // 
            // видыРемонтныхРаботToolStripMenuItem
            // 
            this.видыРемонтныхРаботToolStripMenuItem.Name = "видыРемонтныхРаботToolStripMenuItem";
            this.видыРемонтныхРаботToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.видыРемонтныхРаботToolStripMenuItem.Text = "Виды ремонтных работ";
            this.видыРемонтныхРаботToolStripMenuItem.Click += new System.EventHandler(this.видыРемонтныхРаботToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SeaShell;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtNewClient,
            this.toolStripBtDeleteClient});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1228, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtNewClient
            // 
            this.toolStripBtNewClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtNewClient.Image = global::ServiceStationManager.Properties.Resources.user_add;
            this.toolStripBtNewClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtNewClient.Name = "toolStripBtNewClient";
            this.toolStripBtNewClient.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtNewClient.Text = "toolStripButton1";
            this.toolStripBtNewClient.ToolTipText = "Новый клиент";
            this.toolStripBtNewClient.Click += new System.EventHandler(this.toolStripBtNewClient_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1228, 527);
            this.tabControl1.TabIndex = 10;
            // 
            // toolStripBtDeleteClient
            // 
            this.toolStripBtDeleteClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtDeleteClient.Image = global::ServiceStationManager.Properties.Resources.user_delete;
            this.toolStripBtDeleteClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtDeleteClient.Name = "toolStripBtDeleteClient";
            this.toolStripBtDeleteClient.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtDeleteClient.Text = "Завершить работу с клиентом";
            this.toolStripBtDeleteClient.Click += new System.EventHandler(this.toolStripBtDeleteClient_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(1228, 598);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Система управления станцией технического обслуживания автомобилей";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem информацияОКлиентахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКлиентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокАвтомобилейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОСотрудникахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеРаботToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеСервисомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокАкцийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видыРемонтныхРаботToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripBtNewClient;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtDeleteClient;
    }
}