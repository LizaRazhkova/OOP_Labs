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
    /// Логика взаимодействия для EditFrame.xaml
    /// </summary>
    public partial class EditFrame : Page
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public EditFrame()
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                foreach(var u in unitOfWork._UsersLogUnits.ListOfLog.Where(x=>x.UserLogName == UserLastLog.Text))
                {
                    u.UserLogName = UserNewLog.Text;
                    u.UserLogPassword = UserNewPass.Text;
                    unitOfWork._UsersLogUnits._UsersLogContext.Entry(u).State = EntityState.Modified;
                }
                unitOfWork.Save();
                MessageBox.Show("Объект обновлён!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
