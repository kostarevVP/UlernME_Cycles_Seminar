using System;

namespace Cycles_Seminar
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Loops1();
                //Loops2();
                //Loops3();
                //Loops4();
                Loops5();
                Console.ReadKey();
            }
        }
        
        private static void Loops1()
        {
            Console.WriteLine("Loops1. Дано целое неотрицательное число N. Найти число, составленное теми же десятичными цифрами, что и N, но в обратном порядке. Запрещено использовать массивы.");
            var number = int.Parse(Console.ReadLine());
            var number_D = (decimal)number;
            var grade = 0;
            int numberReverse = 0;
            while (number_D > 1)
            {
                number_D = number_D / 10;
                grade++;
            }
            for (int i = 1; i <= grade; i++)
            {
                var lastNumber = number % 10;
                numberReverse = numberReverse + lastNumber * (int)Math.Pow(10, grade - i);
                number = (number - lastNumber) / 10;
            }
            Console.WriteLine(numberReverse);
        }

        private static void Loops2()
        {
            Console.WriteLine("Loops2. Дано N (1 ≤ N ≤ 27). Найти количество трехзначных натуральных чисел, сумма цифр которых равна N. Операции деления (/, %) не использовать.");
            var number = Int32.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (number == (i + j + k))
                            count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

        private static void Loops3()
        {
            Console.WriteLine("Loops3. Если все числа натурального ряда записать подряд каждую цифру в своей позиции, то необходимо ответить на вопрос: какая цифра стоит в заданной позиции N.");
            var position = Int32.Parse(Console.ReadLine());
            var numericalSeries = "";
            for (int i = 1; i <= position; i++)
            {
                numericalSeries += i.ToString();
            }
            Console.WriteLine(numericalSeries[position-1]);
        }

        private static void Loops4()
        {
            Console.WriteLine("Loops4. В массиве чисел найдите самый длинный подмассив из одинаковых чисел.");
            int[] array = { 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 0 };
            var count = 0;
            var point = 0;
            var countTemp = 0;
            var pointTemp = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == array[i])
                {
                    countTemp++;
                }
                if (array[i - 1] != array[i] || i + 1 == array.Length)
                {
                    if (countTemp > count)
                    {
                        count = countTemp;
                        if (i + 1 == array.Length && array[i - 1] == array[i])
                            point = i + 1;
                        else
                            point = i;
                    }
                    countTemp = 0;
                }

            }
            if (count <= 0)
            {
                Console.WriteLine("нет елементов масива которые повторяются подряд");
            }
            else if (count > 0)
            {
                var subArray = new int[count + 1];
                Array.Copy(array, point - 1 - count, subArray, 0, count + 1);
                Console.WriteLine($"В даном масиве начиная из {point - count} елемента идет наиболший подмасив из {count + 1} елементов с одинаковыми числами подряд");
                foreach (int i in subArray)
                    Console.Write($"{subArray[i]} ");
            }
        }

        private static void Loops5()
        {
            Console.WriteLine("Loops5. Дана строка из символов '(' и ')'. Определить, является ли она корректным скобочным выражением. Определить максимальную глубину вложенности скобок.");
            string str = "(()((()(()))()))";
            Console.WriteLine(str);
            string negativeAnswer = "Даное скобочное выражение не правильно";

            if (String.IsNullOrEmpty(str))
            {
                Console.WriteLine($"строка пустая, нечего проверять{str.Length}");
            }
            else if (str.Length % 2 != 0)
            {
                Console.WriteLine(negativeAnswer);
            }
            else
            {
                var depthMax = str.Length / 2;
                var depth = 0;
                while (true)
                {
                    if (String.IsNullOrEmpty(str))
                    {
                        Console.WriteLine($"Даное скобочное выражение правильно и имеет максимальную глубину вложености скобок {depth}");
                        break;
                    }
                    for (int i = 1; i < str.Length; i++)
                    {
                        if (str[i - 1] == '(' && str[i] == ')')
                        {
                            str = str.Substring(0, i - 1) + str.Substring(i + 1);
                            //i = 1;
                        }
                    }
                    depth++;
                    if (depth > depthMax)
                    {
                        Console.WriteLine(negativeAnswer);
                        break;
                    }
                }
            }
        }
    }
}
