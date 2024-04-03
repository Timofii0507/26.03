using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._03
{
    class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var employees = new List<Employee>
        {
            new Employee { FullName = "John Doe", Position = "Manager", PhoneNumber = "230123456", Email = "john.doe@example.com", Salary = 50000 },
            new Employee { FullName = "Jane Smith", Position = "Developer", PhoneNumber = "231987654", Email = "jane.smith@example.com", Salary = 60000 },
        };
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;

            var allEmployees = employees.ToList();

            decimal minSalary = 55000;
            var highSalaryEmployees = employees.Where(e => e.Salary > minSalary).ToList();

            var managerEmployees = employees.Where(e => e.Position == "Manager").ToList();

            var phoneStartsWith23 = employees.Where(e => e.PhoneNumber.StartsWith("23")).ToList();

            var emailStartsWithDi = employees.Where(e => e.Email.StartsWith("di")).ToList();

            var lionelEmployees = employees.Where(e => e.FullName.Contains("Lionel")).ToList();

            Console.WriteLine("Всі працівники:");
            PrintEmployees(allEmployees);

            Console.WriteLine("\nПрацівники з високою заробітною платою:");
            PrintEmployees(highSalaryEmployees);

            Console.WriteLine("\nПрацівники-менеджери:");
            PrintEmployees(managerEmployees);

            Console.WriteLine("\nПрацівники з номером телефону, що починається з \"23\":");
            PrintEmployees(phoneStartsWith23);

            Console.WriteLine("\nПрацівники з Email, що починається з \"di\":");
            PrintEmployees(emailStartsWithDi);

            Console.WriteLine("\nПрацівники з ім'ям \"Lionel\":");
            PrintEmployees(lionelEmployees);
        }

        static void PrintEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FullName} ({employee.Position}): {employee.PhoneNumber}, {employee.Email}, ЗП: {employee.Salary}");
            }
        }
    }
}
