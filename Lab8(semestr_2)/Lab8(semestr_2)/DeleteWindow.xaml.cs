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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Lab8_semestr_2_
{
    /// <summary>
    /// Логика взаимодействия для DeleteWindow.xaml
    /// </summary>
    public partial class DeleteWindow : Window
    {
        public DeleteWindow()
        {
            InitializeComponent();
        }
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (Discipline.IsChecked == true)
            {
                DisciplineName.Visibility = Visibility.Visible;
                SNP.Visibility = Visibility.Collapsed;
            }
            if (Lector.IsChecked == true)
            {
                DisciplineName.Visibility = Visibility.Collapsed;
                SNP.Visibility = Visibility.Visible;
            }
        }
        private void Delete_from_database(object sender, RoutedEventArgs e)
        {
            string expression = "DELETE FROM ";
            if (Discipline.IsChecked == true)
                expression += "Discipline WHERE ([Discipline name] = N\'" + DisciplineName.Text + "\')"; 
            if (Lector.IsChecked == true)
                expression += "Lector WHERE (Lector = N\'" + SNP.Text + "\')";
            MessageBox.Show(expression);
            App.OpenDBApp();
            SqlCommand command = new SqlCommand(expression, App.db);
            command.ExecuteNonQuery();
            App.CloseDBApp();
        }
    }
}
