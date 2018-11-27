using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
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
            age = _age;
            height = _height;
            name = _name;
            date = new Birthday(-1, -1, -1);
        }
        public Human(int _sex, int _age, int _height, string _name, int _day, int _month, int _year)
        {
            LifeLength = 100;
            if (_sex == 1)
                sex = HumanSex.Man;
            else if (_sex == 2)
                sex = HumanSex.Woman;
            else sex = 0;
            age = _age;
            height = _height;
            name = _name;
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
}
