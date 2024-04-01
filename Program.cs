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
            string[] cities = new string[]
            {
            "Kyiv", "Lviv", "Kharkiv", "Dnipro", "Odessa", "Zaporizhzhia", "Kherson"
            };

            Console.WriteLine("Весь масив міст:");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            int desiredLength = 5; 
            var filteredCities = cities.Where(city => city.Length == desiredLength);
            Console.WriteLine($"\nМіста з назвою довжиною {desiredLength} символів:");
            foreach (var city in filteredCities)
            {
                Console.WriteLine(city);
            }

            var citiesStartingWithA = cities.Where(city => city.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("\nМіста, назви яких починаються з літери A:");
            foreach (var city in citiesStartingWithA)
            {
                Console.WriteLine(city);
            }

            var citiesEndingWithM = cities.Where(city => city.EndsWith("M", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("\nМіста, назви яких закінчуються літерою M:");
            foreach (var city in citiesEndingWithM)
            {
                Console.WriteLine(city);
            }

            var citiesStartingWithNAndEndingWithK = cities.Where(city => city.StartsWith("N", StringComparison.OrdinalIgnoreCase) && city.EndsWith("K", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("\nМіста, назви яких починаються з літери N і закінчуються літерою K:");
            foreach (var city in citiesStartingWithNAndEndingWithK)
            {
                Console.WriteLine(city);
            }

            var citiesStartingWithNe = cities.Where(city => city.StartsWith("Ne", StringComparison.OrdinalIgnoreCase)).OrderByDescending(city => city);
            Console.WriteLine("\nМіста, назви яких починаються з \"Ne\" (відсортовані за спаданням):");
            foreach (var city in citiesStartingWithNe)
            {
                Console.WriteLine(city);
            }
        }
    }
}
