using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab5
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
            cars_brand = _cars_brand;
            count_cars = _count_cars;
            Category = _category;
            Mass = _mass;
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
            engine = new Engine(-1, -1, -1);
        }
        public Car(string _category, string _car_brand, string _model, int _year, int _mass, int _powerEngine, int _yearEngine, int _massEngine)
        {
            Category = _category;
            cars_brand = _car_brand;
            model = _model;
            year = _year;
            Mass = _mass;
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
    sealed class Human : IntelligentCreature
    {
        private string sex;
        private int age;
        private int height;
        private string name;
        public Human()
        {
            LifeLength = 100;
            sex = "";
            age = -1;
            height = -1;
            name = "";
        }
        public Human(string _sex, int _age, int _height, string _name)
        {
            LifeLength = 100;
            sex = _sex;
            age = _age;
            height = _height;
            name = _name;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Sex => sex;
        public int Age
        {
            get => age;
            set => age = value;
        }
        public int Height
        {
            get => height;
            set => height = value;
        }
        public override string ToString()
        {
            return "Человек:\n" + 
                   "Продолжительность жизни: " + "~" + LifeLength + " лет" +
                   "\nИмя: " + name.ToString() + 
                   "\nПол: " + sex.ToString() + 
                   "\nВозвраст: " + age.ToString() + " лет" + 
                   "\nРост: " + height.ToString() + " см";
        }
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
            carmodel = _car;
            carhuman.Name = _name;
            carhuman.Age = _age;
            carhuman.Height = _height;
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
        public string Name => carhuman.Name + CarName;
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
                   "\nРост: " + carhuman.Height.ToString() + " cм";
        }
    }
    class Printer
    {
        public virtual void iAmPrinting(Vehicle someobj)
        {
            WriteLine(someobj.GetType());
            WriteLine(someobj.ToString());
        }
    }
    class A : Printer
    {
        public override void iAmPrinting(Vehicle someobj)
        { base.iAmPrinting(someobj); }
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
            Human human1 = new Human("man", 18, 175, "Evgen");
            creature1 = human1 as IntelligentCreature;
            Transformer transformer1 = new Transformer(car1, 570, 320, "Rainhard");
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
            Printer printer = new Printer();
            WriteLine("------------------------------------------------");
            for (int i = 0; i < vehicle1.Length; i++)
            {
                printer.iAmPrinting(vehicle1[i]);
                WriteLine("------------------------------------------------");
            }
            ReadKey();
        }
    }
}
