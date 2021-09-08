using System;

namespace Cycles_Seminar
{
    class Program
    {
        static void Main(string[] args)
        {
           while(true)
            {
                Loops1();
                Loope2();
            }
        }

        private static void Loops1()
        {
            Console.WriteLine("Введите натуральное целое число, а я его разверну");
            var number = int.Parse(Console.ReadLine());
            var number_D = (decimal)number;
            var grade = 0;
            int numberReverse = 0;
            while(number_D > 1)
            {
                number_D = number_D / 10;
                grade++;
            }
            for(int i = 1; i <= grade; i++)
            {
            	var lastNumber = number % 10;
            	numberReverse = numberReverse + lastNumber * (int)Math.Pow(10, grade - i);
            	number = (number - lastNumber) / 10;
            }
            Console.WriteLine(numberReverse);
        }
        
        private static boid Loops2()
        {
        	Console.WriteLine("Введите число от 1 до 27, а я найду  трехзначных натуральных чисел, сумма цифр которых равна введенному числу");
        	var number = Int32.Parse(Console.ReadLine());
        	for (int i = 1; i <= number; i++)
        	{
        		
        	}
        }
    }
}
