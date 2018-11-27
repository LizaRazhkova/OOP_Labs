using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace Lab7
{
    interface OfficeCarsInterface
    {
        void ThisCarsIs();
    }
    abstract class Vehicle
    {
        private string category;
        private int mass;
        protected string Category
        {
            get => category;
            set => category = value;
        }
        protected int Mass
        {
            get => mass;
            set => mass = value;
        }
        public abstract void ThisCarsIs();
    }
    class OfficeCars : Vehicle, OfficeCarsInterface
    {
        protected string cars_brand;
        private int count_cars;
        public OfficeCars()
        {
            cars_brand = "";
            count_cars = 0;
        }
        public OfficeCars(string _cars_brand, string _category, int _mass, int _count_cars)
        {
            cars_brand = _cars_brand ?? throw new CreatingClassException(this, cars_brand.GetType());
            count_cars = (_count_cars < 0) ? throw new CreatingClassException(this, _count_cars.GetType()) : _count_cars;
            Category = _category ?? throw new CreatingClassException(this, Category.GetType());
            Mass = (_mass < 0) ? throw new CreatingClassException(this, _mass.GetType()) : _mass;
        }
        void OfficeCarsInterface.ThisCarsIs()
        { WriteLine(Category); }
        public override void ThisCarsIs()
        { WriteLine("Поставляемый тип авто: " + Category); }
        public override int GetHashCode()
        {
            int sum = 269;
            sum += cars_brand.GetHashCode();
            sum += count_cars.GetHashCode();
            sum += Category.GetHashCode();
            sum += Mass.GetHashCode();
            return sum;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;
            if (obj.GetHashCode() != GetHashCode())
                return false;
            return true;
        }
        public override string ToString()
        {
            return "Управление авто(сервис)\n" +
                   "Категория авто: " + Category +
                   "\nМарка автомобилей: " + cars_brand +
                   "\nСредняя масса авто: " + Mass.ToString() + " кг" +
                   "\nКоличество автомобилей: " + count_cars.ToString();
        }
    }
    interface CarInterface
    {
        string Brand { get; }
        string Model { get; }
        int Year { get; }
        Engine Engine { get; }
        void GetCarMark(out string mark);
    }
    sealed class Car : OfficeCars, CarInterface
    {
        private string model;
        private int year;
        private Engine engine;
        public Car()
        {
            Category = "";
            cars_brand = "";
            model = "";
            year = -1;
            Mass = -1;
            engine = new Engine(0, 0, 0);
        }
        public Car(string _category, string _car_brand, string _model, int _year, int _mass, int _powerEngine, int _yearEngine, int _massEngine)
        {
            Category = _category ?? throw new CreatingClassException(this, Category.GetType());
            cars_brand = _car_brand ?? throw new CreatingClassException(this, cars_brand.GetType());
            model = _model ?? throw new CreatingClassException(this, model.GetType());
            year = (_year < 0) ? throw new CreatingClassException(this, year.GetType()) : _year;
            Mass = (_mass < 0) ? throw new CreatingClassException(this, Mass.GetType()) : _mass;
            engine = new Engine(_powerEngine, _yearEngine, _massEngine);
        }
        public string Brand => cars_brand;
        public string Model => model;
        public int Year => year;
        public Engine Engine => engine;
        public void GetCarMark(out string mark) { mark = Brand + ' ' + Model; }
        public override string ToString()
        {
            return "Машина:\n" +
                   "Категория авто: " + Category +
                   "\nМарка автомобиля: " + cars_brand +
                   "\nМодель: " + model +
                   "\nГод изготовления: " + year.ToString() +
                   "\nВес: " + Mass.ToString() + " кг" +
                   '\n' + engine.ToString();
        }
    }
    class Engine
    {
        private int power;
        private int year;
        private int mass;
        public Engine(int _power, int _year, int _mass)
        {
            power = (_power < 0) ? throw new CreatingClassException(this, _power.GetType()) : _power;
            year = (_year < 0) ? throw new CreatingClassException(this, _year.GetType()) : _year;
            mass = (_mass < 0) ? throw new CreatingClassException(this, _mass.GetType()) : _mass;
        }
        public int Power => power;
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
    abstract class IntelligentCreature
    {
        private int lifelength;
        protected int LifeLength
        {
            get => lifelength;
            set => lifelength = value;
        }
    }
    partial class Human : IntelligentCreature
    {
        private enum HumanSex
        {
            Man = 1,
            Woman = 2
        };
        private struct Birthday
        {
            public int day;
            public int month;
            public int year;
            public Birthday(int _day, int _month, int _year)
            {
                day = _day;
                month = _month;
                year = _year;
            }
        };
        private Birthday date;
        private HumanSex sex;
        private int age;
        private int height;
        private string name;
    }
    interface TransformerInterface
    {
        string CarName { get; }
        string Name { get; }
        int IQ { get; }
        int Age { get; }
        int EnginePower { get; }
        void GetMainInfo(out string carname, out int IQ, out int age);
    }
    class Transformer : TransformerInterface
    {
        private Human carhuman = new Human();
        private Car carmodel = new Car();
        public Transformer(Car _car, int _age, int _height, string _name)
        {
            carhuman = new Human(0, _age, _height, _name);
            carmodel = _car ?? throw new CreatingClassException(this, carmodel.GetType());
        }
        public Transformer(Car _car, int _age, int _height, string _name, int _day, int _month, int _year)
        {
            carhuman = new Human(0, _age, _height, _name, _day, _month, _year);
            carmodel = _car ?? throw new CreatingClassException(this, carmodel.GetType());
        }
        public string CarName
        {
            get
            {
                string str;
                carmodel.GetCarMark(out str);
                return str;
            }
        }
        public int Day => carhuman.Day;
        public int Month => carhuman.Month;
        public int Year => carhuman.Year;
        public string Name => carhuman.Name;
        public int IQ => carmodel.Engine.Power / 100 * 5;
        public int Age => carhuman.Age;
        public int EnginePower => carmodel.Engine.Power;
        public void GetMainInfo(out string carname, out int IQ, out int age)
        {
            carmodel.GetCarMark(out carname);
            carname = carhuman.Name + carname;
            IQ = carmodel.Engine.Power / 100 * 5;
            age = carhuman.Age;
        }
        public override string ToString()
        {
            return "Трансформер\n" + carmodel.ToString() +
                   "\nIQ: " + (carmodel.Engine.Power / 100 * 5).ToString() +
                   "\nИмя(человеко-подобное): " + carhuman.Name +
                   "\nВозвраст: " + carhuman.Age.ToString() + " лет" +
                   "\nРост: " + carhuman.Height.ToString() + " cм" +
                   "\nГод рождения: " + carhuman.BirthDate();
        }
    }
    class Army
    {
        private List<object> units = new List<object>();
        public int Count => units.Count;
        public List<object> ListofUnits
        {
            get => units;
            set => units = value;
        }
        public void Add(Human human)
        {
            object x = human;
            units.Add(x);
        }
        public void Add(Transformer transformer)
        {
            object x = transformer;
            units.Add(x);
        }
        public void Remove(Human human)
        {
            object x = human;
            units.Remove(x);
        }
        public void Remove(Transformer transformer)
        {
            object x = transformer;
            units.Remove(x);
        }
        public void ToConsole()
        {
            object[] arr = units.ToArray();
            for (int i = 0; i < arr.Length; i++)
                WriteLine((i + 1).ToString() + ' ' + arr[i].ToString() + '\n');
        }
    }
    static class ArmyStatistic
    {
        public static object SearchBirthDate(this Army army, int day, int month, int year)
        {
            WriteLine("Searching unit with birthday date " + day + ':' + month + ':' + year + "...");
            bool flag = false;
            object[] arr = army.ListofUnits.ToArray();
            for (int i = 0; i < arr.Length; i++)
                if (arr[i].GetType().ToString() == "Lab6.Transformer")
                {
                    Transformer transformer = arr[i] as Transformer;
                    if ((transformer.Day == day) && (transformer.Month == month) && (transformer.Year == year))
                        return arr[i];
                }
                else
                {
                    Human human = arr[i] as Human;
                    if ((human.Day == day) && (human.Month == month) && (human.Year == year))
                        return arr[i];
                }
            if (flag == false)
                WriteLine("Nothing");
            return "";
        }
        public static void SearchEnginePower(this Army army, int power)
        {
            WriteLine("Searching transformer with engine power " + power.ToString() + "...");
            bool flag = false;
            object[] arr = army.ListofUnits.ToArray();
            for (int i = 0; i < arr.Length; i++)
                if (arr[i].GetType().ToString() == "Lab6.Transformer")
                {
                    Transformer transformer = arr[i] as Transformer;
                    if (transformer.EnginePower == power)
                    {
                        WriteLine((i + 1).ToString() + ' ' + transformer.Name);
                        flag = true;
                    }
                }
            if (flag == false)
                WriteLine("Nothing");
        }
        public static int Counts(this Army army)
        { return army.Count; }
    }
    class Program
    {
        
        public static void Main()
        {
            Vehicle vehicle;
            OfficeCars office1 = new OfficeCars("hummer", "big auto", 2000, 20);
            vehicle = office1 as Vehicle;
            Car car1 = new Car("big auto", "hummer", "AM1011", 2003, 3000, 900, 1998, 700);
            IntelligentCreature creature1;
            Human human1 = new Human(3, 18, 175, "Evgen", 12, 11, 1999);
            creature1 = human1 as IntelligentCreature;
            Transformer transformer1 = new Transformer(car1, 570, 320, "Rainhard", 1, 2, 1448);
            WriteLine(vehicle.ToString());
            WriteLine("------------------------------------------------");
            WriteLine(office1.ToString());
            WriteLine("------------------------------------------------");
            WriteLine(car1.ToString());
            WriteLine("------------------------------------------------");
            WriteLine(creature1.ToString());
            WriteLine("------------------------------------------------");
            WriteLine(human1.ToString());
            WriteLine("------------------------------------------------");
            WriteLine(transformer1.ToString());
            WriteLine("------------------------------------------------");
            string mark1;
            car1.GetCarMark(out mark1);
            OfficeCars office2 = new OfficeCars("hummer", "big auto", 2000, 20);
            Write("office2->");
            office2.ThisCarsIs();
            ((OfficeCarsInterface)office2).ThisCarsIs();
            WriteLine("office1 = office2: " + office1.Equals(office2).ToString());
            WriteLine("Car1: " + mark1);
            Vehicle[] vehicle1 = { office1, office2, car1 };
            Army army = new Army();
            Car car2 = new Car("auto", "shevrolet", "camaro", 2007, 1200, 800, 2001, 700);
            Transformer transformer2 = new Transformer(car2, 280, 330, "Bumblebe", 1, 1, 1738);
            army.Add(human1);
            army.Add(transformer1);
            army.Add(transformer2);
            army.ToConsole();
            army.SearchEnginePower(100);
            army.SearchEnginePower(800);
            army.SearchEnginePower(900);
            WriteLine(army.SearchBirthDate(12, 11, 1999).ToString());
            WriteLine(army.Counts().ToString());
            army.Remove(human1);
            army.ToConsole();
            try
            {
                Car car = null;
                Transformer transformer3 = new Transformer(car, 280, 330, "Bumblebe", 1, 1, 1738);
            }
            catch (CreatingClassException exception)
            {
                WriteLine(exception.GetMessage);
                WriteLine(exception.StackTrace);
                WriteLine("Класс который вызвал ошибку: " + exception.Source);
                WriteLine("Тип поля которое вызвало ошибку: " + exception.WhatData);
            }
            try { OfficeCars office3 = new OfficeCars("hummer", "big auto", -2000, 20); }
            catch (CreatingClassException exception)
            {
                WriteLine(exception.GetMessage);
                WriteLine(exception.StackTrace);
                WriteLine("Класс который вызвал ошибку: " + exception.Source);
                WriteLine("Тип поля которое вызвало ошибку: " + exception.WhatData);
            }
            try
            {
                int[] arr = { 1, 2, 3 };
                int i = 4;
                if (i > arr.Length)
                    throw new OutofRangeException(i, arr.Length);
                else WriteLine(arr[i].ToString());
            }
            catch (OutofRangeException exception)
            {
                WriteLine(exception.GetMessage);
                WriteLine(exception.StackTrace);
                WriteLine("Вышло за пределы типа на значение: " + exception.OutValue.ToString());
                WriteLine("Вышло за пределы массива на значение: " + exception.OutRange.ToString());
            }
            try
            {
                long i = 200;
                long x = i + int.MaxValue;
                if (x > int.MaxValue)
                    throw new OutofRangeException(x);
            }
            catch (OutofRangeException exception)
            {
                WriteLine(exception.GetMessage);
                WriteLine(exception.StackTrace);
                WriteLine("Вышло за пределы типа на значение: " + exception.OutValue.ToString());
                WriteLine("Вышло за пределы массива на значение: " + exception.OutRange.ToString());
            }
            try
            {
                int x = 10;
                int y = 0;
                int result = (y == 0) ? throw new ArithmeticException() : x / y;
            }
            catch(ArithmeticException exception)
            {
                WriteLine(exception.GetMessage);
                WriteLine(exception.StackTrace);
            }
            try
            {
                int x = 0;
                int y = 10 / x;
            }
            catch { WriteLine("Вызвано исключение"); }
            finally { WriteLine("Обработка ошибок завершена"); }
            int[] aa = null;
            Debug.Assert(aa != null, "Values array cannot be null");
            ReadKey();
        }
    }
}
