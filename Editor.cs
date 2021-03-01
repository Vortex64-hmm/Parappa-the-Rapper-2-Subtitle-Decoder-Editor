using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yh9uoip
{
    public partial class Editor : Form
    {
        public int OriginOLMLinesSize;
        public string OriginOLMFileLoc;
        public string OriginalOLMLoaded; // POV: Let's not become Google Chrome, lets store again instead of decrypting 2 times.

        public Editor()
        {
            InitializeComponent();

            // Get all the info we need
            editBox.Clear();
            editBox.Text = MainWindow.openOLMTempString;
            OriginOLMLinesSize = editBox.Lines.Length;
            OriginOLMFileLoc = MainWindow.openOLMFileLoc;
            OriginalOLMLoaded = MainWindow.openOLMTempString;
            this.Text = MainWindow.openOLMFileName + " - PTR2SDE Editor";
        }

        private void saveOLMFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveOLM.ShowDialog() == DialogResult.OK)
            {
                byte[] bytestring = Encoding.UTF8.GetBytes(bakeFinalFile());
                byte[] convtmp = Encoding.Convert(Encoding.UTF8, Encoding.Default, bytestring);
                string conv = Encoding.Default.GetString(convtmp);
                File.WriteAllText(saveOLM.FileName, conv, Encoding.Default);
                MessageBox.Show("OLM Saved successfully.");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] bytestring = Encoding.UTF8.GetBytes(bakeFinalFile());
            byte[] convtmp = Encoding.Convert(Encoding.UTF8, Encoding.Default, bytestring);
            string conv = Encoding.Default.GetString(convtmp);
            File.WriteAllText(OriginOLMFileLoc, conv, Encoding.Default);
            MessageBox.Show("OLM Saved successfully.");
        }

        private void saveRawLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveLoadraw(0);
        }

        private void loadRawLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveLoadraw(1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        // Func

        private void saveLoadraw(int num)
        {
            if (num == 0) //Save
            {
                if (saveRawLines.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveRawLines.FileName, editBox.Text, System.Text.Encoding.Default);
                }
            } else
            {
                if (loadRawLines.ShowDialog() == DialogResult.OK)
                {
                    editBox.Text = File.ReadAllText(loadRawLines.FileName, System.Text.Encoding.Default);
                }
            }
        }

        private string bakeFinalFile()
        {
            checkNewOLMIntegrity();

            string[] Original = OriginalOLMLoaded.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            string[] Modded = editBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            string FinalFile = File.ReadAllText(OriginOLMFileLoc, Encoding.Default);

            foreach (string item in Modded)
            {
                if (item.Length != 0) { FinalFile = FinalFile.ReplaceFirst(Original[Modded.IndexOf(item)], Modded[Modded.IndexOf(item)]); }
            }

            return FinalFile;
        }

        private void checkNewOLMIntegrity()
        {
            if(OriginOLMLinesSize != editBox.Lines.Length)
            {
                MessageBox.Show("Sorry, at this moment isn't possible to add more or remove subtitles", "Oopsie");
            }
        }

        // Pretty/Almost Useless buttons

        private void aboutPTR2SDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MainWindow.versionName + "\n\nCreated by Vortex64 & DHTSinho", "PTR2SDE :D");
        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            editBox.Font = new Font(editBox.Font.FontFamily, editBox.Font.Size + 5);
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            editBox.Font = new Font(editBox.Font.FontFamily, editBox.Font.Size - 5);
        }

        private void worldWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(wordWrap.Checked)
            {
                wordWrap.Checked = false;
                editBox.WordWrap = false;
            } else
            {
                wordWrap.Checked = true;
                editBox.WordWrap = true;
            }
        }
    }
    static class ArrayExtensions
    {
        public static int IndexOf<T>(this T[] array, T value)
        {
            return Array.IndexOf(array, value);
        }
    }

    public static class StringExtensionMethods
    {
        public static string ReplaceFirst(this string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
    }
}
