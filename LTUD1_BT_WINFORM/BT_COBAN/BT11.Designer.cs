namespace BT8_LISTBOX
{
    partial class BT11
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
            menuStrip1 = new MenuStrip();
            bT01ToolStripMenuItem = new ToolStripMenuItem();
            bT02ToolStripMenuItem = new ToolStripMenuItem();
            baiTapToolStripMenuItem = new ToolStripMenuItem();
            heThongToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { heThongToolStripMenuItem, baiTapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // bT01ToolStripMenuItem
            // 
            bT01ToolStripMenuItem.Name = "bT01ToolStripMenuItem";
            bT01ToolStripMenuItem.Size = new Size(108, 24);
            bT01ToolStripMenuItem.Text = "BT01";
            // 
            // bT02ToolStripMenuItem
            // 
            bT02ToolStripMenuItem.Name = "bT02ToolStripMenuItem";
            bT02ToolStripMenuItem.Size = new Size(108, 24);
            bT02ToolStripMenuItem.Text = "BT02";
            // 
            // baiTapToolStripMenuItem
            // 
            baiTapToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bT01ToolStripMenuItem, bT02ToolStripMenuItem });
            baiTapToolStripMenuItem.Name = "baiTapToolStripMenuItem";
            baiTapToolStripMenuItem.Size = new Size(63, 23);
            baiTapToolStripMenuItem.Text = "Bai Tap";
            // 
            // heThongToolStripMenuItem
            // 
            heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            heThongToolStripMenuItem.Size = new Size(79, 23);
            heThongToolStripMenuItem.Text = "He thong";
            // 
            // BT11
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "BT11";
            Text = "BT11";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem heThongToolStripMenuItem;
        private ToolStripMenuItem baiTapToolStripMenuItem;
        private ToolStripMenuItem bT01ToolStripMenuItem;
        private ToolStripMenuItem bT02ToolStripMenuItem;
    }
}