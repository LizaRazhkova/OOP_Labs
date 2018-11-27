using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    partial class Human : IntelligentCreature
    {
        public Human()
        {
            LifeLength = 100;
            sex = 0;
            age = -1;
            height = -1;
            name = "";
            date = new Birthday(-1, -1, -1);
        }
        public Human(int _sex, int _age, int _height, string _name)
        {
            LifeLength = 100;
            if (_sex == 1)
                sex = HumanSex.Man;
            else if (_sex == 2)
                sex = HumanSex.Woman;
            else sex = 0;
            age = (_age < 0) ? throw new CreatingClassException(this, age.GetType()) : _age;
            height = (_height < 0) ? throw new CreatingClassException(this, _height.GetType()) : _height;
            name = _name ?? throw new CreatingClassException(this, name.GetType());
            date = new Birthday(-1, -1, -1);
        }
        public Human(int _sex, int _age, int _height, string _name, int _day, int _month, int _year) : this(_sex, _age, _height, _name)
        {
            if (_day < 0) throw new CreatingClassException(this, _day.GetType());
            if (_month < 0) throw new CreatingClassException(this, _month.GetType());
            if (_year < 0) throw new CreatingClassException(this, _year.GetType());
            date = new Birthday(_day, _month, _year);
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Sex
        {
            get
            {
                if (sex == HumanSex.Man)
                    return "Man";
                if (sex == HumanSex.Woman)
                    return "Woman";
                return "?";
            }
        }
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
        public int Day => date.day;
        public int Month => date.month;
        public int Year => date.year;
        public string BirthDate()
        {
            if ((date.day == -1) || (date.month == -1) || (date.year == -1))
                return "?:?:?";
            return date.day.ToString() + ':' + date.month.ToString() + ':' + date.year.ToString();
        }
        public override string ToString()
        {
            return "Человек:\n" +
                   "Продолжительность жизни: " + "~" + LifeLength + " лет" +
                   "\nИмя: " + name.ToString() +
                   "\nПол: " + Sex.ToString() +
                   "\nВозвраст: " + age.ToString() + " лет" +
                   "\nРост: " + height.ToString() + " см" +
                   "\nГод рождения: " + BirthDate();
        }
    }
    class CreatingClassException : Exception
    {
        private string message, field;
        public CreatingClassException(object obj, Type fieldType)
        {
            field = fieldType.ToString();
            Source = obj.GetType().ToString();
            message = "На конструктор было подано неверное или null значение";
        }
        public string GetMessage => message;
        public string WhatData => field;
    }
    class OutofRangeException : Exception
    {
        private string message;
        private int usedindex, range;
        private long outvalue;
        public OutofRangeException(long value)
        {
            if (value > 0)
                outvalue = value - int.MaxValue;
            if (value < 0)
                outvalue = int.MinValue - value;
            usedindex = 0;
            range = 0;
            message = "Выход за пределы типа значения";
        }
        public OutofRangeException(int value, int arrlength)
        {
            usedindex = value;
            range = arrlength;
            outvalue = 0;
            message = "Выход за пределы размера массива";
        }
        public string GetMessage => message;
        public long OutValue => outvalue;
        public int OutRange
        {
            get
            {
                    if (usedindex < 0)
                        return usedindex;
                    return usedindex - range;
            }
        }
    }
    class ArithmeticException : Exception
    {
        private string message;
        public ArithmeticException()
        { message = "Арифметическая ошибка"; }
        public string GetMessage => message;
    }
}
