using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12f
{
    class Program
    {
        public void Say(string str)
        {
            Console.WriteLine("Hello. Input: " + str);
        }
        public static void Main()
        {
            Program a = new Program();
            a.Say("hi");
        }
    }
}
