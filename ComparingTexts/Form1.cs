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
            char[] separators = new char[] { ' ', ',', ':', ';', '-', '\"', '(', ')','\n','\t' };
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
                        CosCollection.Add(string.Join(" ", FirstItem) + " <<>> " + string.Join(" ", SecondItem), CosDistanceComputeEnglish(FirstItem, SecondItem));
                    }
                    else
                    {
                        CosCollection.Add(string.Join(" ", FirstItem) + " <<>> " + string.Join(" ", SecondItem), CosDistanceComputeOtherLanguage(FirstItem, SecondItem));
                    }
                }
            }
            double maxValue = 0;
            foreach (KeyValuePair<string, double> item in CosCollection)
            {
                if (item.Value > maxValue)
                    maxValue = item.Value;

                DataGridViewForResults.Rows.Add(item.Key, item.Value);
            }
            MessageBox.Show($"Максимальное совпадение: {maxValue}\nОтсортируйте список результатов");
        }
        private double CosDistanceComputeEnglish(string[] FirstItem, string[] SecondItem)
        {
            int FirstLength = 0;
            int SecondLength = 0;
            int DistanceVectors = 0;
            Dictionary<string, int> FirstLines = new Dictionary<string, int>();
            Dictionary<string, int> SecondLines = new Dictionary<string, int>();
            FillDictionaryEnglish(ref FirstLines, FirstItem, ref FirstLength);
            FillDictionaryEnglish(ref SecondLines, SecondItem, ref SecondLength);
            foreach (KeyValuePair<string, int> item in FirstLines)
            {
                if (SecondLines.ContainsKey(item.Key))
                {
                    DistanceVectors += 1;
                }
            }
            return DistanceVectors / (Math.Sqrt(FirstLength) * Math.Sqrt(SecondLength));
        }
        private void FillDictionaryEnglish(ref Dictionary<string, int> dictionary, string[] inputArray, ref int Length)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (!dictionary.ContainsKey(SoundexProcessor.ToSoundex(inputArray[i])))
                {
                    dictionary.Add(SoundexProcessor.ToSoundex(inputArray[i]).ToUpper(), 1);
                    Length += 1;
                }
            }
        }
        private double CosDistanceComputeOtherLanguage(string[] FirstItem, string[] SecondItem)
        {
            int FirstLength = 0;
            int SecondLength = 0;
            int DistanceVectors = 0;
            Dictionary<string, int> FirstLines = new Dictionary<string, int>();
            Dictionary<string, int> SecondLines = new Dictionary<string, int>();
            FillTheDictionariesOtherLanguage(ref FirstLines, FirstItem, ref FirstLength);
            FillTheDictionariesOtherLanguage(ref SecondLines, SecondItem, ref SecondLength);

            foreach (KeyValuePair<string, int> firstItem in FirstLines)
            {                
                foreach (var secondItem in SecondLines)
                {                    
                    int distance = LevenshteinDistance(firstItem.Key, secondItem.Key);
                    if (((firstItem.Key.Length > 0 && firstItem.Key.Length < 3) || (secondItem.Key.Length > 0 && secondItem.Key.Length < 3)) && distance == 0)
                    {
                        DistanceVectors += 1;
                        break;
                    }
                    if ((firstItem.Key.Length > 2 || secondItem.Key.Length > 2) && distance < 2)
                    {
                        DistanceVectors += 1;
                        break;
                    }
                }
            }
            if (DistanceVectors / (Math.Sqrt(FirstLength) * Math.Sqrt(SecondLength)) > 5)
            {
                int a = 0;
            }
            return DistanceVectors / (Math.Sqrt(FirstLength) * Math.Sqrt(SecondLength));
        }

        private void FillTheDictionariesOtherLanguage(ref Dictionary<string, int> dictionary, string[] inputArray, ref int Length)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (!dictionary.ContainsKey(inputArray[i].ToUpper()))
                {
                    if (dictionary.Count == 0)
                    {
                        dictionary.Add(inputArray[i].ToUpper(), 1);
                        Length += 1;
                    }
                    else
                    {
                        int ii = 1;
                        foreach (var item in dictionary)
                        {
                            int distance = LevenshteinDistance(item.Key, inputArray[i].ToUpper());
                            if (((inputArray[i].Length > 0 && inputArray[i].Length < 3) || (item.Key.Length > 0 && item.Key.Length < 3)) && distance == 0)
                            {
                                break;
                            }
                            if ((inputArray[i].Length > 2 || item.Key.Length > 2) && distance < 2)
                            {
                                break;
                            }
                            else if (ii == dictionary.Count)
                            {
                                dictionary.Add(inputArray[i].ToUpper(), 1);
                                Length += 1;
                                break;
                            }
                            ii++;
                        }
                    }
                }
            }
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

        #region Настройки формы
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
        #endregion
    }
}
