using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Data;

namespace Lab8_semestr_2_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public class Discipline
    {
        public string Name;
        public int Term, Course;
        public string Specialization;
        public float LecturesCount, LabsCount;
        public string ControlType;
        public object Lector = null;
        public Discipline(string name, int term, int course, string spec, float lect, float labs, string control)
        {
            Name = name;
            Term = term;
            Course = course;
            Specialization = spec;
            LecturesCount = lect;
            LabsCount = labs;
            ControlType = control;
        }
    }
    public partial class MainWindow : Window
    {
        public ObservableCollection<Discipline> Disciplines { get; set; }
        public DataTable data;
        public MainWindow()
        {
            InitializeComponent();
            Disciplines = new ObservableCollection<Discipline>();
            App.OpenDBApp();
            string expression = "SELECT * FROM Discipline";
            SqlCommand command = new SqlCommand(expression, App.db);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            data = new DataTable("Discipline");
            adapter.Fill(data);
            DB_Discipline.ItemsSource = null;
            DB_Discipline.ItemsSource = data.DefaultView;
            string expression2 = "SELECT * FROM Lector";
            SqlCommand command2 = new SqlCommand(expression2, App.db);
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            data = new DataTable("Lector");
            adapter2.Fill(data);
            DB_Lector.ItemsSource = null;
            DB_Lector.ItemsSource = data.DefaultView;
            App.CloseDBApp();
        }
        public void Add_to_database(object sender, EventArgs eventArgs)
        {
            AddWindow window = new AddWindow();
            window.Show();
        }
        public void Delete_from_database(object sender, EventArgs eventArgs)
        {
            DeleteWindow window = new DeleteWindow();
            window.Show();
        }
        public void Refresh(object sender, EventArgs eventArgs)
        {
            App.OpenDBApp();
            string expression = "SELECT * FROM Discipline";
            SqlCommand command = new SqlCommand(expression, App.db);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            data = new DataTable("Discipline");
            adapter.Fill(data);
            DB_Discipline.ItemsSource = null;
            DB_Discipline.ItemsSource = data.DefaultView;
            string expression2 = "SELECT * FROM Lector";
            SqlCommand command2 = new SqlCommand(expression2, App.db);
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            data = new DataTable("Lector");
            adapter2.Fill(data);
            DB_Lector.ItemsSource = null;
            DB_Lector.ItemsSource = data.DefaultView;
            App.CloseDBApp();

        }
    }
}
