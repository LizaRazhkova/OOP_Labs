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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace Lab4_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainField.AddHandler(DragOverEvent, new DragEventHandler(MainField_DragOver), true);
            MainField.AddHandler(DropEvent, new DragEventHandler(MainField_Drag), true);

        }

        private void MainField_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.All;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
            e.Handled = false;
        }

        private void MainField_Drag(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] docPath = (string[])e.Data.GetData(DataFormats.FileDrop);
                var dataFormat = DataFormats.Rtf;
                TextRange range;
                FileStream file;
                if (File.Exists(docPath[0]))
                {
                    try
                    {
                        range = new TextRange(MainField.Document.ContentStart, MainField.Document.ContentEnd);
                        using (file = new FileStream(docPath[0], FileMode.OpenOrCreate))
                        {
                            range.Load(file, dataFormat);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void SetFontSize(object sender, RoutedEventArgs e)
        {
            FontSizeValue.Text = ((int)Font_Size.Value).ToString();
            if (Font_Size.Value >= 1)
            MainField.FontSize = int.Parse(FontSizeValue.Text);
        }
        private void SetFont(object sender, RoutedEventArgs e) { MainField.FontFamily = (FontFamily)SelectFonts.SelectedItem; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Resources.Source = new Uri("D:/C#/OOP_Labs/Lab4-5/Lab4-5/Dictionary1.xaml");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Resources.Source = new Uri("D:/C#/OOP_Labs/Lab4-5/Lab4-5/Dictionary2.xaml");
        }
        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Rich Text File|*.rtf";
            if (dialog.ShowDialog() == true)
            {
                FileStream file = new FileStream(dialog.FileName, FileMode.Open);
                TextRange txt = new TextRange(MainField.Document.ContentStart, MainField.Document.ContentEnd);
                txt.Load(file, DataFormats.Rtf);
            }
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Rich Text File|*.rtf ";
            if (dialog.ShowDialog() == true)
            {
                FileStream file = new FileStream(dialog.FileName, FileMode.Create);

                TextRange txt = new TextRange(MainField.Document.ContentStart, MainField.Document.ContentEnd);

                txt.Save(file, DataFormats.Rtf);

            }
        }

        private void MainField_TextChanged(object sender, TextChangedEventArgs e)
        {
            CountLet.Text = "Count of letters: " + GetLenght();
        }
        private int GetLenght()
        {
            var textRange = new TextRange(MainField.Document.ContentStart, MainField.Document.ContentEnd);
            return textRange.Text.Length - 2;
        }
        private void CopyText_Click(object sender, RoutedEventArgs e)
        {
            MainField.Copy();
        }

        private void PasteText_Click(object sender, RoutedEventArgs e)
        {
            MainField.Paste();
        }

    }
}
