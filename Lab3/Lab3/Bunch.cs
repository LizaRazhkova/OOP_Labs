using System;
using System.Collections.Generic;
using static System.Console;
namespace Lab3
{
    internal sealed partial class Bunch<T>
    {
        public bool Security
        {
            get => security;
            set => security = value;
        }
        public int Sumab(int a, int b)
        {
            return a + b;
        }
        public double Sum
        {
            get
            {
                if ((field.ToArray().GetType().GetElementType().ToString() != "System.String") &&
                   (field.ToArray().GetType().GetElementType().ToString() != "System.Object") &&
                   (field.ToArray().GetType().GetElementType().ToString() != "System.Boolean") &&
                   (field.ToArray().GetType().GetElementType().ToString() != "System.Char"))
                {
                    T[] mas = field.ToArray();
                    double sum = 0;
                    for (int i = 0; i < mas.Length; i++)
                        sum += Double.Parse(mas[i].ToString());
                    return sum;
                }
                else
                {
                    WriteLine("Error: Недопустимый тип");
                    return -1;
                }
            }
        }
        public bool Negative
        {
            get
            {
                if ((field.ToArray().GetType().GetElementType().ToString() != "System.String") &&
                   (field.ToArray().GetType().GetElementType().ToString() != "System.Object") &&
                   (field.ToArray().GetType().GetElementType().ToString() != "System.Boolean") &&
                   (field.ToArray().GetType().GetElementType().ToString() != "System.Char"))
                {
                    if (neg_elems == false)
                    {
                        T[] mas = field.ToArray();
                        for (int i = 0; i < mas.Length; i++)
                            if (Double.Parse(mas[i].ToString()) < 0)
                                neg_elems = true;
                    }
                    return neg_elems;
                }
                else
                {
                    WriteLine("Error: Недопустимый тип");
                    return false;
                }
            }
        }
        static Bunch()
        {
            counter_elems = 0;
        }
        private Bunch()
        {
            Count = 0;
            counter_elems++;
            if (security == true)
                field = new List<T>(Capacity);
            else field = new List<T>();
            type = field.ToArray().GetType().GetElementType();
        }
        //public Bunch()
        //{
        //    Count = 0;
        //    counter_elems++;
        //    if (security == true)
        //        field = new List<T>(Capacity);
        //    else field = new List<T>();
        //    type = field.ToArray().GetType().GetElementType();
        //}
        public Bunch(T[] mas, bool secure_flag = true) : this()
        {
            type = field.ToArray().GetType().GetElementType();
            Count = mas.Length;
            field.InsertRange(0, mas);
        }
        public static void Info()
        {
            WriteLine("-------------------------------------Информация о использовании класса данного типа-------------------------------------");
            WriteLine("Количество созданных экземпляров: " + counter_elems.ToString());
            WriteLine("Максимальная вместимость множества при использовании безопасного режима: " + Capacity.ToString());
        }
        public bool add(int index, T element)
        {
            if ((Count == Capacity) && (security == true))
            {
                WriteLine("Лимит элементов достигнут");
                return false;
            }
            Count++;
            field.Insert(index, element);
            return true;
        }
        public bool delete(ref T element, out int index)
        {
            if (Count == 0)
            {
                WriteLine("Множество пустое");
                index = -1;
                return false;
            }
            try { index = field.IndexOf(element); }
            catch (Exception e)
            {
                index = -1;
                WriteLine(e.Message);
                return false;
            }
            Count--;
            return field.Remove(element);
        }
        public override int GetHashCode()
        {
            int hash = 269;
            hash += type.GetHashCode() * 47;
            hash += security.GetHashCode();
            hash += Count.GetHashCode();
            T[] mas = this.field.ToArray();
            for (int i = 0; i < mas.Length; i++)
                hash += mas[i].GetHashCode();
            return hash;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Bunch<T> elem = (Bunch<T>)obj;
            if (elem.type != type)
                return false;
            if (elem.GetHashCode() != GetHashCode())
                return false;
            return true;
        }
        public override string ToString()
        {
            string str_type = "Тип: " + type.ToString(),
                   str_count = "Количество: " + Count,
                   str_security = "Безопасное: " + ((security == true) ? "Да" : "Нет"),
                   str_capacity = "Вместимость: " + ((security == true) ? Capacity.ToString() : "не определено");
            string res = "";
            T[] mas = field.ToArray();
            for (int i = 0; i < mas.Length; i++)
                res = res + mas[i].ToString() + ' ';
            return ("Содержимое: " + res + '\n' + str_type + '\n' + str_count + '\n' + str_security + '\n' + str_capacity + '\n');
        }
    }
}