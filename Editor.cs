using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yh9uoip
{
    public partial class Editor : Form
    {
        public static string loadedFileS;
        public static byte[] loadedFileB;

        public int loadedDataPosition;
        public static string loadedFileLoc;

        private DecryptUtil decryptUtil = new DecryptUtil();

        public Editor()
        {
            InitializeComponent();

            /* Get info from the MainWindow */

            loadedFileS = MainWindow.tmpOpenFileS;
            loadedFileB = MainWindow.tmpOpenFileB;
            loadedFileLoc = MainWindow.tmpFileLoc;
            loadedDataPosition = MainWindow.tmpDataPos;
            this.Text = MainWindow.tmpFileName + " - PTR2SDE";

            /* Load the file */
            decryptUtil.startLoad();

            /* GUI */
            GenerateGui();
            Console.WriteLine("Populated GUI");
            DebugShowLoadedSubtitles();
            Console.WriteLine("Generated Debug tab");

            SizeLastColumns();
        }

        /* GUI */

        private void GenerateGui()
        {
            string useless = "~";

            /* Cutscene */
            int a = 0;
            int lastTmgId = -1;
            foreach (Subtitle curSub in decryptUtil.subtitleList)
            {
                a++;
                if (!curSub.IsHidden)
                {
                    ListViewItem tmpItem = cutsceneView.Items.Add(a.ToString());
                    tmpItem.SubItems.Add(curSub.SubtitleId.ToString());

                    /* Start/End subtitle, lets make prettier */
                    if (curSub.TimingId != lastTmgId)
                    {
                        lastTmgId = curSub.TimingId;
                        tmpItem.SubItems.Add(decryptUtil.timingList[curSub.TimingId].TimingAppear.ToString());
                        tmpItem.SubItems.Add(decryptUtil.timingList[curSub.TimingId].TimingDisappear.ToString());
                    }
                    else
                    {
                        tmpItem.SubItems.Add(useless).BackColor = Color.Gray;
                        tmpItem.SubItems.Add(useless).BackColor = Color.Gray;
                    }
                    tmpItem.SubItems.Add(curSub.SubtitleText);
                }
            }

            /* In-gameplay */
            int b = 0;
            foreach (GSubtitle curSub in decryptUtil.gameplaySubtitleList)
            {
                b++;
                if (!curSub.IsHidden)
                {
                    ListViewItem tmpItem = gameplayView.Items.Add(b.ToString());
                    tmpItem.SubItems.Add(curSub.SubtitleText);
                }
            }
        }

        /* GUI Debug Gen */

        private void DebugShowLoadedSubtitles()
        {
            var debugText = new StringBuilder();

            /* Cutscene */
            for (int id = 0; id < decryptUtil.datalistAmmount; id++)
            {
                debugText.Append(Environment.NewLine + "# CUTSCENE " + id + " #" + Environment.NewLine);

                foreach (Subtitle curSubtitle in decryptUtil.subtitleList)
                {
                    if (curSubtitle.SubtitleId == id)
                    {
                        debugText.Append(Environment.NewLine + Environment.NewLine + "[SUBTITLE]"
                                        + Environment.NewLine + "Text: " + curSubtitle.SubtitleText
                                        + Environment.NewLine + "HEX Position: " + curSubtitle.DataPosition
                                        + Environment.NewLine + "Is second data: " + curSubtitle.IsSecondData.ToString()
                                        + Environment.NewLine + "Timing ID: " + curSubtitle.TimingId
                                        + Environment.NewLine + "Time Start: " + Convert.ToInt32(decryptUtil.timingList[curSubtitle.TimingId].TimingAppear)
                                        + Environment.NewLine + "Time End: " + Convert.ToInt32(decryptUtil.timingList[curSubtitle.TimingId].TimingDisappear));
                    }
                }
            }

            /* In-gameplay */
            debugText.Append(Environment.NewLine + Environment.NewLine + "# IN-GAMEPLAY #" + Environment.NewLine);
            foreach (GSubtitle curSubtitle in decryptUtil.gameplaySubtitleList)
            {
                debugText.Append(Environment.NewLine + Environment.NewLine + "[SUBTITLE]"
                                + Environment.NewLine + "Text: " + curSubtitle.SubtitleText
                                + Environment.NewLine + "HEX Position: " + curSubtitle.DataPosition
                                + Environment.NewLine + "STR Position: " + curSubtitle.SubtitlePosition);
            }

            debuggingText.Text = debugText.ToString();
        }

        /* "Notepad" bar */

        private void ToBeMade(object sender, EventArgs e)
        {
            MessageBox.Show("This function is still being made, if you aren't sure if this is supposed to happen contact the developers", "PTR2SDE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PTR2SDE - Made by Vortex64 & DHTSinho" + "\n" + "Version : " + MainWindow.toolVersion);
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* ListView Select */

        private int cCurItem = -1;

        private void cutsceneView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem tmp = cutsceneView.GetItemAt(e.X, e.Y);
            if (cutsceneView.SelectedItems.Count != 0)
            {
                cCurItem = Int32.Parse(tmp.SubItems[0].Text);
                ctimingStartText.Text = tmp.SubItems[2].Text;
                ctimingEndText.Text = tmp.SubItems[3].Text;
                cutsceneEditText.Text = tmp.SubItems[4].Text;
            }
        }

        private int gCurItem = -1;

        private void gameplayView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem tmp = gameplayView.GetItemAt(e.X, e.Y);
            if (gameplayView.SelectedItems.Count != 0)
            {
                gCurItem = Int32.Parse(tmp.SubItems[0].Text);
                gameplayEditText.Text = tmp.SubItems[1].Text;
            }
        }

        /* Edit */

        private void editBut_Click(object sender, EventArgs e)
        {
            if (cCurItem == -1) return;

            Subtitle curSub = decryptUtil.subtitleList[cCurItem - 1];
            int tmpDiff = cutsceneEditText.Text.Length - cutsceneView.FindItemWithText(cCurItem.ToString()).SubItems[4].Text.Length;
            int tmpPos = curSub.SubtitlePosition;

            decryptUtil.fixList.Add(new ModPoint(tmpPos, tmpDiff, cCurItem - 1, false));
            decryptUtil.FixStrings(tmpPos, tmpDiff);

            Console.WriteLine("Correction added. Subtitle position: " + tmpPos + ", diff: " + tmpDiff);

            ListViewItem tmp = cutsceneView.FindItemWithText(cCurItem.ToString());
            tmp.SubItems[2].Text = ctimingStartText.Text;
            tmp.SubItems[3].Text = ctimingEndText.Text;
            tmp.SubItems[4].Text = cutsceneEditText.Text;

            decryptUtil.timingList[curSub.TimingId].TimingAppear = Convert.ToInt32(ctimingStartText.Text);
            decryptUtil.timingList[curSub.TimingId].TimingDisappear = Convert.ToInt32(ctimingEndText.Text);
            curSub.SubtitleText = cutsceneEditText.Text;
        }

        private void geditButton_Click(object sender, EventArgs e)
        {
            if (gCurItem == -1) return;

            GSubtitle curSub = decryptUtil.gameplaySubtitleList[gCurItem - 1];
            int tmpDiff = gameplayEditText.Text.Length - gameplayView.FindItemWithText(gCurItem.ToString()).SubItems[1].Text.Length;
            int tmpPos = curSub.SubtitlePosition;

            decryptUtil.fixList.Add(new ModPoint(tmpPos, tmpDiff, gCurItem - 1, true));
            decryptUtil.FixStrings(tmpPos, tmpDiff);

            ListViewItem tmp = gameplayView.FindItemWithText(gCurItem.ToString());
            tmp.SubItems[1].Text = gameplayEditText.Text;

            decryptUtil.gameplaySubtitleList[gCurItem - 1].SubtitleText = gameplayEditText.Text;
        }

        /* Save */

        private void save_Click(object sender, EventArgs e)
        {
            decryptUtil.SaveFile(loadedFileLoc);
            MessageBox.Show("File saved successfully.", "PTR2SDE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            if (saveOLM.ShowDialog() == DialogResult.OK)
            {
                decryptUtil.SaveFile(saveOLM.FileName);
                MessageBox.Show("File saved successfully.", "PTR2SDE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /* Tools/Fixes */

        private void cutsceneView_Resize(object sender, EventArgs e)
        {
            SizeLastColumns();
        }

        private void gameplayView_Resize(object sender, EventArgs e)
        {
            SizeLastColumns();
        }

        private void SizeLastColumns()
        {
            cutsceneView.Columns[cutsceneView.Columns.Count - 1].Width = -2;
            gameplayView.Columns[gameplayView.Columns.Count - 1].Width = -2;
        }

        /* Tools (Program) */
    }
}