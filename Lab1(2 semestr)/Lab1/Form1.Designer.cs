namespace Lab1
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
            this.ChangeButton = new System.Windows.Forms.Button();
            this.Str = new System.Windows.Forms.TextBox();
            this.Changing = new System.Windows.Forms.Panel();
            this.ChangingBackButton = new System.Windows.Forms.Button();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.PanelLabel = new System.Windows.Forms.Label();
            this.ChangeOkButton = new System.Windows.Forms.Button();
            this.ChangeSubStr = new System.Windows.Forms.TextBox();
            this.SearchSubStr = new System.Windows.Forms.TextBox();
            this.InputString = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeletePanel = new System.Windows.Forms.Panel();
            this.DeleteButtonBack = new System.Windows.Forms.Button();
            this.DeleteOkButton = new System.Windows.Forms.Button();
            this.SearchLabel2 = new System.Windows.Forms.Label();
            this.DeleteLabel = new System.Windows.Forms.Label();
            this.SearchSubStr2 = new System.Windows.Forms.TextBox();
            this.SearchSymbol = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchBack = new System.Windows.Forms.Button();
            this.SymbolValue = new System.Windows.Forms.Label();
            this.Symbol = new System.Windows.Forms.Label();
            this.IndexValue = new System.Windows.Forms.TextBox();
            this.Index = new System.Windows.Forms.Label();
            this.LenghtLabel = new System.Windows.Forms.Label();
            this.LengthValue = new System.Windows.Forms.Label();
            this.VowelsCounter = new System.Windows.Forms.Label();
            this.ConsonantsCounter = new System.Windows.Forms.Label();
            this.VowelsCounterValue = new System.Windows.Forms.Label();
            this.ConsonantsCounterValue = new System.Windows.Forms.Label();
            this.WordsCounter = new System.Windows.Forms.Label();
            this.WordsCounterValue = new System.Windows.Forms.Label();
            this.DotsCounter = new System.Windows.Forms.Label();
            this.DotsCounterValue = new System.Windows.Forms.Label();
            this.Changing.SuspendLayout();
            this.DeletePanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(12, 183);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(81, 24);
            this.ChangeButton.TabIndex = 0;
            this.ChangeButton.Text = "Заменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // Str
            // 
            this.Str.Location = new System.Drawing.Point(12, 26);
            this.Str.Multiline = true;
            this.Str.Name = "Str";
            this.Str.Size = new System.Drawing.Size(299, 50);
            this.Str.TabIndex = 1;
            this.Str.TextChanged += new System.EventHandler(this.Str_TextChanged);
            // 
            // Changing
            // 
            this.Changing.Controls.Add(this.ChangingBackButton);
            this.Changing.Controls.Add(this.ChangeLabel);
            this.Changing.Controls.Add(this.SearchLabel);
            this.Changing.Controls.Add(this.PanelLabel);
            this.Changing.Controls.Add(this.ChangeOkButton);
            this.Changing.Controls.Add(this.ChangeSubStr);
            this.Changing.Controls.Add(this.SearchSubStr);
            this.Changing.Location = new System.Drawing.Point(329, 12);
            this.Changing.Name = "Changing";
            this.Changing.Size = new System.Drawing.Size(239, 108);
            this.Changing.TabIndex = 3;
            this.Changing.Visible = false;
            // 
            // ChangingBackButton
            // 
            this.ChangingBackButton.Location = new System.Drawing.Point(94, 74);
            this.ChangingBackButton.Name = "ChangingBackButton";
            this.ChangingBackButton.Size = new System.Drawing.Size(75, 23);
            this.ChangingBackButton.TabIndex = 6;
            this.ChangingBackButton.Text = "Отмена";
            this.ChangingBackButton.UseVisualStyleBackColor = true;
            this.ChangingBackButton.Click += new System.EventHandler(this.ChangingBackButton_Click);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Location = new System.Drawing.Point(129, 32);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(75, 13);
            this.ChangeLabel.TabIndex = 5;
            this.ChangeLabel.Text = "Заменить на:";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(10, 32);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(94, 13);
            this.SearchLabel.TabIndex = 4;
            this.SearchLabel.Text = "Искомая строка:";
            // 
            // PanelLabel
            // 
            this.PanelLabel.AutoSize = true;
            this.PanelLabel.Location = new System.Drawing.Point(75, 7);
            this.PanelLabel.Name = "PanelLabel";
            this.PanelLabel.Size = new System.Drawing.Size(102, 13);
            this.PanelLabel.TabIndex = 3;
            this.PanelLabel.Text = "Замена подстроки";
            // 
            // ChangeOkButton
            // 
            this.ChangeOkButton.Location = new System.Drawing.Point(13, 74);
            this.ChangeOkButton.Name = "ChangeOkButton";
            this.ChangeOkButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeOkButton.TabIndex = 2;
            this.ChangeOkButton.Text = "Ок";
            this.ChangeOkButton.UseVisualStyleBackColor = true;
            this.ChangeOkButton.Click += new System.EventHandler(this.SearchOkButton_Click);
            // 
            // ChangeSubStr
            // 
            this.ChangeSubStr.Location = new System.Drawing.Point(132, 48);
            this.ChangeSubStr.Name = "ChangeSubStr";
            this.ChangeSubStr.Size = new System.Drawing.Size(100, 20);
            this.ChangeSubStr.TabIndex = 1;
            // 
            // SearchSubStr
            // 
            this.SearchSubStr.Location = new System.Drawing.Point(13, 48);
            this.SearchSubStr.Name = "SearchSubStr";
            this.SearchSubStr.Size = new System.Drawing.Size(100, 20);
            this.SearchSubStr.TabIndex = 0;
            // 
            // InputString
            // 
            this.InputString.AutoSize = true;
            this.InputString.Location = new System.Drawing.Point(13, 7);
            this.InputString.Name = "InputString";
            this.InputString.Size = new System.Drawing.Size(87, 13);
            this.InputString.TabIndex = 4;
            this.InputString.Text = "Входная строка";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(99, 183);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 24);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeletePanel
            // 
            this.DeletePanel.Controls.Add(this.DeleteButtonBack);
            this.DeletePanel.Controls.Add(this.DeleteOkButton);
            this.DeletePanel.Controls.Add(this.SearchLabel2);
            this.DeletePanel.Controls.Add(this.DeleteLabel);
            this.DeletePanel.Controls.Add(this.SearchSubStr2);
            this.DeletePanel.Location = new System.Drawing.Point(329, 135);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.Size = new System.Drawing.Size(177, 100);
            this.DeletePanel.TabIndex = 6;
            this.DeletePanel.Visible = false;
            // 
            // DeleteButtonBack
            // 
            this.DeleteButtonBack.Location = new System.Drawing.Point(91, 74);
            this.DeleteButtonBack.Name = "DeleteButtonBack";
            this.DeleteButtonBack.Size = new System.Drawing.Size(75, 23);
            this.DeleteButtonBack.TabIndex = 6;
            this.DeleteButtonBack.Text = "Отмена";
            this.DeleteButtonBack.UseVisualStyleBackColor = true;
            this.DeleteButtonBack.Click += new System.EventHandler(this.DeleteButtonBack_Click);
            // 
            // DeleteOkButton
            // 
            this.DeleteOkButton.Location = new System.Drawing.Point(12, 74);
            this.DeleteOkButton.Name = "DeleteOkButton";
            this.DeleteOkButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteOkButton.TabIndex = 2;
            this.DeleteOkButton.Text = "Ok";
            this.DeleteOkButton.UseVisualStyleBackColor = true;
            this.DeleteOkButton.Click += new System.EventHandler(this.DeleteOkButton_Click);
            // 
            // SearchLabel2
            // 
            this.SearchLabel2.AutoSize = true;
            this.SearchLabel2.Location = new System.Drawing.Point(9, 32);
            this.SearchLabel2.Name = "SearchLabel2";
            this.SearchLabel2.Size = new System.Drawing.Size(94, 13);
            this.SearchLabel2.TabIndex = 4;
            this.SearchLabel2.Text = "Искомая строка:";
            // 
            // DeleteLabel
            // 
            this.DeleteLabel.AutoSize = true;
            this.DeleteLabel.Location = new System.Drawing.Point(37, 9);
            this.DeleteLabel.Name = "DeleteLabel";
            this.DeleteLabel.Size = new System.Drawing.Size(113, 13);
            this.DeleteLabel.TabIndex = 3;
            this.DeleteLabel.Text = "Удаление подстроки";
            // 
            // SearchSubStr2
            // 
            this.SearchSubStr2.Location = new System.Drawing.Point(12, 48);
            this.SearchSubStr2.Name = "SearchSubStr2";
            this.SearchSubStr2.Size = new System.Drawing.Size(154, 20);
            this.SearchSubStr2.TabIndex = 0;
            // 
            // SearchSymbol
            // 
            this.SearchSymbol.Location = new System.Drawing.Point(12, 82);
            this.SearchSymbol.Name = "SearchSymbol";
            this.SearchSymbol.Size = new System.Drawing.Size(81, 23);
            this.SearchSymbol.TabIndex = 7;
            this.SearchSymbol.Text = "Найти";
            this.SearchSymbol.UseVisualStyleBackColor = true;
            this.SearchSymbol.Click += new System.EventHandler(this.SearchSymbol_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.SearchBack);
            this.SearchPanel.Controls.Add(this.SymbolValue);
            this.SearchPanel.Controls.Add(this.Symbol);
            this.SearchPanel.Controls.Add(this.IndexValue);
            this.SearchPanel.Controls.Add(this.Index);
            this.SearchPanel.Location = new System.Drawing.Point(99, 83);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(212, 22);
            this.SearchPanel.TabIndex = 8;
            this.SearchPanel.Visible = false;
            this.SearchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SearchPanel_Paint);
            // 
            // SearchBack
            // 
            this.SearchBack.Location = new System.Drawing.Point(181, 0);
            this.SearchBack.Name = "SearchBack";
            this.SearchBack.Size = new System.Drawing.Size(26, 22);
            this.SearchBack.TabIndex = 4;
            this.SearchBack.Text = "<-";
            this.SearchBack.UseVisualStyleBackColor = true;
            this.SearchBack.Click += new System.EventHandler(this.SearchBack_Click);
            // 
            // SymbolValue
            // 
            this.SymbolValue.AutoSize = true;
            this.SymbolValue.Location = new System.Drawing.Point(159, 3);
            this.SymbolValue.Name = "SymbolValue";
            this.SymbolValue.Size = new System.Drawing.Size(0, 13);
            this.SymbolValue.TabIndex = 3;
            // 
            // Symbol
            // 
            this.Symbol.AutoSize = true;
            this.Symbol.Location = new System.Drawing.Point(107, 3);
            this.Symbol.Name = "Symbol";
            this.Symbol.Size = new System.Drawing.Size(49, 13);
            this.Symbol.TabIndex = 2;
            this.Symbol.Text = "Символ:";
            // 
            // IndexValue
            // 
            this.IndexValue.Location = new System.Drawing.Point(55, 0);
            this.IndexValue.Name = "IndexValue";
            this.IndexValue.Size = new System.Drawing.Size(46, 20);
            this.IndexValue.TabIndex = 1;
            this.IndexValue.TextChanged += new System.EventHandler(this.IndexValue_TextChanged);
            // 
            // Index
            // 
            this.Index.AutoSize = true;
            this.Index.Location = new System.Drawing.Point(4, 3);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(48, 13);
            this.Index.TabIndex = 0;
            this.Index.Text = "Индекс:";
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Location = new System.Drawing.Point(13, 112);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(81, 13);
            this.LenghtLabel.TabIndex = 9;
            this.LenghtLabel.Text = "Длина строки:";
            // 
            // LengthValue
            // 
            this.LengthValue.AutoSize = true;
            this.LengthValue.Location = new System.Drawing.Point(94, 112);
            this.LengthValue.Name = "LengthValue";
            this.LengthValue.Size = new System.Drawing.Size(0, 13);
            this.LengthValue.TabIndex = 10;
            // 
            // VowelsCounter
            // 
            this.VowelsCounter.AutoSize = true;
            this.VowelsCounter.Location = new System.Drawing.Point(13, 125);
            this.VowelsCounter.Name = "VowelsCounter";
            this.VowelsCounter.Size = new System.Drawing.Size(114, 13);
            this.VowelsCounter.TabIndex = 11;
            this.VowelsCounter.Text = "Количество гласных:";
            // 
            // ConsonantsCounter
            // 
            this.ConsonantsCounter.AutoSize = true;
            this.ConsonantsCounter.Location = new System.Drawing.Point(13, 138);
            this.ConsonantsCounter.Name = "ConsonantsCounter";
            this.ConsonantsCounter.Size = new System.Drawing.Size(126, 13);
            this.ConsonantsCounter.TabIndex = 12;
            this.ConsonantsCounter.Text = "Количество согласных:";
            // 
            // VowelsCounterValue
            // 
            this.VowelsCounterValue.AutoSize = true;
            this.VowelsCounterValue.Location = new System.Drawing.Point(127, 125);
            this.VowelsCounterValue.Name = "VowelsCounterValue";
            this.VowelsCounterValue.Size = new System.Drawing.Size(0, 13);
            this.VowelsCounterValue.TabIndex = 13;
            // 
            // ConsonantsCounterValue
            // 
            this.ConsonantsCounterValue.AutoSize = true;
            this.ConsonantsCounterValue.Location = new System.Drawing.Point(139, 138);
            this.ConsonantsCounterValue.Name = "ConsonantsCounterValue";
            this.ConsonantsCounterValue.Size = new System.Drawing.Size(0, 13);
            this.ConsonantsCounterValue.TabIndex = 14;
            // 
            // WordsCounter
            // 
            this.WordsCounter.AutoSize = true;
            this.WordsCounter.Location = new System.Drawing.Point(13, 151);
            this.WordsCounter.Name = "WordsCounter";
            this.WordsCounter.Size = new System.Drawing.Size(96, 13);
            this.WordsCounter.TabIndex = 15;
            this.WordsCounter.Text = "Количество слов:";
            // 
            // WordsCounterValue
            // 
            this.WordsCounterValue.AutoSize = true;
            this.WordsCounterValue.Location = new System.Drawing.Point(109, 151);
            this.WordsCounterValue.Name = "WordsCounterValue";
            this.WordsCounterValue.Size = new System.Drawing.Size(0, 13);
            this.WordsCounterValue.TabIndex = 16;
            // 
            // DotsCounter
            // 
            this.DotsCounter.AutoSize = true;
            this.DotsCounter.Location = new System.Drawing.Point(13, 164);
            this.DotsCounter.Name = "DotsCounter";
            this.DotsCounter.Size = new System.Drawing.Size(140, 13);
            this.DotsCounter.TabIndex = 17;
            this.DotsCounter.Text = "Количество предложений:";
            // 
            // DotsCounterValue
            // 
            this.DotsCounterValue.AutoSize = true;
            this.DotsCounterValue.Location = new System.Drawing.Point(153, 164);
            this.DotsCounterValue.Name = "DotsCounterValue";
            this.DotsCounterValue.Size = new System.Drawing.Size(0, 13);
            this.DotsCounterValue.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 214);
            this.Controls.Add(this.DotsCounterValue);
            this.Controls.Add(this.DotsCounter);
            this.Controls.Add(this.WordsCounterValue);
            this.Controls.Add(this.WordsCounter);
            this.Controls.Add(this.ConsonantsCounterValue);
            this.Controls.Add(this.VowelsCounterValue);
            this.Controls.Add(this.ConsonantsCounter);
            this.Controls.Add(this.VowelsCounter);
            this.Controls.Add(this.LengthValue);
            this.Controls.Add(this.LenghtLabel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.SearchSymbol);
            this.Controls.Add(this.DeletePanel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.InputString);
            this.Controls.Add(this.Changing);
            this.Controls.Add(this.Str);
            this.Controls.Add(this.ChangeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Текстовый калькулятор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Changing.ResumeLayout(false);
            this.Changing.PerformLayout();
            this.DeletePanel.ResumeLayout(false);
            this.DeletePanel.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox Str;
        private System.Windows.Forms.Panel Changing;
        private System.Windows.Forms.TextBox ChangeSubStr;
        private System.Windows.Forms.TextBox SearchSubStr;
        private System.Windows.Forms.Button ChangeOkButton;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label PanelLabel;
        private System.Windows.Forms.Label InputString;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel DeletePanel;
        private System.Windows.Forms.Button DeleteOkButton;
        private System.Windows.Forms.Label SearchLabel2;
        private System.Windows.Forms.TextBox SearchSubStr2;
        private System.Windows.Forms.Label DeleteLabel;
        private System.Windows.Forms.Button SearchSymbol;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Label Symbol;
        private System.Windows.Forms.TextBox IndexValue;
        private System.Windows.Forms.Label Index;
        private System.Windows.Forms.Label SymbolValue;
        private System.Windows.Forms.Button SearchBack;
        private System.Windows.Forms.Label LenghtLabel;
        private System.Windows.Forms.Label LengthValue;
        private System.Windows.Forms.Button ChangingBackButton;
        private System.Windows.Forms.Button DeleteButtonBack;
        private System.Windows.Forms.Label VowelsCounter;
        private System.Windows.Forms.Label ConsonantsCounter;
        private System.Windows.Forms.Label VowelsCounterValue;
        private System.Windows.Forms.Label ConsonantsCounterValue;
        private System.Windows.Forms.Label WordsCounter;
        private System.Windows.Forms.Label WordsCounterValue;
        private System.Windows.Forms.Label DotsCounter;
        private System.Windows.Forms.Label DotsCounterValue;
    }
}

