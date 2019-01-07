using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Lab8
{
    interface InterfaceCollectionType<T>
    {
        void add(T element);
        void delete(T element);
        void show();
    }
    public class Engine
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
        public int Power => power;
        public int Year => year;
        public int Mass => mass;
        public override string ToString()
        {
            return "Двигатель:\n" +
                   "Мощность: " + power.ToString() + " лошадиных сил" +
                   "\nГод изготовления: " + year.ToString() + " год" +
                   "\nМасса: " + mass.ToString() + " кг";
        }
    };
    public class CollectionType<T> : InterfaceCollectionType<T> 
    {
        private List<T> field;
        private readonly Type type;
        private const int startindex = 10, lastindex = 20;
        private Owner owner = new Owner(-10, "", "");
        private Date date = new Date(-1, -1, -1);
        public class Owner
        {
            private int id;
            private string Name, Organization;
            public Owner(int _id, string _Name, string _Organization)
            {
                id = _id;
                Name = _Name;
                Organization = _Organization;
            }
            public Owner(Owner owner)
            {
                id = owner.id;
                Name = owner.Name;
                Organization = owner.Organization;
            }
            public string Data => "id: " + id.ToString() + "\nName: " + Name + "\nOrganization: " + Organization;
        }
        public class Date
        {
            private int day, month, year;
            public Date(int _day, int _month, int _year)
            {
                day = _day;
                month = _month;
                year = _year;
            }
            public Date(Date date)
            {
                day = date.day;
                month = date.month;
                year = date.year;
            }
            public string Data => "day: " + day.ToString()
                + "\nmonth: " + month.ToString()
                + "\nyear: " + year.ToString();
        }
        public int Count { get; private set; }
        public Owner SetOwner
        {
            get => owner;
            set => owner = new Owner(value);
        }
        public Date SetDate
        {
            get => date;
            set => date = new Date(value);
        }
        public T[] Arr
        {
            get => field.ToArray();
            set
            {
                Count = value.Length;
                field = new List<T>(value);
            }
        }
        public List<T> List
        {
            get => field;
            set
            {
                Count = value.Count;
                field = value;
            }
        }
        public CollectionType()
        {
            Count = 0;
            field = new List<T>();
            type = field.ToArray().GetType().GetElementType();
        }
        public CollectionType(T[] mas) : this()
        {
            type = field.ToArray().GetType().GetElementType();
            Count = mas.Length;
            field.InsertRange(0, mas);
        }
        public CollectionType(T[] mas, int id, string Name, string Organization) : this()
        {
            owner = new Owner(id, Name, Organization);
            type = field.ToArray().GetType().GetElementType();
            Count = mas.Length;
            field.InsertRange(0, mas);
        }
        public CollectionType(T[] mas, int id, string Name, string Organization, int day, int month, int year) : this()
        {
            owner = new Owner(id, Name, Organization);
            date = new Date(day, month, year);
            type = field.ToArray().GetType().GetElementType();
            Count = mas.Length;
            field.InsertRange(0, mas);
        }
        public void add(T element)
        {
            Count++;
            field.Add(element);
        }
        public void delete(T element)
        {
            if (Count == 0)
                WriteLine("Множество пустое");
            else if (field.IndexOf(element) == -1)
                WriteLine("Element not exist");
            else
            {
                field.Remove(element);
                Count--;
            }
        }
        public void show()
        {
            string str = "";
            T[] mas = field.ToArray();
            for (int i = 0; i < mas.Length; i++)
                str = str + mas[i].ToString() + ' ';
            WriteLine("Содержимое: ");
            WriteLine(str);
        }
        public static CollectionType<T> operator +(CollectionType<T> set, T elem)
        {
            set.field.Add(elem);
            return set;
        }
        public static CollectionType<T> operator +(CollectionType<T> set_1, CollectionType<T> set_2)
        {
            set_1.field.AddRange(set_2.field.ToArray());
            return set_1;
        }
        public static explicit operator int(CollectionType<T> set)
        { return set.Count; }
        public static bool operator false(CollectionType<T> set)
        {
            int index = (int)set;
            if ((index > lastindex) || (index < startindex))
                return false;
            else return true;
        }
        public static bool operator true(CollectionType<T> set)
        {
            int index = (int)set;
            if ((index <= lastindex) && (index >= startindex))
                return true;
            else return false;
        }
        public override string ToString()
        {
            string str = "";
            T[] mas = field.ToArray();
            for (int i = 0; i < mas.Length; i++)
                str = str + mas[i].ToString() + ' ';
            return str + '\n' + owner.Data + '\n' + date.Data;
        }
    }
    //public static class MathOperation
    //{
    //    public static int Max(CollectionType<int> set)
    //    {
    //        int[] arr = set.Arr;
    //        int max = arr[0];
    //        for (int i = 0; i < arr.Length; i++)
    //            if (arr[i] > max)
    //                max = arr[i];
    //        return max;
    //    }
    //    public static int Min(CollectionType<int> set)
    //    {
    //        int[] arr = set.Arr;
    //        int min = arr[0];
    //        for (int i = 0; i < arr.Length; i++)
    //            if (arr[i] < min)
    //                min = arr[i];
    //        return min;
    //    }
    //    public static int Count<T>(CollectionType<T> set) where T : struct
    //    { return (int)set; }
    //    public static void EditListofStrs(this CollectionType<string> set)
    //    {
    //        int j = 0;
    //        string[] arr = set.Arr;
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            j = 0;
    //            while (j < arr[i].Length)
    //            {
    //                if (arr[i][j].Equals(' ') == true)
    //                {
    //                    arr[i] = arr[i].Insert(j, ",");
    //                    j += 2;
    //                }
    //                else j++;
    //            }
    //        }
    //        set.Arr = arr;
    //    }
    //    public static void EditList<T>(this CollectionType<T> set)
    //    {
    //        List<T> list = set.List;
    //        list.Sort();
    //        T[] arr = list.ToArray();
    //        for (int i = arr.Length - 1; i > -1; i--)
    //            if (list.IndexOf(arr[i]) != i)
    //                list.Remove(arr[i]);
    //        set.List = new List<T>(list);
    //    }
    //}
    class Program
    {
        public static void Main()
        {
            //int[] mas1 = { 1, 2, 1, 3, 2, 1, 4, 4, 5, 6, 1, 7, 3, 10 },
            //    mas3 = { 9, 10, 11, 12, 13 };
            //string[] mas2 = { "Hi", "Hello", "World", "Hello World", "How are you?" };
            //CollectionType<int> elem1 = new CollectionType<int>(mas1);
            //CollectionType<int>.Owner owner_elem1 = new CollectionType<int>.Owner(0, "Admin", "OOP_Labs");
            //CollectionType<int>.Date date_elem1 = new CollectionType<int>.Date(1, 1, 2018);
            //elem1.SetOwner = owner_elem1;
            //elem1.SetDate = date_elem1;
            //CollectionType<string> elem2 = new CollectionType<string>(mas2, 1, "Evgen", "OOP_Labs");
            //CollectionType<int> elem3 = new CollectionType<int>(mas3, 2, "Evgen", "OOP_Labs", 2, 1, 2018);
            //WriteLine("elem1: " + elem1);
            //WriteLine("elem1 count: " + (int)elem1);
            //WriteLine("elem1 count: " + MathOperation.Count(elem1));
            //WriteLine("elem1 max element: " + MathOperation.Max(elem1));
            //WriteLine("elem1 min element: " + MathOperation.Min(elem1));
            //elem1 = elem1 + 9;
            //elem1 = elem1 + elem3;
            //if (elem1)
            //    WriteLine("Принадлежит промежутку 10-20: True");
            //else WriteLine("Принадлежит промежутку 10-20: False");
            //WriteLine("elem2: " + elem2);
            //if (elem2)
            //    WriteLine("Принадлежит промежутку 10-20: True");
            //else WriteLine("Принадлежит промежутку 10-20: False");
            //elem1.EditList();
            //elem2.EditListofStrs();
            //WriteLine("elem2: " + elem2);
            //WriteLine("elem1: " + elem1);
            //WriteLine("elem3: " + elem3);
            //elem1.add(5);
            //elem1.delete(11);
            //elem1.show();
            CollectionType<Engine> elem1 = new CollectionType<Engine>();
            elem1.delete(new Engine(900, 2000, 900));
            elem1.add(new Engine(500, 2000, 900));
            elem1.add(new Engine(700, 2003, 800));
            elem1.add(new Engine(700, 2007, 600));
            elem1.delete(new Engine(900, 2000, 900));
            elem1.show();
            elem1.delete(new Engine(700, 2003, 800));
            elem1.show();
            ReadKey();
        }
    }
}
