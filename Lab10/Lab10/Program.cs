using System;
using System.Collections.Specialized;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab10
{
    public class Student
    {
        public int value;
        public Student(int _value) => value = _value;
        public override string ToString() => value.ToString();
    }
    class Engine
    {
        private int power;
        private int year;
        private int mass;
        public Engine(int _power, int _year, int _mass)
        {
            power = _power;
            year = _year;
            mass = _mass;
        }
        public int Power
        {
            get => power;
            set => power = value;
        }
        public int Year => year;
        public int Mass => mass;
        public override string ToString()
        {
            return "Двигатель:\n" +
                   "Мощность: " + power.ToString() + " лошадиных сил" +
                   "\nГод изготовления: " + year.ToString() + " лет" +
                   "\nМасса: " + mass.ToString() + " кг";
        }

    }
    class Program
    { 
        public static void SomeAction(object sender, NotifyCollectionChangedEventArgs action)
        {
            WriteLine("Collection Changed.");
            WriteLine();
            WriteLine("Action: " + action.Action.ToString());
            WriteLine();
            WriteLine("Element: " + action.NewItems[0].ToString());
            WriteLine();
        }
        public static void Main()
        {
            //Random random = new Random(1);
            //ArrayList array = new ArrayList(100);
            //for (int i = 0; i < 5; i++)
            //    array.Add(random.Next());
            //array.Add("hello");
            //array.Add(new Student(6));
            //WriteLine("ArrayList count: " + array.Count.ToString());
            //WriteLine("ArrayList:");
            //for (int i = 0; i < array.Count; i++)
            //    WriteLine(array[i].ToString());
            //WriteLine();
            //WriteLine("0 - number");
            //WriteLine("1 - string");
            //WriteLine("other - nothing");
            //int k;
            //int value;
            //string str;
            //try { k = int.Parse(ReadLine()); }
            //catch { k = -1; }
            //if (k != -1)
            //{
            //    WriteLine("Element for Remove:");
            //    str = (k == 1) ? ReadLine() : "";
            //    if (int.TryParse(ReadLine(), out value))
            //        array.Remove(value);
            //    else array.Remove(str);
            //}
            //WriteLine();
            //WriteLine("ArrayList:");
            //for (int i = 0; i < array.Count; i++)
            //    WriteLine(array[i].ToString());
            //WriteLine();
            //WriteLine("0 - number");
            //WriteLine("1 - string");
            //WriteLine("other - nothing");
            //try { k = int.Parse(ReadLine()); }
            //catch { k = -1; }
            //if (k != -1)
            //{
            //    WriteLine("Element for Search:");
            //    str = (k == 1) ? ReadLine() : "";
            //    WriteLine();
            //    if (int.TryParse(ReadLine(), out value))
            //        WriteLine("Index:" + (array.IndexOf(value) + 1).ToString());
            //    else WriteLine("Index:" + (array.IndexOf(str) + 1).ToString());
            //}
            //WriteLine();
            //HashSet<long> hash = new HashSet<long>();
            //hash.Add(10);
            //hash.Add(8);
            //hash.Add(0);
            //hash.Add(1);
            //hash.Add(2);
            //hash.Add(3);
            //hash.Add(4);
            //hash.Add(9);
            //WriteLine("HashSet elements:");
            //foreach (long x in hash)
            //    WriteLine(x.ToString());
            //WriteLine("count of deleted consecutive elements:");
            //int n;
            //long[] arr = new long[hash.Count];
            //hash.CopyTo(arr);
            //hash.Clear();
            //int j = 0, _n = 1;
            //if (int.TryParse(ReadLine(), out n))
            //while ((_n != (n - 1))  && (j < arr.Length - 1))
            //{
            //    if (arr[j] + 1 == arr[j + 1])
            //    {
            //        if (((j > 0) && (arr[j - 1] + 1 == arr[j])) || (j <= 0))
            //            _n++;
            //        else _n = 1;
            //    }
            //    else
            //    if (arr[j] == arr[j + 1] + 1)
            //    {
            //        if (((j > 0) && (arr[j - 1] == arr[j] + 1)) || (j <= 0))
            //            _n++;
            //        else _n = 1;
            //    } else _n = 1;
            //    j++;
            //}
            //if (_n == n - 1)
            //    for (int i = j; i > (j - n); i--)
            //        arr[i] = -1;
            //for (int i = 0; i < arr.Length; i++)
            //    if (arr[i] != -1)
            //        hash.Add(arr[i]);
            //WriteLine("HashSet elements:");
            //foreach (long x in hash)
            //    WriteLine(x.ToString());
            //hash.Add(11);
            //hash.Add(12);
            //hash.Add(13);
            //hash.Add(14);
            //LinkedList<long> list = new LinkedList<long>(hash);
            //WriteLine();
            //WriteLine("LinkedList elements:");
            //foreach (long x in list)
            //    WriteLine(x.ToString());
            //WriteLine("element fo search:");
            //if (int.TryParse(ReadLine(), out value))
            //{
            //    LinkedListNode<long> list1 = list.Find(n);
            //    WriteLine("Value: " + list1.Value.ToString());
            //    WriteLine("Next: " + list1.Next.Value.ToString());
            //    WriteLine("Previous: " + list1.Previous.Value.ToString());
            //}

            HashSet<Engine> hash1 = new HashSet<Engine>();
            Engine engine = new Engine(5, 150, 320);
            hash1.Add(new Engine(1,100,200));
            hash1.Add(new Engine(10, 10, 200));
            hash1.Add(new Engine(0, 1000, 201));
            hash1.Add(new Engine(2, 110, 202));
            hash1.Add(new Engine(3, 102, 220));
            hash1.Add(new Engine(4, 200, 222));
            hash1.Add(engine);
            hash1.Add(new Engine(6, 190, 290));
            WriteLine("HashSet elements:");
            foreach (Engine x in hash1)
                WriteLine(x.ToString());
            WriteLine("count of deleted consecutive elements:");
            int n;
            Engine[] arr1 = new Engine[hash1.Count];
            hash1.CopyTo(arr1);
            hash1.Clear();
            int j = 0, _n = 1;
            if (int.TryParse(ReadLine(), out n))
                while ((_n != (n - 1)) && (j < arr1.Length - 1))
                {
                    if (arr1[j].Power + 1 == arr1[j + 1].Power)
                    {
                        if (((j > 0) && (arr1[j - 1].Power + 1 == arr1[j].Power)) || (j <= 0))
                            _n++;
                        else _n = 1;
                    }
                    else
                    if (arr1[j].Power == arr1[j + 1].Power + 1)
                    {
                        if (((j > 0) && (arr1[j - 1].Power == arr1[j].Power + 1)) || (j <= 0))
                            _n++;
                        else _n = 1;
                    }
                    else _n = 1;
                    j++;
                }
            if (_n == n - 1)
                for (int i = j; i > (j - n); i--)
                    arr1[i].Power = -1;
            for (int i = 0; i < arr1.Length; i++)
                if (arr1[i].Power != -1)
                    hash1.Add(arr1[i]);
            WriteLine("HashSet elements:");
            foreach (Engine x in hash1)
                WriteLine(x.ToString());
            hash1.Add(new Engine(11, 900, 800));
            hash1.Add(new Engine(12, 400, 600));
            hash1.Add(new Engine(13, 300, 400));
            hash1.Add(new Engine(2, 1200, 230));
            LinkedList<Engine> list1 = new LinkedList<Engine>(hash1);
            WriteLine();
            WriteLine("LinkedList elements:");
            foreach (Engine x in list1)
                WriteLine(x.ToString());
            WriteLine();
            //int power, year, mass;
            //WriteLine("power:");
            //read = int.TryParse(ReadLine(), out power);
            //WriteLine("year:");
            //read = int.TryParse(ReadLine(), out year);
            //WriteLine("mass:");
            //read = int.TryParse(ReadLine(), out mass);
            try
            {
                LinkedListNode<Engine> listnode = list1.Find(engine);
                WriteLine("Value: " + listnode.Value.ToString());
                WriteLine("Next: " + listnode.Next.Value.ToString());
                WriteLine("Previous: " + listnode.Previous.Value.ToString());
            }
            catch { WriteLine("Not found"); }
            ObservableCollection<Engine> engines = new ObservableCollection<Engine>();
            engines.CollectionChanged += new NotifyCollectionChangedEventHandler(SomeAction);
            engines.Add(new Engine(1, 100, 200));
            engines.Add(new Engine(10, 10, 200));
            engines.Add(new Engine(0, 1000, 201));
            engines.Add(new Engine(2, 110, 202));
            engines.Add(new Engine(3, 102, 220));
            engines.Add(new Engine(4, 200, 222));
            ReadKey();
        }
    }
}
