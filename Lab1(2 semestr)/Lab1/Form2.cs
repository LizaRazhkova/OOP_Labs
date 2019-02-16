using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form2 : Form
    {
        public List<int> marks;
        public delegate bool Comparator<T>(T x, T y);
        public void Sort<T>(List<T> list, Comparator<T> comparator)
        {
            T[] arr = list.ToArray();
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (comparator.Invoke(arr[i], arr[j]))
                    {
                        T buf = arr[i];
                        arr[i] = arr[j];
                        arr[j] = buf;
                    }
            list.Clear();
            list.AddRange(arr);
        }
        public Form2()
        {
            InitializeComponent();
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();
                int x = 0;
                GeneratedList.Items.Clear();
                marks = new List<int>(int.Parse(LengthCollection.Text));
                for (int i = 0; i < int.Parse(LengthCollection.Text); i++)
                {
                    x = -4 + rand.Next() % 15;
                    if (x >= 0)
                        GeneratedList.Items.Add("Оценка: " + x.ToString() + '\n');
                    else GeneratedList.Items.Add("Оценка: NaN\n");
                    marks.Add(x);
                    x = 0;
                }   
            }
            catch { MessageBox.Show("Неверно задана длинна генерируемой коллекции"); }
            
        }

        private void GoodPass_Click(object sender, EventArgs e)
        {
            OutputList.Items.Clear();
            try
            {
                var result = marks.Where((x) => x >= 4).Select((x) => x);
                int[] buffer = result.ToArray();
                for (int i = 0; i < buffer.Length; i++)
                    if (buffer[i] >= 0)
                        OutputList.Items.Add("Оценка: " + buffer[i].ToString() + '\n');
                    else OutputList.Items.Add("Оценка: NaN\n");
            }
            catch (Exception error)
            {
                if (GeneratedList.Items == null)
                    MessageBox.Show("Вы не сгенерировали значения");
                else MessageBox.Show(error.Message);
            }
        }

        private void BadPass_Click(object sender, EventArgs e)
        {
            OutputList.Items.Clear();
            try
            {
                var result = marks.Where((x) => x < 4 && x >= 0).Select((x) => x);
                int[] buffer = result.ToArray();
                for (int i = 0; i < buffer.Length; i++)
                    if (buffer[i] >= 0)
                        OutputList.Items.Add("Оценка: " + buffer[i].ToString() + '\n');
                    else OutputList.Items.Add("Оценка: NaN\n");
            }
            catch (Exception error)
            {
                if (GeneratedList.Items == null)
                    MessageBox.Show("Вы не сгенерировали значения");
                else MessageBox.Show(error.Message);
            }
        }

        private void NoPass_Click(object sender, EventArgs e)
        {
            OutputList.Items.Clear();
            try
            {
                var result = marks.Where((x) => x < 0).Select((x) => x);
                int[] buffer = result.ToArray();
                for (int i = 0; i < buffer.Length; i++)
                    if (buffer[i] >= 0)
                        OutputList.Items.Add("Оценка: " + buffer[i].ToString() + '\n');
                    else OutputList.Items.Add("Оценка: NaN\n");
            }
            catch (Exception error)
            {
                if (GeneratedList.Items == null)
                    MessageBox.Show("Вы не сгенерировали значения");
                else MessageBox.Show(error.Message);
            }
        }

        private void DownSort_Click(object sender, EventArgs e)
        {
            OutputList.Items.Clear();
            try
            {
                Sort(marks, (x, y) => x < y);
                int[] buffer = marks.ToArray();
                for (int i = 0; i < buffer.Length; i++)
                    if (buffer[i] >= 0)
                        OutputList.Items.Add("Оценка: " + buffer[i].ToString() + '\n');
                    else OutputList.Items.Add("Оценка: NaN\n");
            }
            catch (Exception error)
            {
                if (GeneratedList.Items == null)
                    MessageBox.Show("Вы не сгенерировали значение");
                else MessageBox.Show(error.Message);
            }
        }

        private void UpSort_Click(object sender, EventArgs e)
        {
            OutputList.Items.Clear();
            try
            {
                Sort(marks, (x, y) => x > y);
                int[] buffer = marks.ToArray();
                for (int i = 0; i < buffer.Length; i++)
                    if (buffer[i] >= 0)
                        OutputList.Items.Add("Оценка: " + buffer[i].ToString() + '\n');
                    else OutputList.Items.Add("Оценка: NaN\n");
            }
            catch (Exception error)
            {
                if (GeneratedList.Items == null)
                    MessageBox.Show("Вы не сгенерировали значения");
                else MessageBox.Show(error.Message);
            }
        }
    }
}
