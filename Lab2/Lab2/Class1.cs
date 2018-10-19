using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab2
{
    class Class1
    {
        static void Main()
        {
            // 1.   a)
            double double_value = 80.0;
            float float_value = 40.0f;
            long long_value = 20;
            int int_value = 10;
            short short_value = 5;
            byte byte_value = 2;
            char char_value = 'a';
            string string_value = "abc";
            bool bool_value = true;
            //
            //      b)
            // неявные
            double_value = float_value;
            float_value = long_value;
            long_value = int_value;
            int_value = short_value;
            short_value = byte_value;
            // явное
            byte_value = (byte)short_value;
            short_value = (short)int_value;
            int_value = (int)long_value;
            long_value = (long)float_value;
            float_value = (float)double_value;
            //
            //      c)
            object x = int_value; // упаковка
            long_value = (int)x; // распаковка
            //
            //      d)
            var a = 5;
            var b = "abc";
            WriteLine("Тип переменной a " + a.GetType());
            WriteLine("Тип переменной b " + b.GetType());
            //
            //      e)
            int? nullable_value = null;
            WriteLine("Имеет ли значение и если имеет то какое: " + nullable_value.HasValue.ToString() + ' ' + nullable_value);
            short? nullable2_value = 5;
            WriteLine("Имеет ли значение и если имеет то какое: " + nullable2_value.HasValue.ToString() + ' ' + nullable2_value);
            //
            // 2.   a)
            string symb1 = "ab", symb2 = "abc";
            WriteLine("symb1: " + symb1);
            WriteLine("symb2: " + symb2);
            WriteLine("Результат сравнение строк symb1 и symb2 " + symb1.CompareTo(symb2));
            //
            //      b)
            string str1 = "ab", str2 = "abc", str3 = "abcd";
            WriteLine("str1: " + str1);
            WriteLine("str2: " + str2);
            WriteLine("str3: " + str3);
            WriteLine("Объединение str1 с str3: " + String.Concat(str1, str3));  
            WriteLine("Вставка копии str1 в строку str2: " + str2.Insert(1, String.Copy(str1)));  
            WriteLine("Подстрока str3 начиная с позиции 2: " + str3.Substring(2));  
            string str4 = "ab cd ef";
            WriteLine("str4: " + str4);
            WriteLine("Массив строк с разбитыми пробелом подстроками строки str4: ");
            string[] strs = str4.Split(new char[] { ' ' });
            for (var i = 0; i < strs.Length; i++)
                WriteLine(strs[i]);
            WriteLine("Введите индекс для вставки подстроки str2 \"bc\" в str1: ");
            int index = int.Parse(ReadLine());
            WriteLine(str1.Insert(index, str2.Substring(1)));
            WriteLine("Введите подстроку str3 = \"abcd\" для её удаления ");
            string substr = ReadLine();
            WriteLine(str3.Replace(substr, ""));
            //
            //      c)
            string str5 = "", str6 = null;
            try { str6.Insert(0, str5); } catch(Exception e) { WriteLine(e.Message); }
            WriteLine("Вставка str4 в str5: " + str5.Insert(0, str4));
            WriteLine("Равняется ли str5 и str6: " + (str5 == str6).ToString());
            //
            //      d)
            StringBuilder str7 = new StringBuilder("Hello World!");
            WriteLine("Строка str7 (создана при помощи StringBuilder): " + str7);
            str7.Remove(5, 1);
            str7.Remove(10, 1);
            WriteLine("Строка str7 после удаления 6 и 11 символов: " + str7.ToString());
            str7.Insert(0, "--");
            str7.Insert(str7.Length, "--");
            WriteLine("Строка str7 после вставки \"--\" в начале и конце: " + str7.ToString());
            //
            // 3.   a)
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // двухмерный массив
            WriteLine("Двумерный массив (матрица): ");
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                    Write(mas[i, j].ToString() + ' ');
                Write('\n');
            }
            //
            //      b)
            string[] str_mas = { "a", "ab", "abc", "abcd", "abcde" }; // одномерный массив
            WriteLine("Одномерный массив строк: ");
            for (var i = 0; i < str_mas.Length; i++)
                Write(str_mas[i] + ' ');
            WriteLine();
            WriteLine("Длинна массива: " + str_mas.Length.ToString());
            WriteLine("Номер элемента который хотите изменить: ");
            int id = int.Parse(ReadLine());
            WriteLine("Строка для замены: ");
            str_mas[id - 1] = ReadLine();
            WriteLine("Результат:");
            for (var i = 0; i < str_mas.Length; i++)
                Write(str_mas[i] + ' ');
            Write('\n');
            //
            //      c)
            int[][] mas1 = new int[3][];
            mas1[0] = new int[2];
            mas1[1] = new int[3];
            mas1[2] = new int[4];
            WriteLine("Введите элементы ступенчатого массива (9 чисел): ");
            for (var i = 0; i < mas1.Length; i++)
                for (var j = 0; j < mas1[i].Length; j++)
                    mas1[i][j] = int.Parse(ReadLine());
            WriteLine("Результат: ");
            for (var i = 0; i < mas1.Length; i++)
            {
                for (var j = 0; j < mas1[i].Length; j++)
                    Write(mas1[i][j].ToString() + ' ');
                Write('\n');
            }
            //
            //      d)
            var vmas = new[] { 1, 2, 3 };
            var vstr = "Hi";
            WriteLine("Тип переменной vmas " + vmas.GetType());
            WriteLine("Тип переменной vstr " + vstr.GetType());
            //
            // 4.   a) b) c)
            (int vint, string v1string, char vchar, string v2string, ulong vulong) court = ( 1, "abc", 'd', "Hello", 111 );
            WriteLine("Кортеж court: " + court);
            WriteLine("1-ый, 3-ий и 4-ый элементы: " + court.vint.ToString() + ' ' + court.vchar.ToString() + ' ' + court.v2string);
            //
            //      d)  упаковка
            int v_int = court.vint; 
            string v1_string = court.v1string, v2_string = court.v2string;
            char v_char = court.vchar;
            ulong v_ulong = court.vulong;
            //
            //      e)
            (int, string, char, string, ulong) court2 = (0, "abcd", 'e', "Hi", 231);
            WriteLine("Кортеж court2: " + court2);
            if (court2.CompareTo(court) > 0)
                WriteLine("Кортеж court2 больше чем court");
            else if (court2.CompareTo(court) < 0)
                WriteLine("Кортеж court больше чем court2");
            else WriteLine("Кортежи равны");
            //
            // 5.
            int[] int_mas = { 1, 2, 3, 4, 3, 2, 9 };
            Write("Исходный массив целых и строка: ");
            for (int i = 0; i < int_mas.Length; i++)
                Write(int_mas[i].ToString() + ' ');
            WriteLine(' ' + string_value);
            (int, int, int, char) func(int[] fmas, string str)
            { return (fmas.Max(), fmas.Min(), fmas.Sum(), str[0]); }
            Write("Результат работы func: ");
            WriteLine(func(int_mas, string_value));
            //
            ReadKey();
        }
    }
}
