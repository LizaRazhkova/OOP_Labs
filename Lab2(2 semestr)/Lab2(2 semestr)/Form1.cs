using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
namespace Lab2_2_semestr_
{
    public partial class Form1 : Form
    {
        Discipline discipline;
        List<Discipline> disciplines;
        List<Book> books;
        public Form1()
        {
            books = new List<Book>();
            disciplines = new List<Discipline>();
            InitializeComponent();
        }
        private void DisciplineName_Enter(object sender, EventArgs e)
        {
            if (DisciplineName.Text == "Название дисциплины")
                DisciplineName.Text = "";
        }
        private void LecturesCount_ValueChanged(object sender, EventArgs e)
        {
            LecturesCountValue.Text = LecturesCount.Value.ToString();
        }
        private void LabsCount_ValueChanged(object sender, EventArgs e)
        {
            LabsCountValue.Text = LabsCount.Value.ToString();
        }
        private void SNP_Enter(object sender, EventArgs e)
        {
            if (SNP.Text == "Ф.И.О.")
                SNP.Text = "";
        }
        private void Pulpit_Enter(object sender, EventArgs e)
        {
            if (Pulpit.Text == "Кафедра")
                Pulpit.Text = "";
        }
        private void BookName_Enter(object sender, EventArgs e)
        {
            if (BookName.Text == "Название")
                BookName.Text = "";
        }
        private void Author_Enter(object sender, EventArgs e)
        {
            if (Author.Text == "Автор")
                Author.Text = "";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Author.Text == "" || Author.Text == "Автор" ||
                BookName.Text == "" || BookName.Text == "Название")
                MessageBox.Show("Укажите книгу корректно");
            else
            {
                Book book = new Book(Author.Text, BookName.Text, CreationDate.Value.Date);
                books.Add(book);
                BookList.Items.Add(book.ToString());
            }
        }

        private void AddAll_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (CheckBox x in Controls.OfType<CheckBox>())
                if (x.Checked)
                {
                    flag = true;
                    break;
                }
            foreach (RadioButton x in Controls.OfType<RadioButton>())
                if (x.Checked)
                {
                    flag = true;
                    break;
                }
            foreach (TextBox x in Controls.OfType<TextBox>())
                if (x.Text == "")
                {
                    flag = false;
                    break;
                }
            int buf;
            if (!flag || 
                DisciplineName.Text == "Название дисциплины" ||
                SemestrValue.Text == "" || !int.TryParse(SemestrValue.Text, out buf) ||
                SNP.Text == "Ф.И.О" ||
                Pulpit.Text == "Кафедра" ||
                books.Count == 0 || LecturesCountValue.Text == "" || LabsCountValue.Text == "")
                MessageBox.Show("Некорректно введены данные");
            else
            {
                discipline = new Discipline(DisciplineName.Text, 
                    int.Parse(SemestrValue.Text), (int)CourseValue.Value,
                    new Spec(SpecializationPOIT.Checked, SpecializationPOIBMS.Checked, 
                    SpecializationISIT.Checked, SpecializationDEVI.Checked), 
                    LecturesCount.Value, LabsCount.Value, ((exam.Checked) ? PassType.Exam : PassType.Test),
                    new Lector(SNP.Text, Pulpit.Text, (int)NumberAudit.Value, (int)CorpusAydit.Value), books);
                try
                {
                    DataContractJsonSerializer Serializer = new DataContractJsonSerializer(typeof(List<Discipline>));
                    FileStream File = new FileStream("Serialize.json", FileMode.Open);
                    disciplines = (List<Discipline>)Serializer.ReadObject(File);
                    File.Dispose();
                } catch { }
                disciplines.Add(discipline);
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Discipline>));
                FileStream file = new FileStream("Serialize.json", FileMode.OpenOrCreate);
                file.Flush();
                serializer.WriteObject(file, disciplines);
                file.Dispose();
                disciplines.Clear();
                BookList.Items.Clear();
                books.Clear();
            }
        }

        private void Output_Click(object sender, EventArgs e)
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Discipline>));
                FileStream file = new FileStream("Serialize.json", FileMode.Open);
                disciplines = (List<Discipline>)serializer.ReadObject(file);
                OutputList.Nodes.Clear();
                foreach (Discipline x in disciplines)
                    OutputList.Nodes.Add(x.TakeElementTree());
                file.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Example1_Click(object sender, EventArgs e)
        {
            DisciplineName.Text = "Высшая математика";
            SemestrValue.Text = "1";
            CourseValue.Value = 1;
            SpecializationPOIT.Checked = true;
            SpecializationDEVI.Checked = true;
            LecturesCount.Value = 20;
            LabsCount.Value = 30;
            exam.Checked = true;
            SNP.Text = "Ловенецкая Е.В.";
            Pulpit.Text = "Высшей математики";
            NumberAudit.Value = 210;
            CorpusAydit.Value = 4;
            books.Add(new Book("Ловенецкая Е.В.", "Высшая математика", DateTime.Parse("01.05.2008")));
            BookList.Items.Add("Ловенецкая Е.В. \"Высшая математика\" 01.05.2008");
            books.Add(new Book("Асмыкович А.А.", "Математика это просто", DateTime.Parse("04.03.2007")));
            BookList.Items.Add("Асмыкович А.А. \"Математика это просто\" 04.03.2007");
            books.Add(new Book("Ловенецкая Е.В. Асмыкович А.А", "Базовый курс высшей математики", DateTime.Parse("15.07.2008")));
            BookList.Items.Add("Ловенецкая Е.В. Асмыкович А.А \"Базовый курс высшей математики\" 15.07.2008");
        }

        private void Example2_Click(object sender, EventArgs e)
        {
            DisciplineName.Text = "Основы алгоритмизации и проограммирования";
            SemestrValue.Text = "1";
            CourseValue.Value = 1;
            SpecializationPOIT.Checked = true;
            SpecializationPOIBMS.Checked = true;
            SpecializationDEVI.Checked = true;
            LecturesCount.Value = 20;
            LabsCount.Value = 30;
            exam.Checked = true;
            SNP.Text = "Белодед Н.И.";
            Pulpit.Text = "Программная инженерия";
            NumberAudit.Value = 210;
            CorpusAydit.Value = 4;
            books.Add(new Book("???", "???", DateTime.Parse("01.05.2008")));
            BookList.Items.Add("??? \"???\" 01.05.2008");
        }
    }
}
