
namespace yh9uoip
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.logoText = new System.Windows.Forms.Label();
            this.logoTextVer = new System.Windows.Forms.Label();
            this.editBut = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.selFileBut = new System.Windows.Forms.Button();
            this.helpGroup = new System.Windows.Forms.GroupBox();
            this.vortexDiscord = new System.Windows.Forms.Label();
            this.dhtsinhoDiscord = new System.Windows.Forms.Label();
            this.ptr2modServerLink = new System.Windows.Forms.LinkLabel();
            this.helpText = new System.Windows.Forms.Label();
            this.openOlmDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.helpGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPic
            // 
            this.logoPic.BackgroundImage = global::yh9uoip.Properties.Resources.MainLogo;
            this.logoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPic.Location = new System.Drawing.Point(0, 0);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(263, 259);
            this.logoPic.TabIndex = 0;
            this.logoPic.TabStop = false;
            // 
            // logoText
            // 
            this.logoText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoText.AutoSize = true;
            this.logoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoText.Location = new System.Drawing.Point(332, 9);
            this.logoText.Name = "logoText";
            this.logoText.Size = new System.Drawing.Size(306, 16);
            this.logoText.TabIndex = 1;
            this.logoText.Text = "PaRappa The Rapper 2 Sub Decrypter and Editor";
            this.logoText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // logoTextVer
            // 
            this.logoTextVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoTextVer.ForeColor = System.Drawing.Color.Gray;
            this.logoTextVer.Location = new System.Drawing.Point(335, 25);
            this.logoTextVer.Name = "logoTextVer";
            this.logoTextVer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoTextVer.Size = new System.Drawing.Size(303, 19);
            this.logoTextVer.TabIndex = 2;
            this.logoTextVer.Text = "V2";
            this.logoTextVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // editBut
            // 
            this.editBut.Location = new System.Drawing.Point(285, 224);
            this.editBut.Name = "editBut";
            this.editBut.Size = new System.Drawing.Size(340, 23);
            this.editBut.TabIndex = 3;
            this.editBut.Text = "Decrypt and edit";
            this.editBut.UseVisualStyleBackColor = true;
            this.editBut.Click += new System.EventHandler(this.editBut_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(285, 198);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.ReadOnly = true;
            this.fileTextBox.Size = new System.Drawing.Size(309, 20);
            this.fileTextBox.TabIndex = 4;
            // 
            // selFileBut
            // 
            this.selFileBut.Location = new System.Drawing.Point(600, 198);
            this.selFileBut.Name = "selFileBut";
            this.selFileBut.Size = new System.Drawing.Size(25, 20);
            this.selFileBut.TabIndex = 5;
            this.selFileBut.Text = "...";
            this.selFileBut.UseVisualStyleBackColor = true;
            this.selFileBut.Click += new System.EventHandler(this.selFileBut_Click);
            // 
            // helpGroup
            // 
            this.helpGroup.Controls.Add(this.vortexDiscord);
            this.helpGroup.Controls.Add(this.dhtsinhoDiscord);
            this.helpGroup.Controls.Add(this.ptr2modServerLink);
            this.helpGroup.Controls.Add(this.helpText);
            this.helpGroup.Location = new System.Drawing.Point(285, 59);
            this.helpGroup.Name = "helpGroup";
            this.helpGroup.Size = new System.Drawing.Size(340, 133);
            this.helpGroup.TabIndex = 6;
            this.helpGroup.TabStop = false;
            this.helpGroup.Text = "Help";
            // 
            // vortexDiscord
            // 
            this.vortexDiscord.AutoSize = true;
            this.vortexDiscord.Location = new System.Drawing.Point(6, 98);
            this.vortexDiscord.Name = "vortexDiscord";
            this.vortexDiscord.Size = new System.Drawing.Size(80, 13);
            this.vortexDiscord.TabIndex = 8;
            this.vortexDiscord.Text = "Vortex64#2891";
            // 
            // dhtsinhoDiscord
            // 
            this.dhtsinhoDiscord.AutoSize = true;
            this.dhtsinhoDiscord.Location = new System.Drawing.Point(6, 81);
            this.dhtsinhoDiscord.Name = "dhtsinhoDiscord";
            this.dhtsinhoDiscord.Size = new System.Drawing.Size(98, 13);
            this.dhtsinhoDiscord.TabIndex = 7;
            this.dhtsinhoDiscord.Text = "DHTSinho C#5891";
            // 
            // ptr2modServerLink
            // 
            this.ptr2modServerLink.AutoSize = true;
            this.ptr2modServerLink.Location = new System.Drawing.Point(6, 63);
            this.ptr2modServerLink.Name = "ptr2modServerLink";
            this.ptr2modServerLink.Size = new System.Drawing.Size(152, 13);
            this.ptr2modServerLink.TabIndex = 7;
            this.ptr2modServerLink.TabStop = true;
            this.ptr2modServerLink.Text = "PTR2 Modding Community link";
            this.ptr2modServerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ptr2modServerLink_LinkClicked);
            // 
            // helpText
            // 
            this.helpText.AutoSize = true;
            this.helpText.Location = new System.Drawing.Point(6, 16);
            this.helpText.Name = "helpText";
            this.helpText.Size = new System.Drawing.Size(320, 39);
            this.helpText.TabIndex = 7;
            this.helpText.Text = "If you need any help you can go to the modding server, we have a\r\nlot of great to" +
    "ols in there and a lot of people interessted in helping\r\nyou or reach the develo" +
    "pers of this tool directly.";
            // 
            // openOlmDialog
            // 
            this.openOlmDialog.Filter = "OLM File|*.olm|All Files|*.*";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 259);
            this.Controls.Add(this.helpGroup);
            this.Controls.Add(this.selFileBut);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.editBut);
            this.Controls.Add(this.logoTextVer);
            this.Controls.Add(this.logoText);
            this.Controls.Add(this.logoPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(666, 298);
            this.MinimumSize = new System.Drawing.Size(666, 298);
            this.Name = "MainWindow";
            this.Text = "PTR2SDE";
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.helpGroup.ResumeLayout(false);
            this.helpGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.Label logoText;
        private System.Windows.Forms.Label logoTextVer;
        private System.Windows.Forms.Button editBut;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button selFileBut;
        private System.Windows.Forms.GroupBox helpGroup;
        private System.Windows.Forms.Label vortexDiscord;
        private System.Windows.Forms.Label dhtsinhoDiscord;
        private System.Windows.Forms.LinkLabel ptr2modServerLink;
        private System.Windows.Forms.Label helpText;
        private System.Windows.Forms.OpenFileDialog openOlmDialog;
    }
}