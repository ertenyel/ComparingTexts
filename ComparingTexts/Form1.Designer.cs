
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridViewForResults = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CompareTextsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxSelectModeCompare = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewForResults)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TextBoxFirstText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TextBoxSecondText);
            this.splitContainer1.Size = new System.Drawing.Size(800, 325);
            this.splitContainer1.SplitterDistance = 391;
            this.splitContainer1.TabIndex = 0;
            // 
            // TextBoxFirstText
            // 
            this.TextBoxFirstText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxFirstText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxFirstText.Location = new System.Drawing.Point(0, 0);
            this.TextBoxFirstText.Name = "TextBoxFirstText";
            this.TextBoxFirstText.Size = new System.Drawing.Size(389, 323);
            this.TextBoxFirstText.TabIndex = 0;
            this.TextBoxFirstText.Text = "";
            // 
            // TextBoxSecondText
            // 
            this.TextBoxSecondText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSecondText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSecondText.Location = new System.Drawing.Point(0, 0);
            this.TextBoxSecondText.Name = "TextBoxSecondText";
            this.TextBoxSecondText.Size = new System.Drawing.Size(403, 323);
            this.TextBoxSecondText.TabIndex = 1;
            this.TextBoxSecondText.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DataGridViewForResults);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // DataGridViewForResults
            // 
            this.DataGridViewForResults.AllowUserToAddRows = false;
            this.DataGridViewForResults.AllowUserToDeleteRows = false;
            this.DataGridViewForResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridViewForResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewForResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewForResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewForResults.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewForResults.Name = "DataGridViewForResults";
            this.DataGridViewForResults.ReadOnly = true;
            this.DataGridViewForResults.Size = new System.Drawing.Size(798, 98);
            this.DataGridViewForResults.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompareTextsButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripComboBoxSelectModeCompare});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CompareTextsButton
            // 
            this.CompareTextsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CompareTextsButton.Image = ((System.Drawing.Image)(resources.GetObject("CompareTextsButton.Image")));
            this.CompareTextsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CompareTextsButton.Name = "CompareTextsButton";
            this.CompareTextsButton.Size = new System.Drawing.Size(103, 22);
            this.CompareTextsButton.Text = "Сравнить тексты";
            this.CompareTextsButton.Click += new System.EventHandler(this.CompareTextsButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(209, 22);
            this.toolStripLabel1.Text = "Выберите способ сравнения текстов";
            // 
            // toolStripComboBoxSelectModeCompare
            // 
            this.toolStripComboBoxSelectModeCompare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBoxSelectModeCompare.Items.AddRange(new object[] {
            "Косинусное расстояние",
            "Коэффициент линейной корреляции"});
            this.toolStripComboBoxSelectModeCompare.Name = "toolStripComboBoxSelectModeCompare";
            this.toolStripComboBoxSelectModeCompare.Size = new System.Drawing.Size(170, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Сравнение текстов";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewForResults)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox TextBoxFirstText;
        private System.Windows.Forms.RichTextBox TextBoxSecondText;
        private System.Windows.Forms.DataGridView DataGridViewForResults;
        private System.Windows.Forms.ToolStripButton CompareTextsButton;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSelectModeCompare;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

