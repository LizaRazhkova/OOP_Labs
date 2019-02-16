using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool flag = false;
            // Application running in cycles was made for developers (catching exception that shouldn't restart application)
            // this method I will be use in next projects too
            while (true)
            {
                try
                {
                    Application.Run(new MainForm());
                    flag = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message + "\n\n" + error.StackTrace);
                    flag = false;
                }
                if (flag)
                    break;
            }
            flag = false;
            while (true)
            {
                try
                {
                    Application.Run(new Form2());
                    flag = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message + "\n\n" + error.StackTrace);
                    flag = false;
                }
                if (flag)
                    break;
            }
        }
    }
}
