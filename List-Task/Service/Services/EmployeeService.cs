using Domain.Model;
using Service.AppDbContext;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetAll()
        {
            return EmployeeDb.Employees();
        }

        public List<Employee> GetByAgeAndSalary(DateTime start, DateTime end, double salary)
        {
            return GetAll().Where(m=>m.Birthday>start&&m.Birthday<end&&m.Salary>salary).ToList();
        }
    }
}
