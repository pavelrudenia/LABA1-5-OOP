﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class laba2
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            bool isFalse = false;
            byte byte1 = 1;
            sbyte sbyte1 = -101;
            short isShort = -250;
            ushort isUshort = 250;
            int integer = -65;
            uint uInteger = 65;
            long long1 = -27;
            ulong ulong1 = 27;
            float float1 = 3.564f;
            double double1 = 5.6545454;
            decimal decimal1 = 5.644435m;
            char char1 = 'Ç';
            string hello = "world";
            object ob = 22;
            /*
          //ЗАДАНИЕ ТИПЫ
            bool isTrue = true;
            bool isFalse = false;
            byte byte1 = 1;
            sbyte sbyte1 = -101;
            short isShort = -250;
            ushort isUshort = 250;
            int integer = -65;
            uint uInteger = 65;
            long long1 = -27;
            ulong ulong1 = 27;
            float float1 = 3.564f;
            double double1 = 5.6545454;
            decimal decimal1 = 5.644435m;
            char char1 = 'Ç';
            string hello = "world";
            object ob = 22;
            Console.WriteLine($"bool : {isTrue},{isFalse},byte :{byte1},{sbyte1}, short : {isShort},{isUshort} int : {integer},{uInteger} long : {long1} , {ulong1} float :{float1} double : {double1} decimal : {decimal1} char : {char1} string :{hello} object : {ob}");
            



            
            //// 5 Неявныx преобразования
            int num = 2147;           
            long bigNum = num;
           float floatNum = num;
            object obNum = num;
            double UDouble = num;
            ////5 Явныx преобразования
            integer = (int)long1;
            Console.WriteLine($"{integer}");
            double1 = (int)integer;
            Console.WriteLine($"{double1}");
            integer = (int)float1;
            Console.WriteLine($"{integer}");
            ulong1 = (uint)uInteger;
            ob = (int)integer;
            sbyte a = 5;
            byte but = (byte)a;




            ////   упаковкa и распаковкa значимых типов
            int ii = 123;
            object o = ii; //упаковка
            int y = (int)o; //распаковка



            ////  неявно типизированной
            var qw = 5;
            var qww = "hello";










          
            //// Nullable
            int? Value = null;
            if ( Value != null)
            {
                Console.WriteLine($"value is : { Value}");
            } else
            {
                Console.WriteLine("Value is null");
            }
            Nullable<int> price = 123;
            if (price != null)
            {
                Console.WriteLine($"price is : { price}");
            }
            else
            {
                Console.WriteLine("price is null");
            }





            //смена типа
            var idk = 5;
            //idk = "Hello mistake";
            //// literal
            Console.WriteLine("Literal text");
            Console.WriteLine("One more text");
            //// сравнение
            string s1 = "hello";
            string s2 = "world";
            int result = String.Compare(s1, s2);
            if (result < 0)
            {
               Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if (result > 0)
            {
               Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }
            */






            /*
            // ЗАДАНИЕ  СТРОКИ
            bool isTrue = true;
            bool isFalse = false;
            byte byte1 = 1;
            sbyte sbyte1 = -101;
            short isShort = -250;
            ushort isUshort = 250;
            int integer = -65;
            uint uInteger = 65;
            long long1 = -27;
            ulong ulong1 = 27;
            float float1 = 3.564f;
            double double1 = 5.6545454;
            decimal decimal1 = 5.644435m;
            char char1 = 'Ç';
            string hello = "world";
            object ob = 22;
            //// сцепление
            string helo = "hello";
            string world = "world";
            string helloWorld = helo + " " + world;
            Console.WriteLine(helloWorld);
            string fullString = String.Concat(helloWorld, "!!!");
            Console.WriteLine(fullString);


            //// копирование
            helo = String.Copy(world);
            Console.WriteLine(helo);


            //// разделение строки на слова
            string[] info = { "Name: Pavel Rudenia", "Title: text",
            "Age: 18", "Location: Minsk", "Pol: Men"};
            int found = 0;



            foreach (string s in info)
             Console.WriteLine(s);


            //// delete
            foreach (string s in info)
            {
               found = s.IndexOf(":");
               Console.WriteLine("{0}", s.Substring(found + 2));
            }


            //// вставка
            string insertTest = "Hello, my name is Pavel";
            string newInsert = insertTest.Insert(6, "INSERT!");
            Console.WriteLine(newInsert);
            //// удаление заданной подстроки
            newInsert = newInsert.Remove(3);
            Console.WriteLine(newInsert);
            newInsert = newInsert.Replace(newInsert, " ");
            Console.WriteLine(newInsert);

            ////интерполяция
            Console.WriteLine($"bool : {isTrue},{isFalse},byte :{byte1},{sbyte1}, short : {isShort},{isUshort} int : {integer},{uInteger} long : {long1} , {ulong1} float :{float1} double : {double1} decimal : {decimal1} char : {char1} string :{hello} object : {ob}");

            ////IsNullOrEmpty


            string st1 = "abcd";
            string st2 = "";
            string st3 = null;
            string st4 = "Hello";
            string[] array = { st1, st2,st3,st4};
            if (String.IsNullOrEmpty(st1))
            {
                Console.WriteLine("is empty or null");
            }
            else { Console.WriteLine(st1); }
            if (String.IsNullOrEmpty(st2))
            {
                Console.WriteLine("is empty or null");
            }
            else { Console.WriteLine(st2); }
            if (String.IsNullOrEmpty(st3))
            {
                Console.WriteLine("is empty or null");
            }
            else { Console.WriteLine(st3); }

            ////Создайте строку на основе StringBuilder.Удалите определенные  позиции и добавьте новые символы в начало и конец строки.
            System.Text.StringBuilder sb = new System.Text.StringBuilder("Hello, my name is Pavel");
            sb.Insert(0, "guys, ");
            sb.AppendFormat(",good bye");
            Console.WriteLine(sb);
            */

            /*
            //Задание МАССИВЫ


            int [,] arrayDouble = { { 0, 1, 2 }, { 3,4,5} };
            int rows = arrayDouble.GetUpperBound(0) + 1;
            int columns = arrayDouble.Length / rows;
            for (int count = 0; count < rows; count++)
            {
                for (int counter = 0; counter < columns; counter++)
                {
                   Console.Write($"{arrayDouble[count, counter]} \t");
               }
               Console.WriteLine();


            }
            //// массив строк
            string[] daysOfWeek = { "Sunday", "Monday", "Tuersday", "Wednesday", "Thirsday", "Friday", "Saturday", "Sunday" };
            for (int jj = 0; jj < daysOfWeek.Length; jj++)
            {
             Console.WriteLine(daysOfWeek[jj]);
             Console.WriteLine(daysOfWeek.Length);


            }

            //tooth array
            int[][] mas;
            Console.WriteLine("Введите количество строк");
            int n = int.Parse(Console.ReadLine());
            mas = new int[n][];
            int i = 0, j = 0;
            int m = 0;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Введите количество эл-то {0}-й строки", i);
                m = int.Parse(Console.ReadLine());
                mas[i] = new int[m];
               for (j = 0; j < m; j++)
               {
                    Console.WriteLine("Введите {0}-й элемент {1}-й строки", j, i);
                    mas[i][j] = int.Parse(Console.ReadLine());
               }
            }
            Console.WriteLine("Исходная матрица:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine();
               for (j = 0; j < mas[i].Length; j++)
                   Console.Write(mas[i][j] + "\t");
            }
            Console.WriteLine();
            for (i = 0; i < n - 1; i++)
            {
               for (j = 0; j < mas[i].Length; j++)
                   mas[i][j] = mas[i][j] - mas[n - 1][j];
            }

            // неявно типизированные переменные и масив
            var array = new object[0];
            var str = "";

        */


            /*
            // ЗАДАНИЕ  КОРТЕЖ
            //Задайте кортеж из 5 элементов с типами int, string, char, string,

            (int, string, char, string, ulong) tuple = (10, "its tuple", 'a', "Its stil tuple", 500);
            // Выведите кортеж на консоль целиком и выборочно ( например 1,3,4 элементы)
            (var a, var b, var c, var d) = (10, 20, 30, 40);
            Console.WriteLine($"{a} {b} {c} {d}");
            Console.WriteLine($"{tuple.Item1}, {tuple.Item3}, {tuple.Item4}");
            // Продемонстрируйте использование переменной ( _ )
            for (int _ = 0; _ < 2; _++)
            {
                Console.WriteLine(_);
            }
            */


            // Создайте локальную функцию в main и вызовите ее(https://docs.microsoft.com/en-us/dotnet/csharp/programmingguide/classes-andstructs/local-functions ) . Формальные параметры функции – массив целых и
            //строка.Функция должна вернуть кортеж, содержащий: максимальный иминимальный элементы массива, сумму элементов массива и первую букву строки.
            int Func(int[] numbers, string word)
            {

                Console.WriteLine("enter array size");
                int arrayValue = int.Parse(Console.ReadLine());

                int maxValue;
                int lowValue;
                for (int count = 0; count < arrayValue; count++)
                {
                    numbers[count] = int.Parse(Console.ReadLine());
                    Array.Sort(numbers);
                    maxValue = numbers[numbers.Length - 1];
                    //Tuple<int, int, int, char> Fuunc(int[] numbers, string word)
                    //{
                    // Array.Sort(numbers);
                    // return Tuple.Create(numbers[0], numbers[numbers.Length - 1], numbers.Sum(), word[0]);

                    lowValue = numbers[numbers.Length - arrayValue];
                    //}
                    //Fuunc(new int[] { 5, 6, 7, 5, 6, 3, 6, 1, -5,7, 1}, "hello");


                    int function1()
                    {
                        int maxVal = 2147483647;
                        int z = 0;
                        try
                        {
                            z = checked(maxVal + 11);
                        }
                char FisrtWord = word[1];

                        return Tuple.Create(maxValue, lowValue, FisrtWord);
                catch (System.OverflowException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        return z;
                    }
                    int function2()
                    {
                        int maxVal = 2147483647;
                        int z = 0;
                        try
                        {
                            z = maxVal + 11;
                        }
                        catch (System.OverflowException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        return z;
                    }

                    (int, string) info = (6, "hello");




                    Console.WriteLine("fisrt : {0}", function1());
                    Console.WriteLine("fisrt : {0}", function2());
                }
            }
        }
    }