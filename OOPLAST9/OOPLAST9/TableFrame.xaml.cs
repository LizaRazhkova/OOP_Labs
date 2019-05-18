using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace OOPLAST9
{
    /// <summary>
    /// Логика взаимодействия для TableFrame.xaml
    /// </summary>
    public partial class TableFrame : Page
    {
        public TableFrame()
        {
            InitializeComponent();
            using (MyBase db = new MyBase())
            {
                var t = db.USERS_LOG.FirstOrDefault();
                db.USERS_LOG.Load();
                TableGrid.ItemsSource = db.USERS_LOG.Local.ToList();
            }
        }
    }
}
