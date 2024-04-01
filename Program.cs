using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._03
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Весь масив цілих:");
            foreach (var number in myArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            var evenNumbers = myArray.Where(x => x % 2 == 0);
            Console.WriteLine("Парні цілі:");
            foreach (var number in evenNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            var oddNumbers = myArray.Where(x => x % 2 != 0);
            Console.WriteLine("Непарні цілі:");
            foreach (var number in oddNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            var greaterThanFive = myArray.Where(x => x > 5);
            Console.WriteLine("Значення більше 5:");
            foreach (var number in greaterThanFive)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            var numbersInRange = myArray.Where(x => x >= 3 && x <= 8);
            Console.WriteLine("Числа в діапазоні від 3 до 8:");
            foreach (var number in numbersInRange)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            var multiplesOfSeven = myArray.Where(x => x % 7 == 0).OrderBy(x => x);
            Console.WriteLine("Числа, кратні семи, відсортовані за зростанням:");
            foreach (var number in multiplesOfSeven)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            var multiplesOfEight = myArray.Where(x => x % 8 == 0).OrderByDescending(x => x);
            Console.WriteLine("Числа, кратні восьми, відсортовані за спаданням:");
            foreach (var number in multiplesOfEight)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }

}
