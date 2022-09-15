using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            InitializeParameters();
        }
        private void InitializeParameters()
        {
            DataGridViewForResults.Rows.Clear();
            char[] separators = new char[] { ' ', ',', ':', ';', '-','\"', '(', ')'};
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

            foreach (var FirstItem in FirstTextListArrayLines)
            {
                foreach (var SecondItem in SecondTextListArrayLines)
                {
                    CosCollection.Add(string.Join(" ", FirstItem) + " || " + string.Join(" ", SecondItem), CosDistanceCompute(FirstItem, SecondItem));
                }
            }
            foreach (var item in CosCollection)
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
                    FirstLines.Add(FirstItem[i].ToUpper(), 1);
                    FirstLength += 1;
                }
            }
            for (int i = 0; i < SecondItem.Length; i++)
            {
                if (!SecondLines.ContainsKey(SecondItem[i].ToUpper()))
                {
                    SecondLines.Add(SecondItem[i].ToUpper(), 1);
                    SecondLength += 1;
                }
            }

            foreach (var item in FirstLines)
            {
                if (SecondLines.ContainsKey(item.Key))
                {
                    DistanceVectors += 1;
                }
            }
            return Math.Cos(DistanceVectors / (Math.Sqrt(FirstLength) * Math.Sqrt(SecondLength)));
        }
    }
}
