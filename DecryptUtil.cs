﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yh9uoip
{
    internal class DecryptUtil
    {
        public List<Subtitle> subtitleList = new List<Subtitle>();
        public List<GSubtitle> gameplaySubtitleList = new List<GSubtitle>();
        public List<Timing> timingList = new List<Timing>();
        public List<SearchPoint> datalList = new List<SearchPoint>();
        public List<ModPoint> fixList = new List<ModPoint>();

        public string loadedFileS;
        public byte[] loadedFileB;

        public string loadedFileLoc;

        public int subtitlesDataStart;
        public int datalistAmmount;
        private bool dataEnded;
        private int tmpLastTimeData;

        public string[] japaneseIndentifier = { "¤", "¦", "¥", "·", "÷", "©", "Æ" };
        public static string checkHead1 = "\x00\x00\xBA\x42\x00\x00\x00\x00";
        public static string checkHead2 = "\x00\x00\xC8\x42\x00\x00\x00\x00";
        private readonly string gmHead = "\xFF\xFF\xFF\xFF\xFF\xFF\xFF\xFF";
        public static string battleModeHead1 = "\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00";
        public static string battleModeHead2 = "\x42";
        public static string stageBonusHead = "\x00\x00\x00\x00\x33\x33\xD9\x42";
        public static string dataEndHeader = "\x00\x01\x00\x01\x00\x00\x00\x00";
        public static string dataEndHeader2 = "\x00\x19\x19\x00\x00\x00\x00\x00";
        public static string gdataStartHeader = "\x00\x00\x00\x00\x01\x00\x00\x00\x00\x00\x00\x00\xFF\xFF\xFF\xFF";
        public static string gdataEndHeader = "\xFF\xFF\xFF\xFF\xFF\xFF\xFF\xFF";
        Stopwatch testtime2 = new Stopwatch();

        /* Main */

        public void startLoad()
        {
            testtime2.Restart();
            testtime2.Stop();

            /* Pull initial data from Editor */
            loadedFileS = Editor.loadedFileS;
            loadedFileB = Editor.loadedFileB;
            loadedFileLoc = Editor.loadedFileLoc;
            subtitlesDataStart = loadedFileS.LastIndexOf("\x01");

            /* Find & Load */
            Stopwatch timing = new Stopwatch();
            Console.WriteLine("\n# Loading Start #\n");
            timing.Restart();
            GetCutscenesDataLists();
            Console.WriteLine("Took " + timing.Elapsed + " to find Cutscenes Data Points");
            timing.Restart();
            LoadSubtitlesFromFile();
            Console.WriteLine("Took " + timing.Elapsed + " to load file");
            timing.Stop();
        }

        public bool CheckValidOLM(ref string file)
        {
            return file.Contains(checkHead1) || file.Contains(checkHead2) || file.Contains(gdataStartHeader);
        }

        /* Decrypting Utils */

        private void GetCutscenesDataLists()
        {
            string headerB = "\x42\x00\x00\x00\x00";
            string headerA = "\x00\x00";

            string tmpString;
            List<string> tmpAr = new List<string>();
            int tmpPos;

            /* General ??42000000 subtitles */
            List<int> headerOcurrances = loadedFileS.Substring(0, subtitlesDataStart).AllIndexesOf(headerB);
            headerOcurrances.Reverse();
            foreach (int tmpPosHeader in headerOcurrances)
            {
                tmpPos = tmpPosHeader - headerA.Length - 1;

                if (loadedFileS.Substring(tmpPos, headerA.Length) == headerA)
                {
                    tmpString = loadedFileS.Substring(tmpPos, headerA.Length + headerB.Length + 1);

                    if (CheckRealCutsceneDataList(tmpAr, tmpString, tmpPos))
                    {
                        tmpAr.Add(tmpString);

                        Console.WriteLine("Found Cutscene subtitles. Start Index : " + tmpPos);
                        datalList.Add(new SearchPoint(tmpString, dataEndHeader, 2));
                    }
                }
            }

            /* Battle Mode subtitles */
            List<int> aheaderOcurrances = loadedFileS.Substring(0, subtitlesDataStart).AllIndexesOf(battleModeHead2);
            aheaderOcurrances.Reverse();
            foreach (int tmpPosHeaderB in aheaderOcurrances)
            {
                tmpPos = tmpPosHeaderB - battleModeHead1.Length - 1;

                if (loadedFileS.Substring(tmpPos, battleModeHead1.Length) == battleModeHead1)
                {
                    tmpString = loadedFileS.Substring(tmpPos, battleModeHead1.Length + battleModeHead2.Length + 1);
                    Console.WriteLine("Found Battle Mode subtitles. Start Index : " + tmpPos);
                    datalList.Add(new SearchPoint(tmpString, dataEndHeader2, 2));
                    break;
                }
            }

            /* STGBN specific subtitles */
            if (loadedFileS.Contains(stageBonusHead))
            {
                datalList.Add(new SearchPoint(stageBonusHead, dataEndHeader, 2));
            }

            Console.WriteLine("There are " + datalList.Count + " search points.");
        }

        private bool CheckRealCutsceneDataList(List<string> tmpL, string tmpS, int tmpP)
        {
            bool cond = loadedFileS[tmpP + 7 + 24] == '\x00' &&
                        loadedFileS[tmpP + 7 + 32] == '\x01';

            if (tmpL.Any(tmpS.Contains)) return false;
            if (cond) return true;
            return false;
        }

        private void LoadSubtitlesFromFile()
        {
            Stopwatch timing = new Stopwatch();
            timing.Restart();

            /* Load Cutscenes subtitles */

            datalistAmmount = 0;
            foreach (SearchPoint dataArea in datalList)
            {
                int curPos = loadedFileS.LastIndexOf(dataArea.Header) + dataArea.Header.Length;

                curPos += (dataArea.SkipAmmount * 8); /* Skip range */

                dataEnded = false;

                while (dataEnded is false)
                {
                    if (curPos > subtitlesDataStart) dataEnded = true; // REMOVE IF OK : loadedFileS.LastIndexOf('\x01')

                    string currentLine;
                    currentLine = loadedFileS.Substring(curPos, 8);

                    if (currentLine.StartsWith(dataArea.EndHeader)) { dataEnded = true; Console.WriteLine("DataL " + datalistAmmount + " ended in pos " + curPos); }

                    if (currentLine.EndsWith("\x01") || currentLine.EndsWith("\x00")) { ReadCutsceneLineData(curPos, datalistAmmount); } else { dataEnded = true; }

                    curPos += 8;
                }

                /* Split lists */
                datalistAmmount++;
            }

            Console.WriteLine("Took " + timing.Elapsed + " to load Cutscenes'");
            timing.Restart();

            /* Load In-gameplay subtitles */

            int curGPPos = loadedFileS.IndexOf(gdataStartHeader) + gdataStartHeader.Length;
            int curGEndPos = loadedFileS.Substring(curGPPos).LastIndexOf(gdataEndHeader) + 20;
            List<int> gdataPosIndexes = loadedFileS.AllIndexesOf(gmHead);

            /* Remove wrong indexes */
            gdataPosIndexes.RemoveAll(s => s > curGEndPos || s < curGPPos);

            int tmpRealPos;
            int tmpStringPos;
            string tmpCutSubPosString;
            string tmpCutString;
            bool tmpDontAdd;
            bool tmpHide;

            void readGameplayData(int subId)
            {
                tmpCutSubPosString = loadedFileS.Substring(tmpRealPos, 3);

                byte ch0 = loadedFileB[tmpRealPos];
                byte ch1 = loadedFileB[tmpRealPos + 1];
                byte ch2 = loadedFileB[tmpRealPos + 2];
                tmpStringPos = ConvPosToInt(ch0, ch1, ch2);
                tmpCutString = GetTextFromInt(tmpRealPos);

                /* Checks to mitigate false positions */
                tmpDontAdd = false;
                tmpHide = false;
                if (tmpStringPos < subtitlesDataStart) tmpDontAdd = true;
                if (tmpCutSubPosString.StartsWith("\x00\x00") ||
                    tmpCutSubPosString.StartsWith("\xFF\xFF\xFF") ||
                    tmpCutString.Length < 1) tmpHide = true;

                if (!tmpDontAdd) { gameplaySubtitleList.Add(new GSubtitle(tmpCutString, tmpRealPos, tmpStringPos, subId, tmpHide)); }
            }

            foreach (int pDataPos in gdataPosIndexes)
            {
                if (loadedFileS[pDataPos + gmHead.Length + 3].ToString() == "\x01") /* 1 Line */
                {
                    tmpRealPos = pDataPos + gmHead.Length;

                    readGameplayData(0);
                }

                if (loadedFileS[pDataPos + gmHead.Length + 7].ToString() == "\x01") /* 2 Line */
                {
                    tmpRealPos = pDataPos + gmHead.Length + 4;

                    readGameplayData(1);
                }

                if (loadedFileS[pDataPos + gmHead.Length + 11].ToString() == "\x01") /* 3 Line */
                {
                    tmpRealPos = pDataPos + gmHead.Length + 8;

                    readGameplayData(2);
                }

                if (loadedFileS[pDataPos + gmHead.Length + 15].ToString() == "\x01") /* 4 Line */
                {
                    tmpRealPos = pDataPos + gmHead.Length + 12;

                    readGameplayData(3);
                }

                if (loadedFileS[pDataPos + gmHead.Length + 19].ToString() == "\x01") /* 5 Line */
                {
                    tmpRealPos = pDataPos + gmHead.Length + 16;

                    readGameplayData(4);
                }
            }

            Console.WriteLine("Took " + timing.Elapsed + " to load In-gameplays'");
        }

        private void ReadCutsceneLineData(int dataPosition, int subId)
        {
            int diff = 7;

            /* Timing Data */
            if (loadedFileS[dataPosition + diff] == '\x00')
            {
                tmpLastTimeData = timingList.Count;

                byte startPos0 = loadedFileB[dataPosition + 1];
                byte startPos1 = loadedFileB[dataPosition + 0];
                byte endPos0 = loadedFileB[dataPosition + 5];
                byte endPos1 = loadedFileB[dataPosition + 4];

                int realStartPos = startPos1 | (startPos0 << 8);
                int realEndPos = endPos1 | (endPos0 << 8);

                timingList.Add(new Timing(dataPosition, subId, realStartPos, realEndPos));
            }

            /* First Subtitle Data if any */
            if (loadedFileS[dataPosition + diff - 4] == '\x01')
            {
                string subtitleText = GetTextFromInt(dataPosition);
                int subtitlePosition = ConvPosToInt(loadedFileB[dataPosition], loadedFileB[dataPosition + 1], loadedFileB[dataPosition + 2]);

                /* Checks to hide invalid strings */
                bool isHidden = subtitleText.Length < 1 || subtitlePosition < subtitlesDataStart;

                subtitleList.Add(new Subtitle(subtitleText, dataPosition, subtitlePosition, tmpLastTimeData, subId, false, isHidden));
            }

            /* Second Subtitle Data if any */
            if (loadedFileS[dataPosition + diff] == '\x01' && loadedFileS[dataPosition + 5] != '\x00' && loadedFileS[dataPosition + 6] != '\x00')
            {
                string subtitleText = GetTextFromInt(dataPosition + 4);
                int subtitlePosition = ConvPosToInt(loadedFileB[dataPosition + 4], loadedFileB[dataPosition + 5], loadedFileB[dataPosition + 6]);

                /* Checks to hide invalid strings */
                bool isHidden = subtitleText.Length < 1 || subtitlePosition < subtitlesDataStart;

                subtitleList.Add(new Subtitle(subtitleText, dataPosition + 4, subtitlePosition, tmpLastTimeData, subId, true, isHidden));
            }
        }

        private string GetTextFromInt(int positionData)
        {
            byte ch0 = loadedFileB[positionData];
            byte ch1 = loadedFileB[positionData + 1];
            byte ch2 = loadedFileB[positionData + 2];
            int result = ConvPosToInt(ch0, ch1, ch2);

            string tmpConvertedText;
            try
            {
                if (result > loadedFileS.Length) return "";
                tmpConvertedText = loadedFileS.Substring(result);
                tmpConvertedText = tmpConvertedText.Substring(0, tmpConvertedText.IndexOf("\x00"));
                if (japaneseIndentifier.Any(tmpConvertedText.Contains))
                {
                    byte[] tmpCJP = Encoding.Default.GetBytes(tmpConvertedText);
                    tmpConvertedText = MainWindow.jpEnc.GetString(tmpCJP);
                };
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show("Error at loading line " + positionData + "\n\n" + e.ToString() + "\n\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error at loading line.";
            }

            return tmpConvertedText;
        }

        /* Conversions */

        private int ConvPosToInt(byte ch0, byte ch1, byte ch2)
        {
            string cs0 = (Convert.ToInt32(ch2) - 202).ToString("X");
            string cs1 = ch1.ToString("X");
            string cs2 = ch0.ToString("X");

            /* Add 0 if needed */
            if (6 < cs0.Length) cs0 = "0";
            if (cs1.Length == 1) { cs1 = "0" + cs1; }
            if (cs2.Length == 1) { cs2 = "0" + cs2; }

            string position = cs0 + cs1 + cs2;

            return Convert.ToInt32(position, 16);
        }

        private byte[] ConvIntToPos(int data)
        {
            byte[] result = new byte[3];
            result[0] = (byte)data;
            result[1] = (byte)(((uint)data >> 8) & 0xFF);

            /* Last Byte Fix */
            byte last = (byte)(((uint)data >> 16) & 0xFF);
            result[2] = (byte)(last + 0xCA);

            return result;
        }

        private byte[] ConvIntToTime(int data)
        {
            byte[] result = new byte[2];
            result[0] = (byte)data;
            result[1] = (byte)(((uint)data >> 8) & 0xFF);
            return result;
        }

        /* Saving */

        public void SaveFile(string saveFileLocation)
        {
            string fileToSave = loadedFileS;

            Stopwatch stiming = new Stopwatch();
            Console.WriteLine("\n# Saving Start #\n");
            stiming.Restart();

            Console.WriteLine("Modding strings and fixing positions...");
            PatchStrings(ref fileToSave);
            Console.WriteLine("Applying fixed positions to cutscenes data...");
            UpdateCutsceneData(ref fileToSave);
            Console.WriteLine("Applying fixed positions to gameplay data...");
            UpdateGameplayData(ref fileToSave);

            stiming.Stop();
            Console.WriteLine("Took " + stiming.Elapsed + " to edit the file");
            Console.WriteLine("Took " + testtime2.Elapsed + " to write fixed positions");

            Console.WriteLine("Saving modified file...");
            File.WriteAllText(saveFileLocation, fileToSave, Encoding.Default);
            fixList.Clear();
            Console.WriteLine("Done.");
        }

        private void PatchStrings(ref string tmpFile)
        {
            int tmpCount = -1;
            foreach (ModPoint tmpFix in fixList)
            {
                tmpCount++;
                Console.WriteLine("Mod index : " + tmpCount + " Diff : " + tmpFix.Difference + " Position : " + tmpFix.Position);

                if (!tmpFix.IsGameplay)
                {
                    WriteSubtitle(ref tmpFile, tmpFix.Position, subtitleList[tmpFix.SubtitleId].SubtitleText);
                }
                else
                {
                    WriteSubtitle(ref tmpFile, tmpFix.Position, gameplaySubtitleList[tmpFix.SubtitleId].SubtitleText);
                }
            }
        }

        public void FixStrings(int pos, int diff)
        {
            foreach (Subtitle tmpCSub in subtitleList)
            {
                if (pos < tmpCSub.SubtitlePosition)
                {
                    tmpCSub.SubtitlePosition += diff;
                }
            }

            foreach (GSubtitle tmpGSub in gameplaySubtitleList)
            {
                if (pos < tmpGSub.SubtitlePosition)
                {
                    tmpGSub.SubtitlePosition += diff;
                }
            }
        }

        private void WriteSubtitle(ref string tmpFile, int subPos, string tmpString)
        {
            /* Refix japanese strings */
            byte[] jpByte = MainWindow.jpEnc.GetBytes(tmpString);
            string jpString = Encoding.Default.GetString(jpByte);
            if (japaneseIndentifier.Any(jpString.Contains))
            {
                tmpString = jpString;
            }

            int nextzero = tmpFile.Substring(subPos).IndexOf("\x00");
            tmpFile = tmpFile.Remove(subPos, nextzero).Insert(subPos, tmpString);
        }

        private void UpdateCutsceneData(ref string tmpFile)
        {
            int statusPos = -1;
            int lastTimeId = -1;

            while (true)
            {
                statusPos++;

                if (statusPos > subtitleList.Count - 1) { break; }

                Subtitle tmpSub = subtitleList[statusPos];
                byte[] subBytes = ConvIntToPos(tmpSub.SubtitlePosition);
                string subPos = Encoding.Default.GetString(subBytes);
                string madeLine = "";

                Timing tmpTime = timingList[tmpSub.TimingId];

                /* Timing Data */

                if (tmpSub.TimingId != lastTimeId)
                {
                    lastTimeId = tmpSub.TimingId;

                    byte[] time1 = ConvIntToTime(tmpTime.TimingAppear);
                    byte[] time2 = ConvIntToTime(tmpTime.TimingDisappear);
                    string madeTiming = Encoding.Default.GetString(time1) + "\x00\x00" + Encoding.Default.GetString(time2) + "\x00\x00";

                    /* Patch timing into file*/
                    testtime2.Start();
                    tmpFile = tmpFile.Patch(madeTiming, tmpTime.TimingPosition);
                    testtime2.Stop();
                }

                /* Subtitle Data */

                if (statusPos + 1 < subtitleList.Count - 1 && !subtitleList[statusPos].IsSecondData && subtitleList[statusPos + 1].IsSecondData)
                {
                    Subtitle tmpSub2 = subtitleList[statusPos + 1];
                    byte[] subBytes2 = ConvIntToPos(tmpSub2.SubtitlePosition);
                    string subPos2 = Encoding.Default.GetString(subBytes2);

                    madeLine += subPos + "\x01";
                    madeLine += subPos2 + "\x01";

                    /* Patch subtitle into file */
                    testtime2.Start();
                    tmpFile = tmpFile.Patch(madeLine, tmpSub.DataPosition);
                    testtime2.Stop();
                    statusPos++;
                }
                else
                {
                    madeLine += subPos + "\x01";

                    testtime2.Start();
                    tmpFile = tmpFile.Patch(madeLine, tmpSub.DataPosition);
                    testtime2.Stop();
                }
            }
        }

        private void UpdateGameplayData(ref string tmpFile)
        {
            int statusPos = -1;

            while (true)
            {
                statusPos++;

                if (statusPos > gameplaySubtitleList.Count - 1) { break; }

                GSubtitle tmpSub = gameplaySubtitleList[statusPos];
                byte[] subBytes = ConvIntToPos(tmpSub.SubtitlePosition);
                string subPos = Encoding.Default.GetString(subBytes);
                string madeLine = subPos + "\x01";

                if (statusPos + 1 < gameplaySubtitleList.Count - 1 && gameplaySubtitleList[statusPos + 1].SubtitleId == 1)
                {
                    GSubtitle tmpSub2 = gameplaySubtitleList[statusPos + 1];
                    byte[] subBytes2 = ConvIntToPos(tmpSub2.SubtitlePosition);
                    string subPos2 = Encoding.Default.GetString(subBytes2);
                    madeLine += subPos2 + "\x01";
                    statusPos++;
                }

                if (statusPos + 2 < gameplaySubtitleList.Count - 1 && gameplaySubtitleList[statusPos + 2].SubtitleId == 2)
                {
                    GSubtitle tmpSub3 = gameplaySubtitleList[statusPos + 2];
                    byte[] subBytes3 = ConvIntToPos(tmpSub3.SubtitlePosition);
                    string subPos3 = Encoding.Default.GetString(subBytes3);
                    madeLine += subPos3 + "\x01";
                    statusPos++;
                }

                if (statusPos + 3 < gameplaySubtitleList.Count - 1 && gameplaySubtitleList[statusPos + 3].SubtitleId == 3)
                {
                    GSubtitle tmpSub4 = gameplaySubtitleList[statusPos + 3];
                    byte[] subBytes4 = ConvIntToPos(tmpSub4.SubtitlePosition);
                    string subPos4 = Encoding.Default.GetString(subBytes4);
                    madeLine += subPos4 + "\x01";
                    statusPos++;
                }

                if (statusPos + 4 < gameplaySubtitleList.Count - 1 && gameplaySubtitleList[statusPos + 4].SubtitleId == 4)
                {
                    GSubtitle tmpSub5 = gameplaySubtitleList[statusPos + 4];
                    byte[] subBytes5 = ConvIntToPos(tmpSub5.SubtitlePosition);
                    string subPos5 = Encoding.Default.GetString(subBytes5);
                    madeLine += subPos5 + "\x01";
                    statusPos++;
                }

                testtime2.Start();
                tmpFile = tmpFile.Patch(madeLine, tmpSub.DataPosition);
                testtime2.Stop();
            }
        }

        /* Tools */

        public void SplitSubtitle(int subMod, bool isGameplay)
        {

        }
    }

    /* Other Important Stuff */

    public class Subtitle
    {
        public string SubtitleText { get; set; }
        public int DataPosition { get; set; }
        public int SubtitlePosition { get; set; }
        public int TimingId { get; set; }
        public int SubtitleId { get; set; }
        public bool IsSecondData { get; set; }
        public bool IsHidden { get; set; }
        public bool IsUneditable { get; set; }

        public Subtitle(string subText, int subDataPos, int subPos, int timeDataId, int subtitleId, bool isSecondData, bool isHidden)
        {
            (SubtitleText, DataPosition, SubtitlePosition, TimingId, SubtitleId, IsSecondData, IsHidden) = (subText, subDataPos, subPos, timeDataId, subtitleId, isSecondData, isHidden);
        }
    }

    public class GSubtitle
    {
        public string SubtitleText { get; set; }
        public int DataPosition { get; set; }
        public int SubtitlePosition { get; set; }
        public int SubtitleId { get; set; }
        public bool IsHidden { get; set; }
        public bool IsUneditable { get; set; }

        public GSubtitle(string subText, int subDataPos, int subPos, int subtitleId, bool isHidden)
        {
            (SubtitleText, DataPosition, SubtitlePosition, SubtitleId, IsHidden) = (subText, subDataPos, subPos, subtitleId, isHidden);
        }
    }

    public class Timing
    {
        public int TimingPosition { get; set; }
        public int SubtitleId { get; set; }
        public int TimingAppear { get; set; }
        public int TimingDisappear { get; set; }

        public Timing(int timingPos, int subtitleId, int timingStart, int timingEnd)
        {
            (TimingPosition, SubtitleId, TimingAppear, TimingDisappear) = (timingPos, subtitleId, timingStart, timingEnd);
        }
    }

    public class SearchPoint
    {
        public string Header { get; set; }
        public string EndHeader { get; set; }
        public int SkipAmmount { get; set; }

        public SearchPoint(string header, string endHeader, int skipAmnt)
        {
            (Header, EndHeader, SkipAmmount) = (header, endHeader, skipAmnt);
        }
    }

    public class ModPoint
    {
        public int Position { get; set; }
        public int Difference { get; set; }
        public int SubtitleId { get; set; }
        public bool IsGameplay { get; set; }

        public ModPoint(int posHex, int diff, int subtitleId, bool isGameplay)
        {
            (Position, Difference, SubtitleId, IsGameplay) = (posHex, diff, subtitleId, isGameplay);
        }
    }

    public static class TextTool
    {
        public static int CountStringOccurrences(string text, string pattern)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }

        public static List<int> AllIndexesOf(this string str, string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");
            List<int> indexes = new List<int>();
            for (int index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }

        public static string Patch(this string str, string topatch, int position)
        {
            StringBuilder abc = new StringBuilder(str);
            for (int a = 0; a < topatch.Length; a++)
            {
                abc[position + a] = topatch[a];
            }
            return abc.ToString();
        }
    }
}