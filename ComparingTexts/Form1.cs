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
            string[] arrayFirstText = TextBoxFirstText.Lines;
            string[] arraySecondText = TextBoxSecondText.Lines;
            List<string[]> FirstTextListArrayLines = new List<string[]>();
            List<string[]> SecondTextListArrayLines = new List<string[]>();
            for (int i = 0; i < arrayFirstText.Length; i++)
            {
                FirstTextListArrayLines.Add(arrayFirstText[i].Split(' '));
            }
            for (int i = 0; i < arraySecondText.Length; i++)
            {
                SecondTextListArrayLines.Add(arraySecondText[i].Split(' '));
            }

            foreach (var FirstItem in FirstTextListArrayLines)
            {
                foreach (var SecondItem in SecondTextListArrayLines)
                {
                    
                }
            }
        }
        private void CosDistanceCompute(string[] FirstItem, string[] SecondItem)
        {
            if (FirstItem.Length > SecondItem.Length)
            {
                int[][] compareTextsResult = new int[FirstItem.Length][];
                for (int i = 0; i < FirstItem.Length; i++)
                {
                    compareTextsResult[i] = new int[2];
                    for (int j = 0; j < SecondItem.Length; j++)
                    {
                        if (FirstItem[i] == SecondItem[j])
                        {
                            compareTextsResult[i][0] = 1;
                            compareTextsResult[i][1] = 1;
                        }
                    }
                }
            }
            else
            {
                int[][] compareTextsResult = new int[SecondItem.Length][];
            }
        }
    }
}
