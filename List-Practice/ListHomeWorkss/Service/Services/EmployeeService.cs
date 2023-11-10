using Domain.Models;
using Service.Services.Datas;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class EmployeeService : IEmployee
    {
        public List<Employee> SortByData(DateTime StartDate, DateTime EndDate, int Salary)
        {
            var data = AppDbContexEmployee.Employees();

           return data.FindAll(x=>x.Birthday>StartDate && x.Birthday < EndDate && x.Salary==Salary).ToList();
            
        }
    }
}
