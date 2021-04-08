using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace yh9uoip
{
    public partial class MainWindow : Form
    {
        public static string toolVersion = "V2 WIP";
        public static string parappaDiscord = "https://discord.gg/XdtsVc9xAK";

        public static bool debugMode = false;

        /* Temporary - For Editor use */
        public static string tmpOpenFileS;
        public static byte[] tmpOpenFileB;

        public static string tmpHeader;

        public static string tmpDataPart;
        public static string tmpStringPart;

        public static int tmpDataPos;

        public static string tmpFileLoc;
        public static string tmpFileName;

        public static Encoding jpEnc = Encoding.GetEncoding(20932);

        private DecryptUtil decryptUtil = new DecryptUtil();

        public MainWindow()
        {
            InitializeComponent();

            logoTextVer.Text = toolVersion;
        }

        /* GUI */

        private void editBut_Click(object sender, EventArgs e)
        {
            if (fileTextBox.TextLength < 1) { MessageBox.Show("Please select a valid OLM file.", "PTR2SDE", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            Editor editor = new Editor();
            editor.Show();
        }

        private void selFileBut_Click(object sender, EventArgs e)
        {
            if (openOlmDialog.ShowDialog() == DialogResult.OK)
            {
                tmpFileLoc = openOlmDialog.FileName;
                tmpFileName = openOlmDialog.SafeFileName;

                try
                {
                    tmpOpenFileS = File.ReadAllText(tmpFileLoc, Encoding.Default);
                    tmpOpenFileB = File.ReadAllBytes(tmpFileLoc);
                }
                catch (Exception exc) { MessageBox.Show("There was an error trying to open " + tmpFileName + ". " + exc.Message, "PTR2SDE", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                if (decryptUtil.CheckValidOLM(ref tmpOpenFileS))
                {
                    fileTextBox.Text = tmpFileLoc;
                }
                else MessageBox.Show("This file isn't a valid OLM file.", "PTR2SDE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ptr2modServerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(parappaDiscord);
        }
    }
}