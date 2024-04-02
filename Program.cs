using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._03
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string University { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            List<Student> students = new List<Student>
        {
            new Student { FirstName = "Boris", LastName = "Johnson", Age = 22, University = "Oxford" },
            new Student { FirstName = "Alice", LastName = "Brown", Age = 20, University = "MIT" },
            new Student { FirstName = "John", LastName = "Brooks", Age = 19, University = "Harvard" },
            new Student { FirstName = "Natalie", LastName = "Smith", Age = 21, University = "MIT" },
        };

            Console.WriteLine("Весь масив студентів:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}, {student.Age} років, {student.University}");
            }

            var borisStudents = students.Where(student => student.FirstName == "Boris");
            Console.WriteLine("\nСписок студентів з ім'ям Boris:");
            foreach (var student in borisStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            var broStudents = students.Where(student => student.LastName.StartsWith("Bro", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("\nСписок студентів з прізвищем, яке починається з Bro:");
            foreach (var student in broStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            var olderThan19Students = students.Where(student => student.Age > 19);
            Console.WriteLine("\nСписок студентів, старших 19 років:");
            foreach (var student in olderThan19Students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            var between20And23Students = students.Where(student => student.Age >= 20 && student.Age <= 23);
            Console.WriteLine("\nСписок студентів, старших 20 років і молодших 23 років:");
            foreach (var student in between20And23Students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            var mitStudents = students.Where(student => student.University == "MIT");
            Console.WriteLine("\nСписок студентів, які навчаються в MIT:");
            foreach (var student in mitStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            var oxfordStudentsOver18 = students
                .Where(student => student.University == "Oxford" && student.Age > 18)
                .OrderByDescending(student => student.Age);
            Console.WriteLine("\nСписок студентів, які навчаються в Oxford, і вік яких старше 18 років (відсортовано за віком, за спаданням):");
            foreach (var student in oxfordStudentsOver18)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}, {student.Age} років");
            }
        }
    } 
}
