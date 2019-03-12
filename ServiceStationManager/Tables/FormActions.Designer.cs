namespace ServiceStationManager
{
    partial class FormActions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActions));
            this.dgvActions = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьАкциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыделеннуюАкциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьАкциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActions)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvActions
            // 
            this.dgvActions.AllowUserToAddRows = false;
            this.dgvActions.AllowUserToDeleteRows = false;
            this.dgvActions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvActions.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActions.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActions.Location = new System.Drawing.Point(0, 24);
            this.dgvActions.Name = "dgvActions";
            this.dgvActions.ReadOnly = true;
            this.dgvActions.Size = new System.Drawing.Size(1258, 472);
            this.dgvActions.TabIndex = 4;
            this.dgvActions.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvActions_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 48);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать...";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьАкциюToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaShell;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьАкциюToolStripMenuItem,
            this.удалитьВыделеннуюАкциюToolStripMenuItem,
            this.редактироватьАкциюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1258, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьАкциюToolStripMenuItem
            // 
            this.добавитьАкциюToolStripMenuItem.Name = "добавитьАкциюToolStripMenuItem";
            this.добавитьАкциюToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.добавитьАкциюToolStripMenuItem.Text = "Добавить акцию...";
            this.добавитьАкциюToolStripMenuItem.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // удалитьВыделеннуюАкциюToolStripMenuItem
            // 
            this.удалитьВыделеннуюАкциюToolStripMenuItem.Name = "удалитьВыделеннуюАкциюToolStripMenuItem";
            this.удалитьВыделеннуюАкциюToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.удалитьВыделеннуюАкциюToolStripMenuItem.Text = "Удалить акцию";
            this.удалитьВыделеннуюАкциюToolStripMenuItem.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // редактироватьАкциюToolStripMenuItem
            // 
            this.редактироватьАкциюToolStripMenuItem.Name = "редактироватьАкциюToolStripMenuItem";
            this.редактироватьАкциюToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.редактироватьАкциюToolStripMenuItem.Text = "Редактировать акцию...";
            this.редактироватьАкциюToolStripMenuItem.Click += new System.EventHandler(this.редактироватьАкциюToolStripMenuItem_Click);
            // 
            // FormActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceStationManager.Properties.Resources._0003_005_;
            this.ClientSize = new System.Drawing.Size(1258, 496);
            this.Controls.Add(this.dgvActions);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormActions";
            this.Text = "Акции";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActions)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvActions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьАкциюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыделеннуюАкциюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьАкциюToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}