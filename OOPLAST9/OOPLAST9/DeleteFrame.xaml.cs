using OOPLAST9.Repository;
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
    /// Логика взаимодействия для DeleteFrame.xaml
    /// </summary>
    public partial class DeleteFrame : Page
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public DeleteFrame()
        {
            InitializeComponent();

            using (MyBase db = new MyBase())
            {
                unitOfWork._UsersInfoUnits.ListOfInfo = db.USERS_INFO.ToList();
                unitOfWork._UsersLogUnits.ListOfLog = db.USERS_LOG.ToList();
                var t = db.USERS_LOG.FirstOrDefault();
                db.USERS_LOG.Load();
                TableGrid.ItemsSource = db.USERS_LOG.Local.ToList();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

            using (MyBase db = new MyBase())
            {
                var log = unitOfWork._UsersLogUnits._UsersLogContext.USERS_LOG.Where(x => x.UserLogName == DeleteName.Text);
                foreach (var x in log)
                {
                    unitOfWork._UsersLogUnits._UsersLogContext.USERS_LOG.Remove(x);
                    
                }
                unitOfWork.Save();
                MessageBox.Show("Объект удалён!");
            }
        }
    }
}
