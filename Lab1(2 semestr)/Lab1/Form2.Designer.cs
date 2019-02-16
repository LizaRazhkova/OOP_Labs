namespace Lab1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Generate = new System.Windows.Forms.Button();
            this.LengthCollectionLabel = new System.Windows.Forms.Label();
            this.LengthCollection = new System.Windows.Forms.TextBox();
            this.UpSort = new System.Windows.Forms.Button();
            this.SortLabel = new System.Windows.Forms.Label();
            this.DownSort = new System.Windows.Forms.Button();
            this.RequestLabel = new System.Windows.Forms.Label();
            this.GoodPass = new System.Windows.Forms.Button();
            this.BadPass = new System.Windows.Forms.Button();
            this.NoPass = new System.Windows.Forms.Button();
            this.GeneratedList = new System.Windows.Forms.ListBox();
            this.OutputList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(118, 25);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(100, 20);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Сгенерирровать";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // LengthCollectionLabel
            // 
            this.LengthCollectionLabel.AutoSize = true;
            this.LengthCollectionLabel.Location = new System.Drawing.Point(9, 9);
            this.LengthCollectionLabel.Name = "LengthCollectionLabel";
            this.LengthCollectionLabel.Size = new System.Drawing.Size(123, 13);
            this.LengthCollectionLabel.TabIndex = 2;
            this.LengthCollectionLabel.Text = "Количество студентов:";
            // 
            // LengthCollection
            // 
            this.LengthCollection.Location = new System.Drawing.Point(12, 25);
            this.LengthCollection.Name = "LengthCollection";
            this.LengthCollection.Size = new System.Drawing.Size(100, 20);
            this.LengthCollection.TabIndex = 3;
            // 
            // UpSort
            // 
            this.UpSort.Location = new System.Drawing.Point(224, 70);
            this.UpSort.Name = "UpSort";
            this.UpSort.Size = new System.Drawing.Size(99, 23);
            this.UpSort.TabIndex = 4;
            this.UpSort.Text = "возрастанию";
            this.UpSort.UseVisualStyleBackColor = true;
            this.UpSort.Click += new System.EventHandler(this.UpSort_Click);
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Location = new System.Drawing.Point(225, 51);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(90, 13);
            this.SortLabel.TabIndex = 5;
            this.SortLabel.Text = "Сортировать по:";
            // 
            // DownSort
            // 
            this.DownSort.Location = new System.Drawing.Point(224, 99);
            this.DownSort.Name = "DownSort";
            this.DownSort.Size = new System.Drawing.Size(99, 23);
            this.DownSort.TabIndex = 6;
            this.DownSort.Text = "убыванию";
            this.DownSort.UseVisualStyleBackColor = true;
            this.DownSort.Click += new System.EventHandler(this.DownSort_Click);
            // 
            // RequestLabel
            // 
            this.RequestLabel.AutoSize = true;
            this.RequestLabel.Location = new System.Drawing.Point(228, 129);
            this.RequestLabel.Name = "RequestLabel";
            this.RequestLabel.Size = new System.Drawing.Size(55, 13);
            this.RequestLabel.TabIndex = 7;
            this.RequestLabel.Text = "Запросы:";
            // 
            // GoodPass
            // 
            this.GoodPass.Location = new System.Drawing.Point(224, 146);
            this.GoodPass.Name = "GoodPass";
            this.GoodPass.Size = new System.Drawing.Size(99, 23);
            this.GoodPass.TabIndex = 8;
            this.GoodPass.Text = "Сдали экзамен";
            this.GoodPass.UseVisualStyleBackColor = true;
            this.GoodPass.Click += new System.EventHandler(this.GoodPass_Click);
            // 
            // BadPass
            // 
            this.BadPass.Location = new System.Drawing.Point(224, 176);
            this.BadPass.Name = "BadPass";
            this.BadPass.Size = new System.Drawing.Size(99, 23);
            this.BadPass.TabIndex = 9;
            this.BadPass.Text = "Пересдача";
            this.BadPass.UseVisualStyleBackColor = true;
            this.BadPass.Click += new System.EventHandler(this.BadPass_Click);
            // 
            // NoPass
            // 
            this.NoPass.Location = new System.Drawing.Point(224, 206);
            this.NoPass.Name = "NoPass";
            this.NoPass.Size = new System.Drawing.Size(99, 23);
            this.NoPass.TabIndex = 10;
            this.NoPass.Text = "Не допущены";
            this.NoPass.UseVisualStyleBackColor = true;
            this.NoPass.Click += new System.EventHandler(this.NoPass_Click);
            // 
            // GeneratedList
            // 
            this.GeneratedList.FormattingEnabled = true;
            this.GeneratedList.Location = new System.Drawing.Point(13, 52);
            this.GeneratedList.Name = "GeneratedList";
            this.GeneratedList.Size = new System.Drawing.Size(205, 303);
            this.GeneratedList.TabIndex = 11;
            // 
            // OutputList
            // 
            this.OutputList.FormattingEnabled = true;
            this.OutputList.Location = new System.Drawing.Point(329, 52);
            this.OutputList.Name = "OutputList";
            this.OutputList.Size = new System.Drawing.Size(205, 303);
            this.OutputList.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 376);
            this.Controls.Add(this.OutputList);
            this.Controls.Add(this.GeneratedList);
            this.Controls.Add(this.NoPass);
            this.Controls.Add(this.BadPass);
            this.Controls.Add(this.GoodPass);
            this.Controls.Add(this.RequestLabel);
            this.Controls.Add(this.DownSort);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.UpSort);
            this.Controls.Add(this.LengthCollection);
            this.Controls.Add(this.LengthCollectionLabel);
            this.Controls.Add(this.Generate);
            this.Name = "Form2";
            this.Text = "Результаты экзамена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label LengthCollectionLabel;
        private System.Windows.Forms.TextBox LengthCollection;
        private System.Windows.Forms.Button UpSort;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.Button DownSort;
        private System.Windows.Forms.Label RequestLabel;
        private System.Windows.Forms.Button GoodPass;
        private System.Windows.Forms.Button BadPass;
        private System.Windows.Forms.Button NoPass;
        private System.Windows.Forms.ListBox GeneratedList;
        private System.Windows.Forms.ListBox OutputList;
    }
}