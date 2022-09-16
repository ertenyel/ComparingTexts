using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using NinjaNye.SearchExtensions.Soundex;

namespace ComparingTexts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CompareTextsButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxFirstText.Text) && !string.IsNullOrWhiteSpace(TextBoxSecondText.Text))
            {
                if (toolStripComboBoxSelectModeCompare.SelectedIndex == 0)
                {
                    if (WordsCompareMetrics.SelectedIndex == 0)
                    {
                        RealizationMethodsCosDistance(true);
                    }
                    else if (WordsCompareMetrics.SelectedIndex == 1)
                    {
                        RealizationMethodsCosDistance(false);
                    }
                    else
                    {
                        MessageBox.Show("Выберите метод сравнения для введенного языка");
                    }
                }
                else if (toolStripComboBoxSelectModeCompare.SelectedIndex == 1)
                {
                    MessageBox.Show("В будущем сделаю...");
                }
                else
                {
                    MessageBox.Show("Выберите метод сравнения");
                }
            } 
        }
        private void RealizationMethodsCosDistance(bool englishLanguage)
        {
            DataGridViewForResults.Rows.Clear();
            char[] separators = new char[] { ' ', ',', ':', ';', '-', '\"', '(', ')' };
            char[] separatorsLines = new char[] { '.', '!', '?' };
            string[] arrayFirstText = TextBoxFirstText.Text.Split(separatorsLines, StringSplitOptions.RemoveEmptyEntries);
            string[] arraySecondText = TextBoxSecondText.Text.Split(separatorsLines, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, double> CosCollection = new Dictionary<string, double>();
            List<string[]> FirstTextListArrayLines = new List<string[]>();
            List<string[]> SecondTextListArrayLines = new List<string[]>();
            for (int i = 0; i < arrayFirstText.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(arrayFirstText[i]))
                {
                    FirstTextListArrayLines.Add(arrayFirstText[i].Split(separators, StringSplitOptions.RemoveEmptyEntries));
                }
            }
            for (int i = 0; i < arraySecondText.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(arraySecondText[i]))
                {
                    SecondTextListArrayLines.Add(arraySecondText[i].Split(separators, StringSplitOptions.RemoveEmptyEntries));
                }
            }

            foreach (string[] FirstItem in FirstTextListArrayLines)
            {
                foreach (string[] SecondItem in SecondTextListArrayLines)
                {
                    if (englishLanguage)
                    {
                        CosCollection.Add(string.Join(" ", FirstItem) + " || " + string.Join(" ", SecondItem), CosDistanceComputeEnglish(FirstItem, SecondItem));
                    }
                    else
                    {
                        CosCollection.Add(string.Join(" ", FirstItem) + " || " + string.Join(" ", SecondItem), CosDistanceComputeOtherLanguage(FirstItem, SecondItem));
                    }
                }
            }
            foreach (KeyValuePair<string, double> item in CosCollection)
            {
                DataGridViewForResults.Rows.Add(item.Key, item.Value);
            }
        }
        private double CosDistanceComputeEnglish(string[] FirstItem, string[] SecondItem)
        {
            int FirstLength = 0;
            int SecondLength = 0;
            int DistanceVectors = 0;
            Dictionary<string, int> FirstLines = new Dictionary<string, int>();
            Dictionary<string, int> SecondLines = new Dictionary<string, int>();
            for (int i = 0; i < FirstItem.Length; i++)
            {
                if (!FirstLines.ContainsKey(FirstItem[i].ToUpper()))
                {
                    FirstLines.Add(SoundexProcessor.ToSoundex(FirstItem[i]).ToUpper(), 1);
                    FirstLength += 1;
                }
            }
            for (int i = 0; i < SecondItem.Length; i++)
            {
                if (!SecondLines.ContainsKey(SecondItem[i].ToUpper()))
                {
                    SecondLines.Add(SoundexProcessor.ToSoundex(SecondItem[i]).ToUpper(), 1);
                    SecondLength += 1;
                }
            }

            foreach (KeyValuePair<string, int> item in FirstLines)
            {
                if (SecondLines.ContainsKey(item.Key))
                {
                    DistanceVectors += 1;
                }
            }
            return DistanceVectors / (Math.Sqrt(FirstLength) * Math.Sqrt(SecondLength));
        }
        private double CosDistanceComputeOtherLanguage(string[] FirstItem, string[] SecondItem)
        {
            int FirstLength = 0;
            int SecondLength = 0;
            int DistanceVectors = 0;
            Dictionary<string, int> FirstLines = new Dictionary<string, int>();
            Dictionary<string, int> SecondLines = new Dictionary<string, int>();
            for (int i = 0; i < FirstItem.Length; i++)
            {
                if (!FirstLines.ContainsKey(FirstItem[i].ToUpper()))
                {
                    if (FirstLines.Count == 0)
                    {
                        FirstLines.Add(FirstItem[i].ToUpper(), 1);
                        FirstLength += 1;
                    }
                    else
                    {
                        int ii = 0;
                        foreach (var item in FirstLines)
                        {
                            ii++;
                            int distance = LevenshteinDistance(item.Key, FirstItem[i].ToUpper());
                            if (((FirstItem[i].Length > 0 && FirstItem[i].Length < 3) || (item.Key.Length > 0 && item.Key.Length < 3)) && distance == 0)
                            {
                                break;
                            }
                            if ((FirstItem[i].Length > 2 || item.Key.Length > 2) && distance < 3)
                            {
                                break;
                            }
                            else if(ii == FirstLines.Count)
                            {
                                FirstLines.Add(FirstItem[i].ToUpper(), 1);
                                FirstLength += 1;
                                break;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < SecondItem.Length; i++)
            {
                if (!SecondLines.ContainsKey(SecondItem[i].ToUpper()))
                {
                    if (SecondLines.Count == 0)
                    {
                        SecondLines.Add(SecondItem[i].ToUpper(), 1);
                        SecondLength += 1;
                    }
                    else
                    {
                        int ii = 0;
                        foreach (var item in SecondLines)
                        {
                            ii++;
                            int distance = LevenshteinDistance(item.Key, SecondItem[i].ToUpper());
                            if (((SecondItem[i].Length > 0 && SecondItem[i].Length < 3) || (item.Key.Length > 0 && item.Key.Length < 3)) && distance == 0)
                            {
                                break;
                            }
                            if ((SecondItem[i].Length > 2 || item.Key.Length > 2) && distance < 3)
                            {
                                break;
                            }
                            else if(ii == SecondLines.Count)
                            {
                                SecondLines.Add(SecondItem[i].ToUpper(), 1);
                                SecondLength += 1;
                                break;
                            }
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, int> firstItem in FirstLines)
            {
                int ii = 0;
                foreach (var secondItem in SecondLines)
                {
                    ii++;
                    int distance = LevenshteinDistance(firstItem.Key, secondItem.Key);
                    if (((firstItem.Key.Length > 0 && firstItem.Key.Length < 3) || (secondItem.Key.Length > 0 && secondItem.Key.Length < 3)) && distance == 0)
                    {
                        DistanceVectors += 1;
                        break;
                    }
                    if ((firstItem.Key.Length > 2 || secondItem.Key.Length > 2) && distance < 3)
                    {
                        DistanceVectors += 1;
                        break;
                    }
                    else if (ii == SecondLines.Count)
                    {
                        /*DistanceVectors += 1;
                        break;*/
                    }
                    /*
                    if (LevenshteinDistance(firstItem.Key, secondItem.Key) < 3)
                    {
                        DistanceVectors += 1;
                    } */
                }
            }
            return DistanceVectors / (Math.Sqrt(FirstLength) * Math.Sqrt(SecondLength));
        }
        public static int LevenshteinDistance(string string1, string string2)
        {
            if (!string.IsNullOrWhiteSpace(string1) && !string.IsNullOrWhiteSpace(string2))
            {
                int diff;
                int[,] m = new int[string1.Length + 1, string2.Length + 1];

                for (int i = 0; i <= string1.Length; i++) { m[i, 0] = i; }
                for (int j = 0; j <= string2.Length; j++) { m[0, j] = j; }

                for (int i = 1; i <= string1.Length; i++)
                {
                    for (int j = 1; j <= string2.Length; j++)
                    {
                        diff = (string1[i - 1] == string2[j - 1]) ? 0 : 1;

                        m[i, j] = Math.Min(Math.Min(m[i - 1, j] + 1, m[i, j - 1] + 1), m[i - 1, j - 1] + diff);
                    }
                }
                return m[string1.Length, string2.Length];
            }
            else
            {
                return 0;
            }
        }

        private void CleartextBoxesButton_Click(object sender, EventArgs e)
        {
            TextBoxFirstText.Clear();
            TextBoxSecondText.Clear();
        }

        private void ButtonTestsText_Click(object sender, EventArgs e)
        {
            TextBoxFirstText.Text = File.ReadAllText("FirstTestFile.txt");
            TextBoxSecondText.Text = File.ReadAllText("SecondTestFile.txt");
        }
    }
}
