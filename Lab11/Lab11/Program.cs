using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Lab11
{
    class Program
    {

        public static void Main()
        {
            string[] months = { "January", "February",
                                "March", "April", "May",
                                "June", "July", "August",
                                "September", "October", "November", "December" };
            WriteLine("Length:");
            bool flag;
            int n;
            flag = int.TryParse(ReadLine(), out n);
            if (flag)
            {
                IEnumerable<string> result1 = from x in months where (x.Length == n) select x;
                foreach (string x in result1)
                    WriteLine(x);
                WriteLine();
            }
            WriteLine("Winter and Summer: ");
            IEnumerable<string> result2 = from x in months
                                          where ((x == "January") || (x == "February") || (x == "December") ||
                                                 (x == "June") || (x == "July") || (x == "August"))
                                          select x;
            foreach (string x in result2)
                WriteLine(x);
            WriteLine();
            WriteLine("Sort:");
            IEnumerable<string> result3 = from x in months orderby x select x;
            foreach (string x in result3)
                WriteLine(x);
            WriteLine();
            WriteLine("Contains u:");
            IEnumerable<string> result4 = from x in months where ((x.Contains("u") == true) && (x.Length >= 4)) select x;
            foreach (string x in result4)
                WriteLine(x);
            WriteLine();
            List<Bunch<int>> list = new List<Bunch<int>>(new[] { new Bunch<int>(new int[] { 1, 2, 3 }), new Bunch<int>(new int[] { 0, -2, 3 }), new Bunch<int>(new int[] { 1, 2, -3 }) });
            WriteLine("Elements:");
            foreach (Bunch<int> x in list)
                WriteLine(x.ToString());
            WriteLine();
            IEnumerable<double> sum = from x in list select x.Sum;
            WriteLine("Sum:");
            WriteLine("Max: " + sum.Max().ToString());
            WriteLine("Min: " + sum.Min().ToString());
            WriteLine();
            WriteLine("Contains negative elements:");
            IEnumerable<Bunch<int>> neglist = from x in list where x.Negative == true select x;
            foreach (Bunch<int> x in neglist)
                WriteLine(x.ToString());
            WriteLine();
            int a;
            WriteLine("Number for Search");
            flag = int.TryParse(ReadLine(), out a);
            if (flag == true)
            {
                WriteLine("Contains this number:");
                IEnumerable<Bunch<int>> search = from x in list where x.Search(a) != -1 select x;
                foreach (Bunch<int> x in search)
                    WriteLine(x.ToString());
                WriteLine();
            }
            WriteLine("Max count of elements:");
            IEnumerable<int> length = from x in list select x.Count;
            WriteLine(length.Max().ToString());
            WriteLine();
            WriteLine("Number for Search");
            flag = int.TryParse(ReadLine(), out a);
            if (flag == true)
            {
                WriteLine("First that contain this number:");
                IEnumerable<Bunch<int>> searchfirst = from x in list where x.Search(a) != -1 select x;
                WriteLine(searchfirst.First().ToString());
                WriteLine();
            }
            WriteLine("Sort by first number:");
            IEnumerable<Bunch<int>> sorted = from x in list orderby x.First select x;
            foreach (Bunch<int> x in sorted)
                WriteLine(x);
            WriteLine();
            WriteLine("Elements that value of first number isn't 0:");
            IEnumerable<Bunch<int>> expression = list.Where(x => x.First != 0);
            foreach (Bunch<int> x in expression)
                WriteLine(x);
            WriteLine();
            int[] b;
            WriteLine("Proection:");
            IEnumerable<int> proection = list.SelectMany(x => x.Array);
            foreach (int x in proection)
                WriteLine(x);
            WriteLine();
            WriteLine("Sort by sum:");
            IEnumerable<Bunch<int>> sorted1 = list.OrderBy(x => x.Sum).Select(x => x);
            foreach (Bunch<int> x in sorted1)
                WriteLine(x);
            WriteLine();
            WriteLine("Group by contains negative numbers:");
            IEnumerable<IGrouping<bool, Bunch<int>>> group = list.GroupBy(x => x.Negative);
            foreach (IGrouping<bool, Bunch<int>> x in group)
            {
                if (x.Key == true)
                    WriteLine("Contains negative elements:");
                else WriteLine("Not contains negative elements:");
                foreach (Bunch<int> element in x)
                    WriteLine(element.ToString());
            }
            WriteLine();
            WriteLine("Agregation:");
            List<Bunch<int>> list1 = new List<Bunch<int>>(new []{ new Bunch<int>(new int[] { 1, 2, 3 }), new Bunch<int>(new int[] { 0, -2, 3 }), new Bunch<int>(new int[] { 1, 2, -3 }) });
            Bunch<int> agregation = list.Aggregate((x, y) => x + y);
            WriteLine(agregation.ToString());
            WriteLine();
            WriteLine("Join:");
            double[] key = { 0, 1, 6 };
            var joined = list1.Join(key, x => x.Sum, q => q, (x, q) => new { id = x, name = q });
            foreach (var x in joined)
                WriteLine(x.name.ToString() + '\n' + x.id.ToString());
            WriteLine();
            ReadKey();
        }
    }
}
