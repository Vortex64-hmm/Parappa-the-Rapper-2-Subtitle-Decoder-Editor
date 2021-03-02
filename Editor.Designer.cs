
namespace yh9uoip
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveAction = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsAction = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveRawLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRawLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.noToolsYetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editBox = new System.Windows.Forms.TextBox();
            this.loadRawLines = new System.Windows.Forms.OpenFileDialog();
            this.saveRawLines = new System.Windows.Forms.SaveFileDialog();
            this.saveOLM = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.toolsMenu,
            this.viewMenu,
            this.aboutMenu});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 22);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolb";
            // 
            // fileMenu
            // 
            this.fileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAction,
            this.saveAsAction,
            this.toolStripSeparator1,
            this.saveRawLinesToolStripMenuItem,
            this.loadRawLinesToolStripMenuItem,
            this.toolStripSeparator2,
            this.exit});
            this.fileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.ShowDropDownArrow = false;
            this.fileMenu.Size = new System.Drawing.Size(29, 19);
            this.fileMenu.Text = "File";
            // 
            // saveAction
            // 
            this.saveAction.Name = "saveAction";
            this.saveAction.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAction.Size = new System.Drawing.Size(208, 22);
            this.saveAction.Text = "Save";
            this.saveAction.Click += new System.EventHandler(this.save);
            // 
            // saveAsAction
            // 
            this.saveAsAction.Name = "saveAsAction";
            this.saveAsAction.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsAction.Size = new System.Drawing.Size(208, 22);
            this.saveAsAction.Text = "Save as...";
            this.saveAsAction.Click += new System.EventHandler(this.saveAs);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // saveRawLinesToolStripMenuItem
            // 
            this.saveRawLinesToolStripMenuItem.Name = "saveRawLinesToolStripMenuItem";
            this.saveRawLinesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.saveRawLinesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.saveRawLinesToolStripMenuItem.Text = "Save raw subtitles";
            this.saveRawLinesToolStripMenuItem.Click += new System.EventHandler(this.saveRawLinesToolStripMenuItem_Click);
            // 
            // loadRawLinesToolStripMenuItem
            // 
            this.loadRawLinesToolStripMenuItem.Name = "loadRawLinesToolStripMenuItem";
            this.loadRawLinesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.loadRawLinesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.loadRawLinesToolStripMenuItem.Text = "Load raw subtitles";
            this.loadRawLinesToolStripMenuItem.Click += new System.EventHandler(this.loadRawLinesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(208, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noToolsYetToolStripMenuItem});
            this.toolsMenu.Image = ((System.Drawing.Image)(resources.GetObject("toolsMenu.Image")));
            this.toolsMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.ShowDropDownArrow = false;
            this.toolsMenu.Size = new System.Drawing.Size(38, 19);
            this.toolsMenu.Text = "Tools";
            // 
            // noToolsYetToolStripMenuItem
            // 
            this.noToolsYetToolStripMenuItem.Enabled = false;
            this.noToolsYetToolStripMenuItem.Name = "noToolsYetToolStripMenuItem";
            this.noToolsYetToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.noToolsYetToolStripMenuItem.Text = "No tools yet :(";
            // 
            // viewMenu
            // 
            this.viewMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.wordWrap});
            this.viewMenu.Image = ((System.Drawing.Image)(resources.GetObject("viewMenu.Image")));
            this.viewMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.ShowDropDownArrow = false;
            this.viewMenu.Size = new System.Drawing.Size(36, 19);
            this.viewMenu.Text = "View";
            this.viewMenu.ToolTipText = "View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomIn,
            this.zoomOut});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomIn
            // 
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomIn.Size = new System.Drawing.Size(222, 22);
            this.zoomIn.Text = "Zoom In";
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomOut.Size = new System.Drawing.Size(222, 22);
            this.zoomOut.Text = "Zoom Out";
            this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
            // 
            // wordWrap
            // 
            this.wordWrap.Name = "wordWrap";
            this.wordWrap.Size = new System.Drawing.Size(134, 22);
            this.wordWrap.Text = "Word Wrap";
            this.wordWrap.Click += new System.EventHandler(this.worldWrapToolStripMenuItem_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutButton});
            this.aboutMenu.Image = ((System.Drawing.Image)(resources.GetObject("aboutMenu.Image")));
            this.aboutMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.ShowDropDownArrow = false;
            this.aboutMenu.Size = new System.Drawing.Size(36, 19);
            this.aboutMenu.Text = "Help";
            this.aboutMenu.ToolTipText = "About";
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.aboutButton.Size = new System.Drawing.Size(199, 22);
            this.aboutButton.Text = "About PTR2SDE";
            this.aboutButton.Click += new System.EventHandler(this.aboutPTR2SDEToolStripMenuItem_Click);
            // 
            // editBox
            // 
            this.editBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editBox.Location = new System.Drawing.Point(0, 22);
            this.editBox.Multiline = true;
            this.editBox.Name = "editBox";
            this.editBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.editBox.Size = new System.Drawing.Size(800, 428);
            this.editBox.TabIndex = 1;
            this.editBox.WordWrap = false;
            // 
            // loadRawLines
            // 
            this.loadRawLines.Filter = "PTR2SDE\'s Raw Lines|*.ptrl|All files|*.*";
            // 
            // saveRawLines
            // 
            this.saveRawLines.Filter = "PTR2SDE\'s Raw Lines|*.ptrl|All files|*.*";
            // 
            // saveOLM
            // 
            this.saveOLM.Filter = "OLM File|*.olm|All files|*.*";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editBox);
            this.Controls.Add(this.toolStrip);
            this.Name = "Editor";
            this.Text = "Untitled - PTR2SDE Editor";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.TextBox editBox;
        private System.Windows.Forms.OpenFileDialog loadRawLines;
        private System.Windows.Forms.SaveFileDialog saveRawLines;
        private System.Windows.Forms.SaveFileDialog saveOLM;
        private System.Windows.Forms.ToolStripDropDownButton fileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAction;
        private System.Windows.Forms.ToolStripMenuItem saveAsAction;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveRawLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRawLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripDropDownButton toolsMenu;
        private System.Windows.Forms.ToolStripDropDownButton viewMenu;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomIn;
        private System.Windows.Forms.ToolStripMenuItem zoomOut;
        private System.Windows.Forms.ToolStripDropDownButton aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private System.Windows.Forms.ToolStripMenuItem noToolsYetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrap;
    }
}