using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yh9uoip
{
    public partial class MainWindow : Form
    {
        // Info about our program
        public static string versionName = "Testing public build, 2/03/2021";

        // For changing Encoding to all parts
        public static Encoding currentEncoding = Encoding.Default;

        // Things that will be used in the Editor be here
        public static string openOLMTempString;
        public static string openOLMFileLoc;
        public static string openOLMFileName;
        public static bool fixJapanBool;

        // Characters removed in the process
        public static string[] checkVolatileData = { "\x1", "\x2", "\x3", "\x4", "\x5", "\x6", "\x7", "\x8", "\x9", "\xA", "\xB", "\xC", "\xD", "\xE", "\xF" };
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            if(fileLocText.Text.Length <= 1)
            {
                MessageBox.Show("Please select a OLM file to edit");
                return;
            }
            decodeString(fileLocText.Text);

            Editor editor = new Editor();
            editor.Show();
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            if (openOLMFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileLocText.Text = openOLMFileDialog.FileName;
                openOLMFileName = openOLMFileDialog.SafeFileName;
            }
        }

        static string subfile;
        static string tmpstring;
        static List<string> outputDecodedArray = new List<string>();
        public void decodeString(string fileLoc)
        {
            // Clear openOLMTempString, Fixes bugs at loading multiple files
            openOLMTempString = "";
            tmpstring = "";
            outputDecodedArray.Clear();

            try { subfile = File.ReadAllText(fileLoc, currentEncoding); } catch(Exception e) // if the user inserts wrong files
            {
                MessageBox.Show("There was an error at opening the OLM file");
                Console.WriteLine("Error : " + e);
                return;
            }

            string[] tmpFileHeadersSplit = subfile.Split('\x1'); // Split files in Start Of Header chars

            if (LoadSubsPartOnly.Checked) { tmpstring = tmpFileHeadersSplit.Last(); }
            if (LoadOnlySpecificPart.Checked) { tmpstring = tmpFileHeadersSplit[int.Parse(partNumb.Text)]; }
            if (LoadWholeFilePart.Checked) { tmpstring = subfile; }

            // Split again in NULS and check text in between
            string[] tmpSubArray = tmpstring.Split('\x0');
            foreach(string tmpTestString in tmpSubArray)
            {
                if (!checkVolatileData.Any(tmpTestString.Contains))
                {
                    outputDecodedArray.Add(tmpTestString);
                }
            }

            foreach (string item in outputDecodedArray)
            {
                bool cond1;

                // Conditions to be one unwanted line in our output
                bool noString = item.Length < 1;
                bool subID = item.Contains("ttl_");

                if (unloadSubIdCheckbox.Checked) { cond1 = noString || subID; } else { cond1 = noString; }

                if (!cond1) openOLMTempString += $"{item}" + System.Environment.NewLine;
            }

            fixJapanBool = fixJapaneseChars.Checked;
            openOLMFileLoc = fileLoc;
        }

        // Interface functions

        private void SpecificPartTextboss_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void loadOnlySpecificPart_CheckedChanged(object sender, EventArgs e)
        {
            if(LoadOnlySpecificPart.Checked)
            {
                partNumb.Enabled = true;
            } else
            {
                partNumb.Enabled = false;
            }
        }

        // Fix Functions

        private void changeEncoding(object sender, EventArgs e)
        {
            if(fixJapaneseChars.Checked)
            {
                currentEncoding = Encoding.GetEncoding(20932);
            } else
            {
                currentEncoding = Encoding.Default;
            }
        }
    }
}