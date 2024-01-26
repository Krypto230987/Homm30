using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homm30
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeCollection collection = new EmployeeCollection();

            collection.Add(new Employee { FirstName = "John", LastName = "Doe", BirthYear = 1990, Salary = 50000 });
            collection.Add(new Employee { FirstName = "Jane", LastName = "Smith", BirthYear = 1985, Salary = 60000 });
            collection.Add(new Employee { FirstName = "Tom", LastName = "Brown", BirthYear = 1995, Salary = 45000 });

            // Сортировка коллекции по зарплате
            collection.employees.Sort(new Employee());

            // Вывод отсортированной коллекции
            foreach (Employee employee in collection)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.Salary}");
                
            }
            Console.ReadLine();
        }
    }
}
