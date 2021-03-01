using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yh9uoip
{
    public partial class MainWindow : Form
    {
        // Info about our program
        public static string versionName = "Testing build, 28/02/2021";

        // Things that will be used in the Editor be here
        public static string openOLMTempString;
        public static string openOLMFileLoc;
        public static string openOLMFileName;

        // Characters removed in the process
        public static string[] checkVolatileData = { "\x1", "\x2", "\x3", "\x4", "\x5", "\x6", "\x7", "\x8", "\x9", "\xA", "\xB", "\xC", "\xD", "\xE", "\xF" };
        public static string[] japaneseGarbageCommonStrings = { "¦", "©", "¤", "¥" };
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

            try { subfile = File.ReadAllText(fileLoc, System.Text.Encoding.Default); } catch(Exception e) // if the user inserts wrong files
            {
                MessageBox.Show("There was an error at opening the OLM file.");
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
                bool unwanted;
                bool japaneseGarbage = japaneseGarbageCommonStrings.Any(tmpTestString.Contains);

                if (removeDataGarbage.Checked) { unwanted = !checkVolatileData.Any(tmpTestString.Contains) && !japaneseGarbage; } else { unwanted = !checkVolatileData.Any(tmpTestString.Contains); }
                if (unwanted)
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

            openOLMFileLoc = fileLoc;
        }

        // For historical reasons, lets save a copy of the original code :D
        private void runOriginalSubDecoder()
        {
            string directory = fileLocText.Text;
            string text = File.ReadAllText(directory);
            File.WriteAllText("temp.olm", text);
            string decode = File.ReadAllText("temp.olm");
            string output = decode.Substring(158161);
            File.WriteAllText("output.olm", output);
        }

        // Interface functions

        private void SpecificPartTextboss_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
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

        private void unloadSubIdCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
  
       
    