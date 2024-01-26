using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homm30
{
    internal class Employee : IComparer<Employee>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public decimal Salary { get; set; }

        public int Compare(Employee x, Employee y)
        {
            // Реализация сравнения для сортировки
            // Можно выбрать сортировку по различным полям
            // Например, по имени, фамилии, году рождения или зарплате
            // Здесь приведен пример сортировки по зарплате
            return x.Salary.CompareTo(y.Salary);
        }
    }
}
