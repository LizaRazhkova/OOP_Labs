using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Lab7_semestr_2_
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public class WindowCommands
    {
        static WindowCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.R, ModifierKeys.Control, "Ctrl + R"));
            Exit = new RoutedUICommand("Exit", "Exit", typeof(WindowCommands), inputs);
        }
        public static RoutedCommand Exit { get; set; }
    }

    public partial class App : Application
    {
    }
}
