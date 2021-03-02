
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
            this.label1 = new System.Windows.Forms.Label();
            this.fileLocText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoadWholeFilePart = new System.Windows.Forms.RadioButton();
            this.partNumb = new System.Windows.Forms.TextBox();
            this.LoadOnlySpecificPart = new System.Windows.Forms.RadioButton();
            this.LoadSubsPartOnly = new System.Windows.Forms.RadioButton();
            this.unloadSubIdCheckbox = new System.Windows.Forms.CheckBox();
            this.butEdit = new System.Windows.Forms.Button();
            this.selectFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openOLMFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fixJapaneseChars = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PTR2 Subtitle Decoder and Editor";
            // 
            // fileLocText
            // 
            this.fileLocText.BackColor = System.Drawing.SystemColors.Window;
            this.fileLocText.Location = new System.Drawing.Point(9, 33);
            this.fileLocText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileLocText.Name = "fileLocText";
            this.fileLocText.ReadOnly = true;
            this.fileLocText.Size = new System.Drawing.Size(253, 20);
            this.fileLocText.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.fixJapaneseChars);
            this.groupBox1.Controls.Add(this.LoadWholeFilePart);
            this.groupBox1.Controls.Add(this.partNumb);
            this.groupBox1.Controls.Add(this.LoadOnlySpecificPart);
            this.groupBox1.Controls.Add(this.LoadSubsPartOnly);
            this.groupBox1.Controls.Add(this.unloadSubIdCheckbox);
            this.groupBox1.Controls.Add(this.butEdit);
            this.groupBox1.Controls.Add(this.selectFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fileLocText);
            this.groupBox1.Location = new System.Drawing.Point(340, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 209);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PTR2 Subtitle Decoder and Editor";
            // 
            // LoadWholeFilePart
            // 
            this.LoadWholeFilePart.AutoSize = true;
            this.LoadWholeFilePart.Location = new System.Drawing.Point(9, 154);
            this.LoadWholeFilePart.Name = "LoadWholeFilePart";
            this.LoadWholeFilePart.Size = new System.Drawing.Size(96, 17);
            this.LoadWholeFilePart.TabIndex = 5;
            this.LoadWholeFilePart.Text = "Load whole file";
            this.LoadWholeFilePart.UseVisualStyleBackColor = true;
            // 
            // partNumb
            // 
            this.partNumb.Enabled = false;
            this.partNumb.Location = new System.Drawing.Point(146, 131);
            this.partNumb.Name = "partNumb";
            this.partNumb.Size = new System.Drawing.Size(36, 20);
            this.partNumb.TabIndex = 8;
            this.partNumb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpecificPartTextboss_KeyPress);
            // 
            // LoadOnlySpecificPart
            // 
            this.LoadOnlySpecificPart.AutoSize = true;
            this.LoadOnlySpecificPart.Location = new System.Drawing.Point(9, 131);
            this.LoadOnlySpecificPart.Name = "LoadOnlySpecificPart";
            this.LoadOnlySpecificPart.Size = new System.Drawing.Size(131, 17);
            this.LoadOnlySpecificPart.TabIndex = 7;
            this.LoadOnlySpecificPart.Text = "Load specific part only";
            this.LoadOnlySpecificPart.UseVisualStyleBackColor = true;
            this.LoadOnlySpecificPart.CheckedChanged += new System.EventHandler(this.loadOnlySpecificPart_CheckedChanged);
            // 
            // LoadSubsPartOnly
            // 
            this.LoadSubsPartOnly.AutoSize = true;
            this.LoadSubsPartOnly.Checked = true;
            this.LoadSubsPartOnly.Location = new System.Drawing.Point(9, 108);
            this.LoadSubsPartOnly.Name = "LoadSubsPartOnly";
            this.LoadSubsPartOnly.Size = new System.Drawing.Size(151, 17);
            this.LoadSubsPartOnly.TabIndex = 6;
            this.LoadSubsPartOnly.TabStop = true;
            this.LoadSubsPartOnly.Text = "Load only the subtitles part";
            this.LoadSubsPartOnly.UseVisualStyleBackColor = true;
            // 
            // unloadSubIdCheckbox
            // 
            this.unloadSubIdCheckbox.AutoSize = true;
            this.unloadSubIdCheckbox.Location = new System.Drawing.Point(9, 60);
            this.unloadSubIdCheckbox.Name = "unloadSubIdCheckbox";
            this.unloadSubIdCheckbox.Size = new System.Drawing.Size(156, 17);
            this.unloadSubIdCheckbox.TabIndex = 5;
            this.unloadSubIdCheckbox.Text = "Don\'t load subtitle ids (beta)";
            this.unloadSubIdCheckbox.UseVisualStyleBackColor = true;
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(190, 180);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(104, 23);
            this.butEdit.TabIndex = 5;
            this.butEdit.Text = "Decode and edit";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(268, 33);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(26, 20);
            this.selectFile.TabIndex = 4;
            this.selectFile.Text = "...";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a .OLM file";
            // 
            // openOLMFileDialog
            // 
            this.openOLMFileDialog.Filter = "OLM File|*.olm|All files|*.*";
            // 
            // fixJapaneseChars
            // 
            this.fixJapaneseChars.AutoSize = true;
            this.fixJapaneseChars.Location = new System.Drawing.Point(9, 83);
            this.fixJapaneseChars.Name = "fixJapaneseChars";
            this.fixJapaneseChars.Size = new System.Drawing.Size(155, 17);
            this.fixJapaneseChars.TabIndex = 9;
            this.fixJapaneseChars.Text = "Use EUC-JP (USA/JP only)";
            this.fixJapaneseChars.UseVisualStyleBackColor = true;
            this.fixJapaneseChars.CheckedChanged += new System.EventHandler(this.changeEncoding);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(652, 230);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(352, 269);
            this.Name = "MainWindow";
            this.Text = "PTR2SDE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileLocText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.OpenFileDialog openOLMFileDialog;
        private System.Windows.Forms.TextBox partNumb;
        private System.Windows.Forms.RadioButton LoadOnlySpecificPart;
        private System.Windows.Forms.RadioButton LoadSubsPartOnly;
        private System.Windows.Forms.CheckBox unloadSubIdCheckbox;
        private System.Windows.Forms.RadioButton LoadWholeFilePart;
        private System.Windows.Forms.CheckBox fixJapaneseChars;
    }
}

