using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace Lab16
{
    class Program
    {
        public static Task task1;
        public static BlockingCollection<string> block;
        public static void EasyNumbersIrato()
        {
            WriteLine("Current task ID: " + Task.CurrentId.ToString());
            WriteLine("Task Completed: " + task1.IsCompleted.ToString());
            WriteLine("Status: " + task1.Status.ToString());
            int i, j, n = 100;
            int[] mas = new int[n];
            for (i = 0; i < n; i++)
                mas[i] = i + 1;
            for (i = 1; i < n - 1; i++)
                if (mas[i] != -1)
                    for (j = i + 1; j < n; j++)
                        if ((mas[j] != -1) && (mas[j] % mas[i] == 0))
                            mas[j] = -1;
            for (i = 0; i < n; i++)
                if (mas[i] != -1)
                    WriteLine(mas[i]);
        }
        public static int Rand10()
        {
            Random rand = new Random();
            return rand.Next(10);
        }
        public static int Rand20()
        {
            Random rand = new Random();
            return rand.Next(20);
        }
        public static int Rand30()
        {
            Random rand = new Random();
            return rand.Next(30);
        }
        public static int Avg(int value1, int value2, int value3)
        { return (value1 + value2 + value3) / 3; }
        public static void Adding()
        {
            Random r = new Random();
            int x;
            List<string> products = new List<string>() { "Микроволновка", "Холодильник", "Мультиварка", "Пылесос", "Плита" };
            for (int i = 0; i < 5; i++)
            {
                x = r.Next(0, products.Count - 1);
                WriteLine("Добавлен товар: " + products[x]);
                block.Add(products[x]);
                products.RemoveAt(x);
                Thread.Sleep(r.Next(1, 3));
            }
            block.CompleteAdding();
        }
        public static void Selling()
        {
            string str;
            while (block.IsAddingCompleted == false)
            {
                if (block.TryTake(out str) == true)
                    WriteLine("Был куплен товар: " + str);
                else WriteLine("Покупатель ушел");
            }
        }
        public static void ForAsync()
        {
            for (int i = 0; i < 100; i++)
                if (i % 3 == 0)
                {
                    Write(i + ", ");
                    Thread.Sleep(1000);
                }
        }
        public static async void Async()
        {
            WriteLine("Async function start:");
            await Task.Run(() => ForAsync());
            WriteLine("Async function completed");
        }

        public static void Main()
        {
            WriteLine("Задание 1");
            Action action1 = new Action(EasyNumbersIrato);
            task1 = Task.Factory.StartNew(action1);
            task1.Wait();
            task1.Dispose();
            Stopwatch watch = Stopwatch.StartNew();
            task1 = Task.Factory.StartNew(action1);
            task1.Wait();
            task1.Dispose();
            watch.Stop();
            WriteLine("Time for task: " + watch.Elapsed.ToString());
            watch = Stopwatch.StartNew();
            task1 = Task.Factory.StartNew(action1);
            task1.Wait();
            task1.Dispose();
            watch.Stop();
            WriteLine("Time for task: " + watch.Elapsed.ToString());
            watch = Stopwatch.StartNew();
            task1 = Task.Factory.StartNew(action1);
            task1.Wait();
            task1.Dispose();
            watch.Stop();
            WriteLine("Time for task: " + watch.Elapsed.ToString());
            WriteLine("Задание 2");
            CancellationTokenSource token = new CancellationTokenSource();
            (task1 = new Task(action1, token.Token)).Start();
            token.Cancel();
            WriteLine("Задание 3");
            Task<int> rand1 = new Task<int>(Rand10),
                      rand2 = new Task<int>(Rand20),
                      rand3 = new Task<int>(Rand30);
            rand1.Start();
            WriteLine("First Value: " + rand1.Result);
            rand2.Start();
            WriteLine("Second Value: " + rand2.Result);
            rand3.Start();
            WriteLine("Third Value: " + rand3.Result);
            Task<int> avg = new Task<int>(() => Avg(rand1.Result, rand2.Result, rand3.Result));
            avg.Start();
            WriteLine("Average: " + avg.Result);
            WriteLine("Задание 4");
            WriteLine("Continue with chain:");
            Task<int> chain1 = new Task<int>(Rand10);
            Task<int> chain2 = chain1.ContinueWith((task) => Rand20());
            Task<int> chain3 = chain2.ContinueWith((task) => Rand30());
            Task<int> chain4 = chain3.ContinueWith((task) => Avg(chain1.Result, chain2.Result, chain3.Result));                                                        // Task.WhenAll(chain1, chain2, chain3).ContinueWith
            chain1.Start();
            WriteLine("First Value: " + chain1.Result);
            WriteLine("Second Value: " + chain2.Result);
            WriteLine("Third Value: " + chain3.Result);
            WriteLine("Average: " + chain4.Result);
            chain1.Dispose();
            chain2.Dispose();
            chain3.Dispose();
            chain4.Dispose();
            WriteLine("Awaiter chain: ");
            chain1 = new Task<int>(Rand10);
            chain2 = new Task<int>(Rand20);
            chain3 = new Task<int>(Rand30);
            chain4 = new Task<int>(() => Avg(chain1.Result, chain2.Result, chain3.Result));
            chain1.GetAwaiter().OnCompleted(() =>
            {
                WriteLine("First Value: " + chain1.Result);
                chain2.Start();
            });
            chain2.GetAwaiter().OnCompleted(() =>
            {
                WriteLine("Second Value: " + chain2.Result);
                chain3.Start();
            });
            chain3.GetAwaiter().OnCompleted(() =>
            {
                WriteLine("Third Value: " + chain3.Result);
                chain4.Start();
            });
            chain4.GetAwaiter().OnCompleted(() => WriteLine("Average: " + chain4.Result));
            chain1.Start();
            WriteLine("Задание 5");
            Stopwatch st = new Stopwatch();
            int[] arr1 = new int[1000000];
            int[] arr2 = new int[1000000];
            Random random = new Random();
            st.Restart();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = random.Next(0, 300);
                arr2[i] = random.Next(0, 300);
            }
            st.Stop();
            WriteLine("for: " + st.Elapsed.ToString());
            st.Restart();
            Parallel.For(0, arr1.Length, i =>
            {
                arr1[i] = random.Next(0, 300);
                arr2[i] = random.Next(0, 300);
            });
            st.Stop();
            WriteLine("ParallelFor: " + st.Elapsed.ToString());
            st.Restart();
            Parallel.ForEach<int>(arr1, i =>
            {
                arr1[i] = random.Next(0, 300);
                arr2[i] = random.Next(0, 300);
            });
            st.Stop();
            WriteLine("ParallelForEach: " + st.Elapsed.ToString());
            WriteLine("Задание 6");
            Parallel.Invoke(() =>
            {
                for (int i = 0; i < 19; i++)
                    WriteLine("perallel1 " + i);
                WriteLine("perallel1 completed");
            }, 
            () =>
            {
                for (int i = 0; i < 10; i++)
                    WriteLine("perallel2 " + i);
                WriteLine("perallel2 completed");
            });
            WriteLine("Задание 7");
            block = new BlockingCollection<string>(5);
            Task ShopWorkers = new Task(Adding);
            Task Clients = new Task(Selling);
            ShopWorkers.Start();
            Clients.Start();
            Task.WaitAll(ShopWorkers, Clients);
            WriteLine("Задание 8");
            Async();
            string p = ReadLine();
            ReadKey();
        }
    }
}
