using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using static System.Console;
namespace Lab15
{
    public class Element
    {
        public void begin()
        {
            WriteLine("Имя потока: " + Thread.CurrentThread.Name);
            WriteLine("Приоритет потока: " + Thread.CurrentThread.Priority.ToString());
            WriteLine("Id потока: " + Thread.CurrentThread.ManagedThreadId.ToString());
            WriteLine("Статус потока: " + Thread.CurrentThread.ThreadState.ToString());
            int n;
            int.TryParse(ReadLine(), out n);
            EasyNumbers(n);
            WriteLine("Press key to continue");
            ReadKey();
        }
        public void EasyNumbers(int n)
        {
            StreamWriter fout = new StreamWriter("easynumbers.txt");
            bool flag;
            for (int i = 1; i < n + 1; i++)
            {
                flag = true;
                for (int j = i; j > 0; j--)
                    if ((i % j == 0) && (j != 1) && (j != i))
                    {
                        flag = false;
                        break;
                    }
                if (flag == true)
                {
                    fout.WriteLine(i.ToString());
                    WriteLine(i.ToString());
                }
            }
            fout.Close();
        }
    }
    public class Numbers
    {
        private int n;
        public StreamWriter file =  new StreamWriter("oddeven.txt", false);
        public Numbers()
        {
            ReadN();
        }
        ~Numbers()
        {
            try { file.Close(); }
            catch { };
        }
        private void ReadN()
        {
            bool flag;
            while (true)
            {
                flag = int.TryParse(ReadLine(), out n);
                if (flag == false)
                    WriteLine("Неверно введено значение. Введите снова");
                else break;
            }
        }
        public void ForTimer(object obj)
        {
            for (int i = 1; i < n; i++)
                Write('.');
            WriteLine();
        }
        public void Odd()
        {
            if (file.BaseStream == null)
                file = new StreamWriter("oddeven.txt", true);
            for (int i = 1; i < n; i++)
            {
                Thread.Sleep(30);
                if (i % 2 != 0)
                {
                    if (file.BaseStream == null)
                        file = new StreamWriter("oddeven.txt", true);
                    file.WriteLine(i);
                    WriteLine(i);
                }
            }
            if (file.BaseStream != null)
                file.Close();
        }
        public void Even()
        {
            lock (this)
            {
                for (int i = 1; i < n; i++)
                    if (i % 2 == 0)
                    {
                        if (file.BaseStream == null)
                            file = new StreamWriter("oddeven.txt", true);
                        file.WriteLine(i);
                        WriteLine(i);
                    }
                if (file.BaseStream != null)
                    file.Close();
            }
        }
        public void Odd1()
        {
            Monitor.Enter(this);
            {
                if (file.BaseStream == null)
                    file = new StreamWriter("oddeven.txt", true);
                for (int i = 1; i < n; i++)
                {
                    Thread.Sleep(5);
                    if (i % 2 != 0)
                    {
                        Monitor.Wait(this, 1);
                        if (file.BaseStream == null)
                            file = new StreamWriter("oddeven.txt", true);
                        file.WriteLine(i);
                        WriteLine(i);
                    }
                }
                if (file.BaseStream != null)
                    file.Close();
            }
        }
        public void Even1()
        {
            Monitor.Enter(this);
            {
                if (file.BaseStream == null)
                    file = new StreamWriter("oddeven.txt", true);
                for (int i = 1; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (file.BaseStream == null)
                            file = new StreamWriter("oddeven.txt", true);
                        file.WriteLine(i);
                        WriteLine(i);
                        Monitor.Wait(this, 6);
                    }
                }
                if (file.BaseStream != null)
                    file.Close();
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            Process[] proc = Process.GetProcesses();
            StreamWriter log1 = new StreamWriter("log1.txt", false);
            foreach (Process x in proc)
            {
                try
                {
                    WriteLine("Id процесса: " + x.Id.ToString());
                    log1.WriteLine("Id процесса: " + x.Id.ToString());
                    WriteLine("Имя процесса: " + x.ProcessName);
                    log1.WriteLine("Имя процесса: " + x.ProcessName);
                    WriteLine("Приоритет: " + x.BasePriority.ToString());
                    log1.WriteLine("Приоритет: " + x.BasePriority.ToString());
                    WriteLine("Время старта: " + x.StartTime.ToString());
                    log1.WriteLine("Время старта: " + x.StartTime.ToString());
                    WriteLine("Время затраты процессора: " + x.TotalProcessorTime.ToString());
                    log1.WriteLine("Время затраты процессора: " + x.TotalProcessorTime.ToString());
                    WriteLine();
                    log1.WriteLine();
                }
                catch
                {
                    log1.WriteLine();
                    WriteLine();
                }
            }
            AppDomain domain = AppDomain.CurrentDomain;
            WriteLine("" + domain.FriendlyName);
            WriteLine("" + domain.SetupInformation);
            WriteLine("");
            Assembly buf = null;
            foreach (Assembly x in domain.GetAssemblies())
            {
                if (x.GetName().Name == "Lab15")
                    buf = x;
                WriteLine(x.GetName().Name);
            }
            AppDomain mydomain = AppDomain.CreateDomain("my new domain");
            Assembly buf2 = mydomain.Load(buf.GetName());
            AppDomain.Unload(mydomain);
            WriteLine(buf2.ToString());
            Thread mythread = new Thread((new Element()).begin);
            mythread.Name = "\"Evgen\'s thread\"";
            mythread.Priority = ThreadPriority.Highest;
            mythread.Start();
            Thread thread1, thread2;
            Numbers numbers = new Numbers();
            thread1 = new Thread(numbers.Odd);
            thread2 = new Thread(numbers.Even);
            thread1.IsBackground = true;
            thread2.IsBackground = true;
            thread1.Priority = ThreadPriority.AboveNormal;
            thread1.Start();
            thread2.Start();
            Thread.Sleep(5000);
            Thread thread3 = new Thread(numbers.Odd1);
            Thread thread4 = new Thread(numbers.Even1);
            thread3.IsBackground = true;
            thread4.IsBackground = true;
            thread3.Priority = ThreadPriority.AboveNormal;
            thread3.Start();
            thread4.Start();
            TimerCallback a = new TimerCallback(numbers.ForTimer);
            Timer timer = new Timer(a, 10, 10000, 2000);
        }
    }
}
