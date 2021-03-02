using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace yh9uoip
{
    public partial class Editor : Form
    {
        public int OriginOLMLinesSize;
        public string OriginOLMFileLoc;
        public string OriginalOLMLoaded;
        public string OriginCurrentEnc;
        public bool IsJapanFix;

        public Editor()
        {
            InitializeComponent();

            // Get all the info we need
            editBox.Clear();
            editBox.Text = MainWindow.openOLMTempString;
            IsJapanFix = MainWindow.fixJapanBool;
            OriginOLMLinesSize = editBox.Lines.Length;
            OriginOLMFileLoc = MainWindow.openOLMFileLoc;
            OriginalOLMLoaded = MainWindow.openOLMTempString;
            this.Text = MainWindow.openOLMFileName + " - PTR2SDE Editor";
        }

        private void saveAs(object sender, EventArgs e)
        {
            if (saveOLM.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveOLM.FileName, conv(), MainWindow.currentEncoding);
                MessageBox.Show("OLM Saved successfully");
            }
        }

        private void save(object sender, EventArgs e)
        {
            File.WriteAllText(OriginOLMFileLoc, conv(), MainWindow.currentEncoding);
            MessageBox.Show("OLM Saved successfully");
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
                    File.WriteAllText(saveRawLines.FileName, editBox.Text, MainWindow.currentEncoding);
                }
            } else
            {
                if (loadRawLines.ShowDialog() == DialogResult.OK)
                {
                    editBox.Text = File.ReadAllText(loadRawLines.FileName, MainWindow.currentEncoding);
                }
            }
        }

        private string conv()
        {
            if (IsJapanFix)
            {
                return bakeFinalFile();
            }
            else
            {
                byte[] bytestring = Encoding.UTF8.GetBytes(bakeFinalFile());
                byte[] convtmp = Encoding.Convert(Encoding.UTF8, MainWindow.currentEncoding, bytestring);
                return Encoding.Default.GetString(convtmp);
            }
        }

        private string bakeFinalFile()
        {
            checkNewOLMIntegrity();
            
            string file = editBox.Text;

            string[] Original = OriginalOLMLoaded.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            string[] Modded = file.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            string FinalFile = File.ReadAllText(OriginOLMFileLoc, MainWindow.currentEncoding);

            foreach (string item in Modded)
            {
                if (item.Length != 0) { FinalFile = FinalFile.ReplaceFirst(Original[Modded.IndexOf(item)], Modded[Modded.IndexOf(item)]); }
            }

            return FinalFile;
        }

        private void checkNewOLMIntegrity()
        {
            if (OriginOLMLinesSize != editBox.Lines.Length)
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
