namespace Indent_alignment_for_tables
{
    partial class Form1
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
			this.textControl1 = new TXTextControl.TextControl();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.paragraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.insert3x4TableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusBar1 = new TXTextControl.StatusBar();
			this.rulerBar1 = new TXTextControl.RulerBar();
			this.rulerBar2 = new TXTextControl.RulerBar();
			this.buttonBar1 = new TXTextControl.ButtonBar();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textControl1
			// 
			this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
			this.textControl1.FormattingPrinter = "Standard";
			this.textControl1.Location = new System.Drawing.Point(38, 117);
			this.textControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textControl1.Name = "textControl1";
			this.textControl1.Size = new System.Drawing.Size(1138, 716);
			this.textControl1.TabIndex = 0;
			this.textControl1.Text = "textControl1";
			this.textControl1.UserNames = null;
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.tableToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1176, 35);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(165, 34);
			this.loadToolStripMenuItem.Text = "Load...";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(165, 34);
			this.saveToolStripMenuItem.Text = "Save...";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 34);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// formatToolStripMenuItem
			// 
			this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.characterToolStripMenuItem,
            this.paragraphToolStripMenuItem});
			this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
			this.formatToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
			this.formatToolStripMenuItem.Text = "Format";
			// 
			// characterToolStripMenuItem
			// 
			this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
			this.characterToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
			this.characterToolStripMenuItem.Text = "Character...";
			this.characterToolStripMenuItem.Click += new System.EventHandler(this.characterToolStripMenuItem_Click);
			// 
			// paragraphToolStripMenuItem
			// 
			this.paragraphToolStripMenuItem.Name = "paragraphToolStripMenuItem";
			this.paragraphToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
			this.paragraphToolStripMenuItem.Text = "Paragraph...";
			this.paragraphToolStripMenuItem.Click += new System.EventHandler(this.paragraphToolStripMenuItem_Click);
			// 
			// tableToolStripMenuItem
			// 
			this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insert3x4TableToolStripMenuItem,
            this.deleteTableToolStripMenuItem});
			this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
			this.tableToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
			this.tableToolStripMenuItem.Text = "Table";
			// 
			// insert3x4TableToolStripMenuItem
			// 
			this.insert3x4TableToolStripMenuItem.Name = "insert3x4TableToolStripMenuItem";
			this.insert3x4TableToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.insert3x4TableToolStripMenuItem.Text = "Insert 3x4 table";
			this.insert3x4TableToolStripMenuItem.Click += new System.EventHandler(this.insert3x4TableToolStripMenuItem_Click);
			// 
			// deleteTableToolStripMenuItem
			// 
			this.deleteTableToolStripMenuItem.Name = "deleteTableToolStripMenuItem";
			this.deleteTableToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.deleteTableToolStripMenuItem.Text = "Delete table";
			this.deleteTableToolStripMenuItem.Click += new System.EventHandler(this.deleteTableToolStripMenuItem_Click);
			// 
			// statusBar1
			// 
			this.statusBar1.BackColor = System.Drawing.SystemColors.Control;
			this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.statusBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.statusBar1.Location = new System.Drawing.Point(0, 833);
			this.statusBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(1176, 35);
			this.statusBar1.TabIndex = 2;
			// 
			// rulerBar1
			// 
			this.rulerBar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.rulerBar1.Location = new System.Drawing.Point(38, 79);
			this.rulerBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rulerBar1.Name = "rulerBar1";
			this.rulerBar1.Size = new System.Drawing.Size(1138, 38);
			this.rulerBar1.TabIndex = 3;
			this.rulerBar1.Text = "rulerBar1";
			// 
			// rulerBar2
			// 
			this.rulerBar2.Alignment = TXTextControl.RulerBarAlignment.Left;
			this.rulerBar2.Dock = System.Windows.Forms.DockStyle.Left;
			this.rulerBar2.Location = new System.Drawing.Point(0, 79);
			this.rulerBar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rulerBar2.Name = "rulerBar2";
			this.rulerBar2.Size = new System.Drawing.Size(38, 754);
			this.rulerBar2.TabIndex = 4;
			this.rulerBar2.Text = "rulerBar2";
			// 
			// buttonBar1
			// 
			this.buttonBar1.BackColor = System.Drawing.SystemColors.Control;
			this.buttonBar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonBar1.Location = new System.Drawing.Point(0, 35);
			this.buttonBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonBar1.Name = "buttonBar1";
			this.buttonBar1.Size = new System.Drawing.Size(1176, 44);
			this.buttonBar1.TabIndex = 5;
			this.buttonBar1.Text = "buttonBar1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1176, 868);
			this.Controls.Add(this.textControl1);
			this.Controls.Add(this.rulerBar1);
			this.Controls.Add(this.rulerBar2);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.buttonBar1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private TXTextControl.TextControl textControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paragraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insert3x4TableToolStripMenuItem;
        private TXTextControl.StatusBar statusBar1;
        private TXTextControl.RulerBar rulerBar1;
        private TXTextControl.RulerBar rulerBar2;
        private TXTextControl.ButtonBar buttonBar1;
        private System.Windows.Forms.ToolStripMenuItem deleteTableToolStripMenuItem;
    }
}

