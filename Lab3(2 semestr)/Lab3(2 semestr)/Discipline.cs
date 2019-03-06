using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Lab2_2_semestr_
{
    [DataContract]
    struct Spec
    {
        [DataMember]
        private bool POIT;
        [DataMember]
        private bool POIBMS;
        [DataMember]
        private bool ISIT;
        [DataMember]
        private bool DEVI;
        public Spec(bool poit, bool poibms, bool isit, bool devi)
        {
            POIT = poit;
            POIBMS = poibms;
            ISIT = isit;
            DEVI = devi;
        }
        public override string ToString()
        {
            return (POIT ? "ПОИТ " : "") + 
                (POIBMS ? "ПОИБМС " : "") + 
                (ISIT ? "ИСИТ " : "") +
                (DEVI ? "ДЭВИ" : "");
        }
    }
    [DataContract]
    enum PassType
    {
        Exam = 0,
        Test = 1
    }
    [DataContract]
    class Lector
    {
        [DataMember]
        private string SNP; // Surname Name Patronomic
        [DataMember]
        private string Pulpit;
        [DataMember]
        private string MainWorkPlace;
        public Lector(string snp, string pulpit, int number, int building)
        {
            SNP = snp;
            Pulpit = pulpit;
            MainWorkPlace = number.ToString() + '-' + building.ToString();
        }
        public string snp => SNP;
        public string pulpit => Pulpit;
        public string WorkPlace => MainWorkPlace;
    }
    [DataContract]
    class Book
    {
        [DataMember]
        private string Author;
        [DataMember]
        private string Name;
        [DataMember]
        private DateTime CreationDate;
        public Book(string author, string name, DateTime date)
        {
            Author = author;
            Name = name;
            CreationDate = date;
        }
        public override string ToString() => 
            Author + 
            " \"" + Name + 
            "\" " + CreationDate.Day.ToString() + '.' + CreationDate.Month.ToString() + '.' + CreationDate.Year.ToString();
    }
    [DataContract]
    class Discipline
    {
        [DataMember]
        private string Name;
        [DataMember]
        private int Semestr;
        [DataMember]
        private int Course;
        [DataMember]
        private Spec specialization;
        [DataMember]
        private int LecturesCount;
        [DataMember]
        private int LabsCount;
        [DataMember]
        private PassType pass;
        [DataMember]
        private Lector lector;
        [DataMember]
        private List<Book> bookList;
        public Discipline(string name,
            int semestr,
            int course,
            Spec spec,
            int lectcount,
            int labscount,
            PassType type,
            Lector lect,
            IEnumerable<Book> books)
        {
            Name = name;
            Semestr = semestr;
            Course = course;
            specialization = spec;
            LecturesCount = lectcount;
            LabsCount = labscount;
            pass = type;
            lector = lect;
            bookList = new List<Book>(books);
        }
        public TreeNode TakeElementTree()
        {
            TreeNode name = new TreeNode(Name);
            name.Nodes.Add("Курс: " + Course);
            name.Nodes.Add("Семестр: " + Semestr);
            name.Nodes.Add("Специальность: " + specialization);
            name.Nodes.Add("Количество лекций: " + LecturesCount);
            name.Nodes.Add("Количество лаб: " + LabsCount);
            name.Nodes.Add("Вид контроля: " + ((pass == PassType.Exam) ? "экзамен" : "зачёт"));
            TreeNode Lector = new TreeNode("Лектор");
            TreeNode books = new TreeNode("Список литературы");
            Lector.Nodes.Add("Ф.И.О.: " + lector.snp);
            Lector.Nodes.Add("Кафедра: " + lector.pulpit);
            Lector.Nodes.Add("Аудитория: " + lector.WorkPlace);
            name.Nodes.Add(Lector);
            foreach(Book x in bookList)
                books.Nodes.Add(x.ToString());
            name.Nodes.Add(books);
            return name;
        }
    }
}
