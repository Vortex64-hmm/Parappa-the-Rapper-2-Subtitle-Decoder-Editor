
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
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportSub = new System.Windows.Forms.ToolStripMenuItem();
            this.importSub = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitBut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.noToolsSign = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutBut = new System.Windows.Forms.ToolStripMenuItem();
            this.tabEdit = new System.Windows.Forms.TabControl();
            this.cutscenePage = new System.Windows.Forms.TabPage();
            this.cutscenePanel = new System.Windows.Forms.Panel();
            this.cutsceneView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cutsceneEditText = new System.Windows.Forms.TextBox();
            this.ctimingEndText = new System.Windows.Forms.TextBox();
            this.ctimingStartText = new System.Windows.Forms.TextBox();
            this.editBut = new System.Windows.Forms.Button();
            this.gameplayPage = new System.Windows.Forms.TabPage();
            this.gameplayPanel = new System.Windows.Forms.Panel();
            this.gameplayView = new System.Windows.Forms.ListView();
            this.gid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gtext = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gameplayEditTab = new System.Windows.Forms.Panel();
            this.gameplayEditText = new System.Windows.Forms.TextBox();
            this.geditButton = new System.Windows.Forms.Button();
            this.debugPage = new System.Windows.Forms.TabPage();
            this.debuggingText = new System.Windows.Forms.TextBox();
            this.saveOLM = new System.Windows.Forms.SaveFileDialog();
            this.toolBar.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.cutscenePage.SuspendLayout();
            this.cutscenePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gameplayPage.SuspendLayout();
            this.gameplayPanel.SuspendLayout();
            this.gameplayEditTab.SuspendLayout();
            this.debugPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.White;
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.toolStripDropDownButton2,
            this.helpMenu});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Padding = new System.Windows.Forms.Padding(0);
            this.toolBar.ShowItemToolTips = false;
            this.toolBar.Size = new System.Drawing.Size(800, 25);
            this.toolBar.TabIndex = 0;
            // 
            // fileMenu
            // 
            this.fileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save,
            this.saveAs,
            this.toolStripSeparator1,
            this.exportSub,
            this.importSub,
            this.toolStripSeparator2,
            this.exitBut});
            this.fileMenu.Image = ((System.Drawing.Image)(resources.GetObject("fileMenu.Image")));
            this.fileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.ShowDropDownArrow = false;
            this.fileMenu.Size = new System.Drawing.Size(29, 22);
            this.fileMenu.Text = "File";
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(157, 22);
            this.save.Text = "Save";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(157, 22);
            this.saveAs.Text = "Save as...";
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // exportSub
            // 
            this.exportSub.Name = "exportSub";
            this.exportSub.Size = new System.Drawing.Size(157, 22);
            this.exportSub.Text = "Export subtitles";
            this.exportSub.Click += new System.EventHandler(this.ToBeMade);
            // 
            // importSub
            // 
            this.importSub.Name = "importSub";
            this.importSub.Size = new System.Drawing.Size(157, 22);
            this.importSub.Text = "Import subtitles";
            this.importSub.Click += new System.EventHandler(this.ToBeMade);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // exitBut
            // 
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(157, 22);
            this.exitBut.Text = "Exit";
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noToolsSign});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton2.Text = "Tools";
            // 
            // noToolsSign
            // 
            this.noToolsSign.Enabled = false;
            this.noToolsSign.Name = "noToolsSign";
            this.noToolsSign.Size = new System.Drawing.Size(148, 22);
            this.noToolsSign.Text = "No tools yet :(";
            // 
            // helpMenu
            // 
            this.helpMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutBut});
            this.helpMenu.Image = ((System.Drawing.Image)(resources.GetObject("helpMenu.Image")));
            this.helpMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.ShowDropDownArrow = false;
            this.helpMenu.Size = new System.Drawing.Size(36, 22);
            this.helpMenu.Text = "Help";
            // 
            // aboutBut
            // 
            this.aboutBut.Name = "aboutBut";
            this.aboutBut.Size = new System.Drawing.Size(156, 22);
            this.aboutBut.Text = "About PTR2SDE";
            this.aboutBut.Click += new System.EventHandler(this.aboutBut_Click);
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.cutscenePage);
            this.tabEdit.Controls.Add(this.gameplayPage);
            this.tabEdit.Controls.Add(this.debugPage);
            this.tabEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEdit.Location = new System.Drawing.Point(0, 25);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.SelectedIndex = 0;
            this.tabEdit.Size = new System.Drawing.Size(800, 425);
            this.tabEdit.TabIndex = 1;
            // 
            // cutscenePage
            // 
            this.cutscenePage.AutoScroll = true;
            this.cutscenePage.BackColor = System.Drawing.Color.White;
            this.cutscenePage.Controls.Add(this.cutscenePanel);
            this.cutscenePage.Controls.Add(this.panel1);
            this.cutscenePage.Location = new System.Drawing.Point(4, 22);
            this.cutscenePage.Name = "cutscenePage";
            this.cutscenePage.Padding = new System.Windows.Forms.Padding(3);
            this.cutscenePage.Size = new System.Drawing.Size(792, 399);
            this.cutscenePage.TabIndex = 0;
            this.cutscenePage.Text = "Cutscene";
            // 
            // cutscenePanel
            // 
            this.cutscenePanel.Controls.Add(this.cutsceneView);
            this.cutscenePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cutscenePanel.Location = new System.Drawing.Point(3, 3);
            this.cutscenePanel.Name = "cutscenePanel";
            this.cutscenePanel.Size = new System.Drawing.Size(786, 363);
            this.cutscenePanel.TabIndex = 3;
            // 
            // cutsceneView
            // 
            this.cutsceneView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.cid,
            this.timeStart,
            this.timeEnd,
            this.text});
            this.cutsceneView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cutsceneView.FullRowSelect = true;
            this.cutsceneView.HideSelection = false;
            this.cutsceneView.Location = new System.Drawing.Point(0, 0);
            this.cutsceneView.MultiSelect = false;
            this.cutsceneView.Name = "cutsceneView";
            this.cutsceneView.Size = new System.Drawing.Size(786, 363);
            this.cutsceneView.TabIndex = 2;
            this.cutsceneView.UseCompatibleStateImageBehavior = false;
            this.cutsceneView.View = System.Windows.Forms.View.Details;
            this.cutsceneView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cutsceneView_MouseDoubleClick);
            this.cutsceneView.Resize += new System.EventHandler(this.cutsceneView_Resize);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 30;
            // 
            // cid
            // 
            this.cid.Text = "CID";
            this.cid.Width = 30;
            // 
            // timeStart
            // 
            this.timeStart.Text = "Start";
            // 
            // timeEnd
            // 
            this.timeEnd.Text = "End";
            // 
            // text
            // 
            this.text.Text = "Text";
            this.text.Width = 602;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cutsceneEditText);
            this.panel1.Controls.Add(this.ctimingEndText);
            this.panel1.Controls.Add(this.ctimingStartText);
            this.panel1.Controls.Add(this.editBut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 30);
            this.panel1.TabIndex = 2;
            // 
            // cutsceneEditText
            // 
            this.cutsceneEditText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cutsceneEditText.Location = new System.Drawing.Point(167, 6);
            this.cutsceneEditText.Name = "cutsceneEditText";
            this.cutsceneEditText.Size = new System.Drawing.Size(533, 20);
            this.cutsceneEditText.TabIndex = 3;
            // 
            // ctimingEndText
            // 
            this.ctimingEndText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ctimingEndText.Location = new System.Drawing.Point(86, 6);
            this.ctimingEndText.Name = "ctimingEndText";
            this.ctimingEndText.Size = new System.Drawing.Size(75, 20);
            this.ctimingEndText.TabIndex = 2;
            // 
            // ctimingStartText
            // 
            this.ctimingStartText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ctimingStartText.Location = new System.Drawing.Point(5, 6);
            this.ctimingStartText.Name = "ctimingStartText";
            this.ctimingStartText.Size = new System.Drawing.Size(75, 20);
            this.ctimingStartText.TabIndex = 1;
            // 
            // editBut
            // 
            this.editBut.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editBut.Location = new System.Drawing.Point(706, 6);
            this.editBut.Name = "editBut";
            this.editBut.Size = new System.Drawing.Size(75, 20);
            this.editBut.TabIndex = 0;
            this.editBut.Text = "Edit";
            this.editBut.UseVisualStyleBackColor = true;
            this.editBut.Click += new System.EventHandler(this.editBut_Click);
            // 
            // gameplayPage
            // 
            this.gameplayPage.AutoScroll = true;
            this.gameplayPage.BackColor = System.Drawing.Color.White;
            this.gameplayPage.Controls.Add(this.gameplayPanel);
            this.gameplayPage.Controls.Add(this.gameplayEditTab);
            this.gameplayPage.Location = new System.Drawing.Point(4, 22);
            this.gameplayPage.Name = "gameplayPage";
            this.gameplayPage.Padding = new System.Windows.Forms.Padding(3);
            this.gameplayPage.Size = new System.Drawing.Size(792, 399);
            this.gameplayPage.TabIndex = 1;
            this.gameplayPage.Text = "Gameplay";
            // 
            // gameplayPanel
            // 
            this.gameplayPanel.Controls.Add(this.gameplayView);
            this.gameplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameplayPanel.Location = new System.Drawing.Point(3, 3);
            this.gameplayPanel.Name = "gameplayPanel";
            this.gameplayPanel.Size = new System.Drawing.Size(786, 363);
            this.gameplayPanel.TabIndex = 5;
            // 
            // gameplayView
            // 
            this.gameplayView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gid,
            this.gtext});
            this.gameplayView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameplayView.FullRowSelect = true;
            this.gameplayView.HideSelection = false;
            this.gameplayView.Location = new System.Drawing.Point(0, 0);
            this.gameplayView.MultiSelect = false;
            this.gameplayView.Name = "gameplayView";
            this.gameplayView.Size = new System.Drawing.Size(786, 363);
            this.gameplayView.TabIndex = 3;
            this.gameplayView.UseCompatibleStateImageBehavior = false;
            this.gameplayView.View = System.Windows.Forms.View.Details;
            this.gameplayView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gameplayView_MouseDoubleClick);
            this.gameplayView.Resize += new System.EventHandler(this.gameplayView_Resize);
            // 
            // gid
            // 
            this.gid.Text = "ID";
            this.gid.Width = 30;
            // 
            // gtext
            // 
            this.gtext.Text = "Text";
            this.gtext.Width = 752;
            // 
            // gameplayEditTab
            // 
            this.gameplayEditTab.Controls.Add(this.gameplayEditText);
            this.gameplayEditTab.Controls.Add(this.geditButton);
            this.gameplayEditTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gameplayEditTab.Location = new System.Drawing.Point(3, 366);
            this.gameplayEditTab.Name = "gameplayEditTab";
            this.gameplayEditTab.Size = new System.Drawing.Size(786, 30);
            this.gameplayEditTab.TabIndex = 4;
            // 
            // gameplayEditText
            // 
            this.gameplayEditText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gameplayEditText.Location = new System.Drawing.Point(5, 6);
            this.gameplayEditText.Name = "gameplayEditText";
            this.gameplayEditText.Size = new System.Drawing.Size(695, 20);
            this.gameplayEditText.TabIndex = 3;
            // 
            // geditButton
            // 
            this.geditButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.geditButton.Location = new System.Drawing.Point(706, 6);
            this.geditButton.Name = "geditButton";
            this.geditButton.Size = new System.Drawing.Size(75, 20);
            this.geditButton.TabIndex = 0;
            this.geditButton.Text = "Edit";
            this.geditButton.UseVisualStyleBackColor = true;
            this.geditButton.Click += new System.EventHandler(this.geditButton_Click);
            // 
            // debugPage
            // 
            this.debugPage.Controls.Add(this.debuggingText);
            this.debugPage.Location = new System.Drawing.Point(4, 22);
            this.debugPage.Name = "debugPage";
            this.debugPage.Size = new System.Drawing.Size(792, 399);
            this.debugPage.TabIndex = 2;
            this.debugPage.Text = "Debug";
            this.debugPage.UseVisualStyleBackColor = true;
            // 
            // debuggingText
            // 
            this.debuggingText.BackColor = System.Drawing.SystemColors.Window;
            this.debuggingText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debuggingText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debuggingText.Location = new System.Drawing.Point(0, 0);
            this.debuggingText.Multiline = true;
            this.debuggingText.Name = "debuggingText";
            this.debuggingText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debuggingText.Size = new System.Drawing.Size(792, 399);
            this.debuggingText.TabIndex = 2;
            // 
            // saveOLM
            // 
            this.saveOLM.Filter = "OLM file|*.olm|All files|*.*";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabEdit);
            this.Controls.Add(this.toolBar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editor";
            this.Text = "DBG00.OLM - PTR2SDE";
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.cutscenePage.ResumeLayout(false);
            this.cutscenePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gameplayPage.ResumeLayout(false);
            this.gameplayPanel.ResumeLayout(false);
            this.gameplayEditTab.ResumeLayout(false);
            this.gameplayEditTab.PerformLayout();
            this.debugPage.ResumeLayout(false);
            this.debugPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripDropDownButton fileMenu;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportSub;
        private System.Windows.Forms.ToolStripMenuItem importSub;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitBut;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem noToolsSign;
        private System.Windows.Forms.ToolStripDropDownButton helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutBut;
        private System.Windows.Forms.TabControl tabEdit;
        private System.Windows.Forms.TabPage cutscenePage;
        private System.Windows.Forms.TabPage gameplayPage;
        private System.Windows.Forms.TabPage debugPage;
        private System.Windows.Forms.TextBox debuggingText;
        private System.Windows.Forms.ListView cutsceneView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader cid;
        private System.Windows.Forms.ColumnHeader timeStart;
        private System.Windows.Forms.ColumnHeader timeEnd;
        private System.Windows.Forms.ColumnHeader text;
        private System.Windows.Forms.ListView gameplayView;
        private System.Windows.Forms.ColumnHeader gid;
        private System.Windows.Forms.ColumnHeader gtext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cutsceneEditText;
        private System.Windows.Forms.TextBox ctimingEndText;
        private System.Windows.Forms.TextBox ctimingStartText;
        private System.Windows.Forms.Button editBut;
        private System.Windows.Forms.Panel gameplayEditTab;
        private System.Windows.Forms.TextBox gameplayEditText;
        private System.Windows.Forms.Button geditButton;
        private System.Windows.Forms.Panel cutscenePanel;
        private System.Windows.Forms.Panel gameplayPanel;
        private System.Windows.Forms.SaveFileDialog saveOLM;
    }
}