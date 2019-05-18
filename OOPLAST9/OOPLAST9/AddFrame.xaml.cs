using OOPLAST9.Repository;
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

namespace OOPLAST9
{
    /// <summary>
    /// Логика взаимодействия для AddFrame.xaml
    /// </summary>
    public partial class AddFrame : Page
    {
        private UnitOfWork unitOfWork = new UnitOfWork(); 
        public AddFrame()
        {
            InitializeComponent();
            using(MyBase db = new MyBase())
            {
                unitOfWork._UsersInfoUnits.ListOfInfo = db.USERS_INFO.ToList();
                unitOfWork._UsersLogUnits.ListOfLog = db.USERS_LOG.ToList();
                db.SaveChanges();
            }

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                using (MyBase db = new MyBase())
                {

                    USERS_LOG lec = new USERS_LOG();
                    lec.UserLogName = PulpitName.Text;
                    lec.UserLogPassword = AuditoriumName.Text;
                    unitOfWork._UsersLogUnits._UsersLogContext.USERS_LOG.Add(lec);
                    unitOfWork.Save();
                    MessageBox.Show("Успешно добавлено!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
