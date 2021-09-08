using System;

namespace Cycles_Seminar
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Loops1();
                Loops2();
                Loops3();
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

    }
}
