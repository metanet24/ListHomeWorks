using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AppDbContext
{
    public static class EmployeeDb
    {
        public static List<Employee> Employees()
        {
            return new List<Employee>()
            {
            new Employee() { Id = 1, Name = "Metanet", SurName = "Abbasova", Salary = 2000, Birthday = new DateTime(2002, 04, 19) },
            new Employee() { Id = 2, Name = "Naida", SurName = "Basharatova", Salary = 200, Birthday = new DateTime(1983, 02, 01) },
            new Employee() { Id = 3, Name = "Qurban", SurName = "Qurbanov", Salary = 3000, Birthday = new DateTime(2002, 02, 09) }

            };

        }
        
        
    }
}
