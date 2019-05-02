using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;

namespace Lab8_semestr_2_
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static SqlConnection db;
        public static void OpenDBApp()
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            db.Open();

        }
        public static void CloseDBApp()
        {
            db.Close();
        }
    }
}
