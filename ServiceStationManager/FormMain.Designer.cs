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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1133, 22);
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
            this.menuStrip1.Size = new System.Drawing.Size(1133, 24);
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
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(1133, 574);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}