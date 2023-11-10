using Domain.Model;
using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Task.Controllers
{
    public class EmployeeController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public void GetAll()
        {
            var datas = _employeeService.GetAll();
            foreach (var employee in datas)
            {
                Console.WriteLine(employee.Name+" "+""+employee.SurName+" "+employee.Salary+" "+employee.Birthday);
            }
        }

        public void GetByAgeAndSalary()
        {
            Console.WriteLine("Add start date:");
            DateTime start=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Add end date:");
            DateTime end = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Add salary:");
            double salary=double.Parse(Console.ReadLine());

            var datas = _employeeService.GetByAgeAndSalary(start,end,salary);

            foreach (var employee in datas)
            {
                Console.WriteLine(employee.Name + " " + "" + employee.SurName + " " + employee.Salary + " " + employee.Birthday);
            }
        }
    }
}
