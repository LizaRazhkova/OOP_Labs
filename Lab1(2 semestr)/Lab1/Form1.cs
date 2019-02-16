using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void Str_TextChanged(object sender, EventArgs e)
        {
            int count = Str.Text.Count((x) => x.Equals('\n'));
            LengthValue.Text = (Str.TextLength - count).ToString();
            int len = -1;
            int Vowelcounter = 0, Consonantscounter = 0, Wordscounter = 0, Dotscounter = 0;
            if (int.TryParse(LengthValue.Text, out len) && len > 0)
            {
                string str = "aeyiouуеаояиэю", str1 = "qwrtpsdfghjklzxcvbnmцкнгшщзхйъфвпрлджчсмтбь", str2 = ".?!;,:\n ";
                for (int i = 0; i < str.Length; i++)
                    Vowelcounter += Str.Text.Count((x) => x.Equals(str[i]));
                for (int i = 0; i < str1.Length; i++)
                    Consonantscounter += Str.Text.Count((x) => x.Equals(str1[i]));
                for (int i = 0; i < Str.TextLength - 1; i++)
                {
                    if (str2.Contains(Str.Text[i]) && !str2.Contains(Str.Text[i + 1]))
                        Wordscounter++;
                    if (str2.Substring(0, 3).Contains(Str.Text[i]) && !str2.Substring(0, 3).Contains(Str.Text[i + 1]))
                        Dotscounter++;
                }
                Wordscounter++;
            }
            VowelsCounterValue.Text = Vowelcounter.ToString();
            ConsonantsCounterValue.Text = Consonantscounter.ToString();
            WordsCounterValue.Text = Wordscounter.ToString();
            DotsCounterValue.Text = Dotscounter.ToString();
        }
        private void DeleteOkButton_Click(object sender, EventArgs e)
        {
            string str = Str.Text;
            try { Str.Text = str.Replace(SearchSubStr2.Text, ""); }
            catch { MessageBox.Show("Неверно задана строка для удаления"); }
            SearchSubStr2.Text = "";
            DeleteButtonBack_Click(sender, e);
        }

        private void SearchOkButton_Click(object sender, EventArgs e)
        {
            string str = Str.Text;
            try { Str.Text = str.Replace(SearchSubStr.Text, ChangeSubStr.Text); }
            catch { MessageBox.Show("Неверно заданы аргументы замены"); }
            SearchSubStr.Text = "";
            ChangeSubStr.Text = "";
            ChangingBackButton_Click(sender, e);
        }

        private void IndexValue_TextChanged(object sender, EventArgs e)
        {
            int index;
            try
            {
                if (int.TryParse(IndexValue.Text, out index))
                    SymbolValue.Text = Str.Text[index - 1].ToString();
                else SymbolValue.Text = "";
            }
            catch
            {
                MessageBox.Show("Неверный индекс");
                SymbolValue.Text = "";
            }
        }

        private void SearchSymbol_Click(object sender, EventArgs e)
        {
            SearchPanel.Visible = true;
        }

        private void SearchBack_Click(object sender, EventArgs e)
        {
            SearchPanel.Visible = false;
        }

        private void ChangingBackButton_Click(object sender, EventArgs e)
        {
            Changing.Visible = false;
            Width -= Changing.Width + 10;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            Changing.Visible = true;
            if (DeletePanel.Visible)
                DeleteButtonBack_Click(sender, e);
            if (Width <= Changing.Location.X + 10)
                Width += Changing.Width + 10;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeletePanel.Visible = true;
            if (Changing.Visible)
                ChangingBackButton_Click(sender, e);
            if (Width <= DeletePanel.Location.X + 10)
                Width += DeletePanel.Width + 10;
        }

        private void SearchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteButtonBack_Click(object sender, EventArgs e)
        {
            DeletePanel.Visible = false;
            Width -= DeletePanel.Width + 10;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Width -= Changing.Width + 10;
            DeletePanel.Location = Changing.Location;
        }
    }
}
