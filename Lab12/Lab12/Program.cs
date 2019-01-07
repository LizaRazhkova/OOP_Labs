using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using static System.Console;
namespace Lab12
{
    public class Test
    {
        public void Test1(int a, int b)
        {
            WriteLine((a + b).ToString());
        }
    }
    public class CollectionType<T>
    {
        private List<T> field;
        private readonly Type type;
        private const int startindex = 10, lastindex = 20;
        private Owner owner = new Owner(-1, "", "");
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
    }
    public class Reflector
    {
        public void inFile(Type type)
        {
            StreamWriter writer = new StreamWriter("TypeInfo.txt", false);
            writer.WriteLine("Full Name: " + type.FullName);
            writer.WriteLine("Base Type: " + type.BaseType);
            writer.WriteLine("Is sealed: " + type.IsSealed);
            writer.WriteLine("Is class = " + type.IsClass);
            foreach (Type iType in type.GetInterfaces())
                writer.WriteLine("Interface: " + iType.Name);
            foreach (FieldInfo fi in type.GetFields())
                writer.WriteLine("Field: " + fi.Name);
            writer.Close();
        }
        public void GetMethods(Type type)
        {
            WriteLine(type.ToString() + " contains methods:");
            foreach (MethodInfo x in type.GetMethods())
            {
                WriteLine("\tName: " + x.Name);
                WriteLine("\tReturn type: " + x.ReturnType);
                WriteLine("\tDeclaring class: " + x.DeclaringType);
                WriteLine();
            }
        }
        public void GetData(Type type)
        {
            WriteLine(type.ToString() + " contains data:");
            foreach (PropertyInfo x in type.GetProperties())
            {
                WriteLine("\tName: " + x.Name);
                WriteLine("\tProperty Type: " + x.PropertyType);
                WriteLine("\tDeclaring class: " + x.DeclaringType);
                WriteLine();
            }
            foreach (FieldInfo x in type.GetFields())
            {
                WriteLine("\tName: " + x.Name);
                WriteLine("\tField Type: " + x.FieldType);
                WriteLine("\tDeclaring class: " + x.DeclaringType);
                WriteLine();
            }
        }
        public void GetInterfaces(Type type)
        {
            WriteLine(type.ToString() + " contains interfaces:");
            foreach (Type iType in type.GetInterfaces())
                WriteLine('\t' + iType.Name);
        }
        public void SearchMethods(Type type)
        {
            WriteLine("Write type of parameter:");
            string str = ReadLine();
            Type parameter = Type.GetType("System." + str);
            if (parameter == null)
                parameter = Type.GetType("Lab12." + str);
            if (parameter != null)
            {
                bool flag = false;
                WriteLine(type.ToString() + " contains methods with this parameter:");
                foreach (MethodInfo x in type.GetMethods().Where(y => (y.GetParameters().Count() > 0) && (y.GetParameters().Any(x => x.ParameterType == parameter))))
                {
                    WriteLine("\tName: " + x.Name);
                    WriteLine("\tReturn type: " + x.ReturnType);
                    WriteLine("\tDeclaring class: " + x.DeclaringType);
                    WriteLine();
                    flag = true;
                }
                if (flag == false)
                    WriteLine("Nothing");
            }
            else WriteLine("This type not exist");
        }
        public void CallMethod(Type type, string path)
        {
            StreamReader fin = new StreamReader(path, true);
            object _class = type.GetConstructor(Type.EmptyTypes).Invoke(null);
            object[] parms = new object[type.GetMethod("Test1").GetParameters().Count()];
            int i = -1;
            while (fin.EndOfStream == false)
                parms[++i] = int.Parse(fin.ReadLine());
            type.GetMethod("Test1").Invoke(_class, parms);
            fin.Close();
        }
        public void A(CollectionType<int> obj)
        { }
    }
    class Program
    {
        public static void Main()
        {
            Reflector reflector = new Reflector();
            reflector.inFile(typeof(CollectionType<int>));
            reflector.GetMethods(reflector.GetType());
            reflector.GetData(typeof(CollectionType<int>));
            reflector.GetInterfaces(typeof(CollectionType<int>));
            reflector.SearchMethods(reflector.GetType());
            reflector.CallMethod(typeof(Test), "input.txt");
            ReadKey();
        }
    }
}
