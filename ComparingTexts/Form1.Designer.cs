
namespace ComparingTexts
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TextBoxFirstText = new System.Windows.Forms.RichTextBox();
            this.TextBoxSecondText = new System.Windows.Forms.RichTextBox();
            this.DataGridViewForResults = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CompareTextsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxSelectModeCompare = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.WordsCompareMetrics = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CleartextBoxesButton = new System.Windows.Forms.ToolStripButton();
            this.ButtonTestsText = new System.Windows.Forms.ToolStripButton();
            this.CompareTexts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CosDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewForResults)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TextBoxFirstText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TextBoxSecondText);
            this.splitContainer1.Size = new System.Drawing.Size(1175, 426);
            this.splitContainer1.SplitterDistance = 556;
            this.splitContainer1.TabIndex = 0;
            // 
            // TextBoxFirstText
            // 
            this.TextBoxFirstText.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxFirstText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxFirstText.DetectUrls = false;
            this.TextBoxFirstText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxFirstText.Location = new System.Drawing.Point(0, 0);
            this.TextBoxFirstText.Name = "TextBoxFirstText";
            this.TextBoxFirstText.Size = new System.Drawing.Size(554, 424);
            this.TextBoxFirstText.TabIndex = 0;
            this.TextBoxFirstText.Text = "";
            // 
            // TextBoxSecondText
            // 
            this.TextBoxSecondText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSecondText.DetectUrls = false;
            this.TextBoxSecondText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSecondText.Location = new System.Drawing.Point(0, 0);
            this.TextBoxSecondText.Name = "TextBoxSecondText";
            this.TextBoxSecondText.Size = new System.Drawing.Size(613, 424);
            this.TextBoxSecondText.TabIndex = 1;
            this.TextBoxSecondText.Text = "";
            // 
            // DataGridViewForResults
            // 
            this.DataGridViewForResults.AllowUserToAddRows = false;
            this.DataGridViewForResults.AllowUserToDeleteRows = false;
            this.DataGridViewForResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewForResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewForResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridViewForResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewForResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewForResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompareTexts,
            this.CosDistance});
            this.DataGridViewForResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewForResults.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewForResults.Name = "DataGridViewForResults";
            this.DataGridViewForResults.ReadOnly = true;
            this.DataGridViewForResults.Size = new System.Drawing.Size(1173, 184);
            this.DataGridViewForResults.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompareTextsButton,
            this.CleartextBoxesButton,
            this.ButtonTestsText,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripComboBoxSelectModeCompare,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.WordsCompareMetrics});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1175, 46);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CompareTextsButton
            // 
            this.CompareTextsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CompareTextsButton.Image = ((System.Drawing.Image)(resources.GetObject("CompareTextsButton.Image")));
            this.CompareTextsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CompareTextsButton.Name = "CompareTextsButton";
            this.CompareTextsButton.Size = new System.Drawing.Size(103, 19);
            this.CompareTextsButton.Text = "Сравнить тексты";
            this.CompareTextsButton.Click += new System.EventHandler(this.CompareTextsButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(212, 15);
            this.toolStripLabel1.Text = "Выберите способ сравнения текстов:";
            // 
            // toolStripComboBoxSelectModeCompare
            // 
            this.toolStripComboBoxSelectModeCompare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBoxSelectModeCompare.Items.AddRange(new object[] {
            "Косинусное расстояние",
            "Коэффициент линейной корреляции"});
            this.toolStripComboBoxSelectModeCompare.Name = "toolStripComboBoxSelectModeCompare";
            this.toolStripComboBoxSelectModeCompare.Size = new System.Drawing.Size(300, 23);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 46);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DataGridViewForResults);
            this.splitContainer2.Size = new System.Drawing.Size(1175, 616);
            this.splitContainer2.SplitterDistance = 426;
            this.splitContainer2.TabIndex = 1;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(163, 15);
            this.toolStripLabel2.Text = "Расстояние сравнения слов:";
            // 
            // WordsCompareMetrics
            // 
            this.WordsCompareMetrics.AutoCompleteCustomSource.AddRange(new string[] {
            "Soundex (только для английского языка)",
            "Расстояние Левенштейна (для всех)"});
            this.WordsCompareMetrics.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WordsCompareMetrics.Items.AddRange(new object[] {
            "Soundex (для английского языка)",
            "Расстояние Левенштейна (Для остальных)"});
            this.WordsCompareMetrics.Name = "WordsCompareMetrics";
            this.WordsCompareMetrics.Size = new System.Drawing.Size(300, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // CleartextBoxesButton
            // 
            this.CleartextBoxesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CleartextBoxesButton.Image = ((System.Drawing.Image)(resources.GetObject("CleartextBoxesButton.Image")));
            this.CleartextBoxesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CleartextBoxesButton.Name = "CleartextBoxesButton";
            this.CleartextBoxesButton.Size = new System.Drawing.Size(127, 19);
            this.CleartextBoxesButton.Text = "Очистить поля ввода";
            this.CleartextBoxesButton.Click += new System.EventHandler(this.CleartextBoxesButton_Click);
            // 
            // ButtonTestsText
            // 
            this.ButtonTestsText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonTestsText.Image = ((System.Drawing.Image)(resources.GetObject("ButtonTestsText.Image")));
            this.ButtonTestsText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonTestsText.Name = "ButtonTestsText";
            this.ButtonTestsText.Size = new System.Drawing.Size(160, 19);
            this.ButtonTestsText.Text = "Вставить тестовый вариант";
            this.ButtonTestsText.Click += new System.EventHandler(this.ButtonTestsText_Click);
            // 
            // CompareTexts
            // 
            this.CompareTexts.FillWeight = 149.2386F;
            this.CompareTexts.HeaderText = "Сравниваемые предложения";
            this.CompareTexts.Name = "CompareTexts";
            this.CompareTexts.ReadOnly = true;
            // 
            // CosDistance
            // 
            this.CosDistance.FillWeight = 50.76142F;
            this.CosDistance.HeaderText = "Косинусное расстояние";
            this.CosDistance.Name = "CosDistance";
            this.CosDistance.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 662);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сравнение текстов";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewForResults)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox TextBoxFirstText;
        private System.Windows.Forms.RichTextBox TextBoxSecondText;
        private System.Windows.Forms.DataGridView DataGridViewForResults;
        private System.Windows.Forms.ToolStripButton CompareTextsButton;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSelectModeCompare;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox WordsCompareMetrics;
        private System.Windows.Forms.ToolStripButton CleartextBoxesButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ButtonTestsText;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompareTexts;
        private System.Windows.Forms.DataGridViewTextBoxColumn CosDistance;
    }
}

