namespace WindowsFormsApplication1
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пунктМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.toolsPanel = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.codeArea = new System.Windows.Forms.TextBox();
            this.topMenu.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1025, 24);
            this.topMenu.TabIndex = 1;
            this.topMenu.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пунктМенюToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // пунктМенюToolStripMenuItem
            // 
            this.пунктМенюToolStripMenuItem.Name = "пунктМенюToolStripMenuItem";
            this.пунктМенюToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.пунктМенюToolStripMenuItem.Text = "Пункт меню";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid.Location = new System.Drawing.Point(772, 24);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.propertyGrid.Size = new System.Drawing.Size(253, 507);
            this.propertyGrid.TabIndex = 2;
            // 
            // toolsPanel
            // 
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolsPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolsPanel.Location = new System.Drawing.Point(0, 24);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(81, 507);
            this.toolsPanel.TabIndex = 3;
            this.toolsPanel.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(78, 20);
            this.toolStripButton1.Text = "Элемент1";
            this.toolStripButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton1_MouseDown);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(78, 20);
            this.toolStripButton2.Text = "Элемент2";
            this.toolStripButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton2_MouseDown);
            // 
            // codeArea
            // 
            this.codeArea.AllowDrop = true;
            this.codeArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeArea.Location = new System.Drawing.Point(81, 24);
            this.codeArea.Multiline = true;
            this.codeArea.Name = "codeArea";
            this.codeArea.Size = new System.Drawing.Size(691, 507);
            this.codeArea.TabIndex = 4;
            this.codeArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.codeArea_DragDrop);
            this.codeArea.DragEnter += new System.Windows.Forms.DragEventHandler(this.codeArea_DragEnter);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 531);
            this.Controls.Add(this.codeArea);
            this.Controls.Add(this.toolsPanel);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.topMenu);
            this.MainMenuStrip = this.topMenu;
            this.Name = "MainForm";
            this.Text = "MachineIDE";
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пунктМенюToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.ToolStrip toolsPanel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TextBox codeArea;

    }
}

