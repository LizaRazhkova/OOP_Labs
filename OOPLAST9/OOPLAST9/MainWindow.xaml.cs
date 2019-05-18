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

namespace OOPLAST9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyFrame.Navigate(new TableFrame());
        }

        private void AddLector_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new AddFrame());
        }

        private void DeleteBut_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new DeleteFrame());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new EditFrame());
        }

        private void RefreshBut_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new TableFrame());
        }

        private void FindObj_Click(object sender, RoutedEventArgs e)
        {
            using(MyBase db = new MyBase())
            {
                var forDel = db.USERS_LOG.Where(p => p.UserLogID == 5);
                foreach(var f in forDel)
                {
                    MessageBox.Show(f.UserLogName);
                }
            }
        }
    }
}