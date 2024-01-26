using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homm30
{
    internal class EmployeeCollection : IEnumerable<Employee>
    {
        public List<Employee> employees;

        public EmployeeCollection()
        {
            employees = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return employees.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
