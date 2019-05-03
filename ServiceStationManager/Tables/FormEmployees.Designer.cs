namespace ServiceStationManager
{
    partial class FormEmployees
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployees));
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактроватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбранногоСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьСотрулникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.внутренниеОперацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уволитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеДанныхСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заведениеОтпускаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 28);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(1279, 717);
            this.dgvEmployees.TabIndex = 7;
            this.dgvEmployees.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployees_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.редактроватьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 52);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // редактроватьToolStripMenuItem
            // 
            this.редактроватьToolStripMenuItem.Name = "редактроватьToolStripMenuItem";
            this.редактроватьToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.редактроватьToolStripMenuItem.Text = "Редактровать";
            this.редактроватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьСотрулникаToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaShell;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСотрудникаToolStripMenuItem,
            this.удалитьВыбранногоСотрудникаToolStripMenuItem,
            this.редактироватьСотрулникаToolStripMenuItem,
            this.внутренниеОперацииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1279, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьСотрудникаToolStripMenuItem
            // 
            this.добавитьСотрудникаToolStripMenuItem.Name = "добавитьСотрудникаToolStripMenuItem";
            this.добавитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.добавитьСотрудникаToolStripMenuItem.Text = "Добавить сотрудника...";
            this.добавитьСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // удалитьВыбранногоСотрудникаToolStripMenuItem
            // 
            this.удалитьВыбранногоСотрудникаToolStripMenuItem.Name = "удалитьВыбранногоСотрудникаToolStripMenuItem";
            this.удалитьВыбранногоСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.удалитьВыбранногоСотрудникаToolStripMenuItem.Text = "Удалить сотрудника";
            this.удалитьВыбранногоСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // редактироватьСотрулникаToolStripMenuItem
            // 
            this.редактироватьСотрулникаToolStripMenuItem.Name = "редактироватьСотрулникаToolStripMenuItem";
            this.редактироватьСотрулникаToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.редактироватьСотрулникаToolStripMenuItem.Text = "Редактировать сотрудника...";
            this.редактироватьСотрулникаToolStripMenuItem.Click += new System.EventHandler(this.редактироватьСотрулникаToolStripMenuItem_Click);
            // 
            // внутренниеОперацииToolStripMenuItem
            // 
            this.внутренниеОперацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.уволитьСотрудникаToolStripMenuItem,
            this.редактированиеДанныхСотрудникаToolStripMenuItem,
            this.заведениеОтпускаToolStripMenuItem});
            this.внутренниеОперацииToolStripMenuItem.Name = "внутренниеОперацииToolStripMenuItem";
            this.внутренниеОперацииToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.внутренниеОперацииToolStripMenuItem.Text = "Внутренние операции";
            // 
            // уволитьСотрудникаToolStripMenuItem
            // 
            this.уволитьСотрудникаToolStripMenuItem.Name = "уволитьСотрудникаToolStripMenuItem";
            this.уволитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.уволитьСотрудникаToolStripMenuItem.Text = "Увольнение сотрудника...";
            // 
            // редактированиеДанныхСотрудникаToolStripMenuItem
            // 
            this.редактированиеДанныхСотрудникаToolStripMenuItem.Name = "редактированиеДанныхСотрудникаToolStripMenuItem";
            this.редактированиеДанныхСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.редактированиеДанныхСотрудникаToolStripMenuItem.Text = "Редактирование данных сотрудника...";
            // 
            // заведениеОтпускаToolStripMenuItem
            // 
            this.заведениеОтпускаToolStripMenuItem.Name = "заведениеОтпускаToolStripMenuItem";
            this.заведениеОтпускаToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.заведениеОтпускаToolStripMenuItem.Text = "Заведение отпуска...";
            this.заведениеОтпускаToolStripMenuItem.Click += new System.EventHandler(this.заведениеОтпускаToolStripMenuItem_Click);
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(1279, 745);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEmployees";
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбранногоСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьСотрулникаToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem внутренниеОперацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уволитьСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеДанныхСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заведениеОтпускаToolStripMenuItem;
    }
}