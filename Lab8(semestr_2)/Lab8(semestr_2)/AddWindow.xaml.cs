using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Lab8_semestr_2_
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private string ImagePath;
        public AddWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (Discipline.IsChecked == true)
            {
                DisciplineName.Visibility = Visibility.Visible;
                Term.Visibility = Visibility.Visible;
                Course.Visibility = Visibility.Visible;
                LecturesCount.Visibility = Visibility.Visible;
                LabsCount.Visibility = Visibility.Visible;
                Specialization.Visibility = Visibility.Visible;
                ControlType.Visibility = Visibility.Visible;
                SNP.Visibility = Visibility.Collapsed;
                Pulpit.Visibility = Visibility.Collapsed;
                Auditory.Visibility = Visibility.Collapsed;
                Photo.Visibility = Visibility.Collapsed;
            }
            if (Lector.IsChecked == true)
            {
                DisciplineName.Visibility = Visibility.Collapsed;
                Term.Visibility = Visibility.Collapsed;
                Course.Visibility = Visibility.Collapsed;
                LecturesCount.Visibility = Visibility.Collapsed;
                LabsCount.Visibility = Visibility.Collapsed;
                Specialization.Visibility = Visibility.Collapsed;
                ControlType.Visibility = Visibility.Collapsed;
                SNP.Visibility = Visibility.Visible;
                Pulpit.Visibility = Visibility.Visible;
                Auditory.Visibility = Visibility.Visible;
                Photo.Visibility = Visibility.Visible;
            }
        }
        private void Add_to_database(object sender, RoutedEventArgs e)
        {
            string expression = "INSERT INTO ";
            if (Discipline.IsChecked == true)
            {
                expression += "Discipline([Discipline Name], Term, Course, Specialization, [Count of lectures in term]," +
                    " [Count of labs in term], [Control Type], Lector) VALUES(N\'" + DisciplineName.Text + "\', " + Term.Text
                    + ", " + Course.Text + ", ";
                if (Specialization.Text == "POIT")
                    expression += "1, ";
                if (Specialization.Text == "POIBMS")
                    expression += "2, ";
                if (Specialization.Text == "ISIT")
                    expression += "3, ";
                if (Specialization.Text == "DEVI")
                    expression += "4, ";
                expression += LecturesCount.Value.ToString() + ", " + LabsCount.Value.ToString() + ", ";
                if (ControlType.Text == "exam")
                    expression += "1, ";
                else expression += "0, ";
                expression += "NULL)";
            }
            if (Lector.IsChecked == true)
            {
                expression += "Lector(Lector, Pulpit, Auditory, Photo) VALUES(N\'" + SNP.Text + "\', N\'" + Pulpit.Text
                   + "\', N\'" + Auditory.Text + "\', ";
                if (Photo.Source == null)
                    expression += "NULL)";
                else expression += "(SELECT BulkColumn FROM Openrowset (Bulk \'" + ImagePath + "\', Single_Blob) as Image))";
            }
            MessageBox.Show(expression);
            App.OpenDBApp();
            SqlCommand command = new SqlCommand(expression, App.db);
            command.ExecuteNonQuery();
            App.CloseDBApp();
        }
        private void Set_Image(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image|*.png";
            if (dialog.ShowDialog() == true)
            {
                ImageSourceConverter converter = new ImageSourceConverter();
                Photo.Source = (ImageSource)converter.ConvertFrom(dialog.FileName);
                ImagePath = dialog.FileName;
            }
        }
    }
}
