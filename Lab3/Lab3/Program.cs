using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Lab3
{
    internal partial class Bunch<T>
    {
        private readonly Type type;
        private bool security = true;
        private bool neg_elems = false;
        private static int counter_elems;
        private List<T> field;
        public const int Capacity = 100;
        public int Count { get; private set; }
        public Type Type { get => type; }
       }
    class Program
    { 
        public static void Main()
        {
            int index = 0;
            int x;
            int[] mas1 = { 1, 2, 3, 4, 5 },
                  mas2 = { 1, 1, -1, 1, 1 },
                  mas3 = { 1, -1 };
            string[] mas = { "Hello", "HI" };
            Bunch<string> elem0 = new Bunch<string>(mas);
            elem0.add(1, "abc");
            WriteLine("elem0:\n" + elem0.ToString());
            Bunch<int> elem1 = new Bunch<int>(mas1);
            Bunch<int> elem2 = new Bunch<int>(mas1);
            Bunch<int> elem3 = new Bunch<int>(mas3);
            WriteLine("elem1 = elem2: " + elem1.Equals(elem2).ToString());
            WriteLine("elem1:\n" + elem1.ToString());
            elem1.Security = false;
            elem1.add(0, 6);
            WriteLine("elem1:\n" + elem1.ToString());
            x = 5;
            elem1.delete(ref x, out index);
            WriteLine("elem1:\n" + elem1.ToString());
            WriteLine(index);
            WriteLine("elem1:\n" + elem1.ToString());
            WriteLine("elem1 = elem3: " + elem1.Equals(elem3).ToString());
            Bunch<int>[] elem4 = { elem1, elem2, elem3, new Bunch<int>(mas2) };
            for 
            WriteLine("elem4:\n" + elem4);
            double max = elem4[0].Sum, min = elem4[0].Sum;
            int max_i = 0, min_i = 0;
            Write("Множества содержащие отрицательные элементы: ");
            for (int i = 0; i < elem4.Length; i++)
            {
                if (elem4[i].Sum > max)
                {
                    max = elem4[i].Sum;
                    max_i = i;
                }
                if (elem4[i].Sum < min)
                {
                    min = elem4[i].Sum;
                    min_i = i;
                }
                if (elem4[i].Negative == true)
                    Write(i.ToString() + " ");
            }
            WriteLine();
            WriteLine("Номер множества с максимальной суммой: " + max_i.ToString() + '\n'
                    + "Номер множества с минимальной суммой: " + min_i.ToString());
            var elem5 = new { Count = mas1.Length, field = new List<int>(mas1) };
            Bunch<int>.Info();
            ReadKey();
        }
    }
}
