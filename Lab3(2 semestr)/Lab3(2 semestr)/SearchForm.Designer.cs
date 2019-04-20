namespace Lab3_2_semestr_
{
    partial class SearchForm
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
            this.Result = new System.Windows.Forms.TreeView();
            this.LectorSNP = new System.Windows.Forms.TextBox();
            this.FullSearch = new System.Windows.Forms.CheckBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SemestrNumber = new System.Windows.Forms.ComboBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.CourseNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(370, 12);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(283, 232);
            this.Result.TabIndex = 0;
            // 
            // LectorSNP
            // 
            this.LectorSNP.Location = new System.Drawing.Point(3, 28);
            this.LectorSNP.Name = "LectorSNP";
            this.LectorSNP.Size = new System.Drawing.Size(346, 20);
            this.LectorSNP.TabIndex = 1;
            this.LectorSNP.TextChanged += new System.EventHandler(this.LectorSNP_TextChanged);
            // 
            // FullSearch
            // 
            this.FullSearch.AutoSize = true;
            this.FullSearch.Location = new System.Drawing.Point(3, 54);
            this.FullSearch.Name = "FullSearch";
            this.FullSearch.Size = new System.Drawing.Size(136, 17);
            this.FullSearch.TabIndex = 2;
            this.FullSearch.Text = "Полное соответствие";
            this.FullSearch.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.LectorSNP);
            this.Panel1.Controls.Add(this.FullSearch);
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(352, 74);
            this.Panel1.TabIndex = 3;
            this.Panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ф.И.О Лектора";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.SemestrNumber);
            this.Panel2.Location = new System.Drawing.Point(12, 92);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(352, 68);
            this.Panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Семестр";
            // 
            // SemestrNumber
            // 
            this.SemestrNumber.FormattingEnabled = true;
            this.SemestrNumber.Location = new System.Drawing.Point(3, 26);
            this.SemestrNumber.Name = "SemestrNumber";
            this.SemestrNumber.Size = new System.Drawing.Size(121, 21);
            this.SemestrNumber.TabIndex = 0;
            this.SemestrNumber.TextChanged += new System.EventHandler(this.SemestrNumber_TextChanged);
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.CourseNumber);
            this.Panel3.Controls.Add(this.label3);
            this.Panel3.Location = new System.Drawing.Point(12, 166);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(352, 64);
            this.Panel3.TabIndex = 5;
            // 
            // CourseNumber
            // 
            this.CourseNumber.Location = new System.Drawing.Point(13, 21);
            this.CourseNumber.Name = "CourseNumber";
            this.CourseNumber.Size = new System.Drawing.Size(120, 20);
            this.CourseNumber.TabIndex = 1;
            this.CourseNumber.ValueChanged += new System.EventHandler(this.CourseNumber_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Курс";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 256);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Result);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView Result;
        private System.Windows.Forms.TextBox LectorSNP;
        private System.Windows.Forms.CheckBox FullSearch;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.ComboBox SemestrNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CourseNumber;
        private System.Windows.Forms.Label label3;
    }
}