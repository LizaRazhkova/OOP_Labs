using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab9
{
    public delegate void Salary(int sum);
    public delegate void Working();
    public class Director
    {
        private event Salary ActionWithSalary;
        private event Working ActionWithWork;
        public void Fine(int x)
        {
            if (ActionWithSalary != null)
                ActionWithSalary(x);
        }
        public void Boost() => ActionWithWork?.Invoke();
        public Salary SalaryAction { get => ActionWithSalary; set => ActionWithSalary = value; }
        public Working WorkAction { get => ActionWithWork; set => ActionWithWork = value; }
    }
    public class Turners
    {
        private int count = 50;
        private int salary = 100;
        public void DirectorMessage(int x) => WriteLine("С зарпоаты будет вычтен штраф в размере " + x.ToString() + "$. Ожидаемая зарплата: " + (salary -= x).ToString() + "$");
        public void DirectorMessage() => WriteLine("Один из токарей получил повышение. Осталось работников: " + (--count).ToString());
    }
    public class PartTimeStudents
    {
        int count = 50;
        public void DirectorMessage() => WriteLine("Один из студентов получил квалификацию токаря. Осталось студентов: " + (--count).ToString()); 
    }
    class Program
    {
        public static void A(int x)
        {
            WriteLine(x.ToString());
        }
        public static string Delete1(string str)
        {
            int i = 0;
            while (i < str.Length)
            {
                if ((str[i] == '.') || (str[i] == ',') || (str[i] == ';') || (str[i] == ':') || (str[i] == '!') || (str[i] == '?') || (str[i] == '-'))
                    str = str.Remove(i, 1);
                else i++;
            }
            return str;
        }
        public static void Main()
        {
            Director director = new Director();
            Turners turners = new Turners();
            PartTimeStudents students = new PartTimeStudents();
            Salary salary = new Salary(A);
            salary += A;

            director.SalaryAction += new Salary(turners.DirectorMessage);
            director.WorkAction += new Working(turners.DirectorMessage);
            director.WorkAction += new Working(students.DirectorMessage);
            director.Fine(20);
            director.Boost();
            director.Boost();
            director.Fine(20);
            Func<string, string> action1 = new Func<string, string>(Delete1);
            Action<string, char> action2, action3;
            Func<string, string, string> action4;
            Func<string, int> action5;
            WriteLine(action1("Hello, World!?"));
            action2 = (string str, char symb) => WriteLine(str = str.Replace(symb, (char)(symb - 32)));
            action3 = (string str, char symb) => WriteLine(str = str.Replace(symb, (char)(symb + 32)));
            action4 = (string str1, string str2) => str1 + str2;
            action5 = (string str1) => str1.Length;
            action2("hello World", 'h');
            action3("Hello World", 'H');
            WriteLine(action4("Hello ", "World"));
            WriteLine(action5("Hello World"));
            ReadKey();
        }
    }
}
