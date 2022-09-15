using System;
using System.Collections.Generic;
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
            if (toolStripComboBoxSelectModeCompare.SelectedIndex == 0)
            {
                if (!string.IsNullOrWhiteSpace(TextBoxFirstText.Text) && !string.IsNullOrWhiteSpace(TextBoxSecondText.Text))
                {
                    RealizationMethodsCosDistance();
                }
            }
            else if(toolStripComboBoxSelectModeCompare.SelectedIndex == 1)
            {
                MessageBox.Show("В будущем сделаю...");
            }
            else
            {
                MessageBox.Show("Выберите метод сравнения");
            } 
        }
        private void RealizationMethodsCosDistance()
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
                    CosCollection.Add(string.Join(" ", FirstItem) + " || " + string.Join(" ", SecondItem), CosDistanceCompute(FirstItem, SecondItem));
                }
            }
            foreach (KeyValuePair<string, double> item in CosCollection)
            {
                DataGridViewForResults.Rows.Add(item.Key, item.Value);
            }
        }
        private double CosDistanceCompute(string[] FirstItem, string[] SecondItem)
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
    }
}
