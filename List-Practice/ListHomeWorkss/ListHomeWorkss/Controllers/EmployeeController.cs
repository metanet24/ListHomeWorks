using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHomeWorkss.Controllers
{
    public class EmployeeController
    {
        private readonly IEmployee _employeeservice;
        public EmployeeController()
        {
          _employeeservice = new EmployeeService();
        }

        public void SortByData()
        {
            DateTime StartDate = new DateTime(2002, 01, 01);
            DateTime EndDate = new DateTime(2002, 12, 12);
            int salary = 2000;

            var datas=_employeeservice.SortByData(StartDate, EndDate,salary);

            int count = 0;

            foreach (var data in datas)
            {
                count++;
            }

            Console.WriteLine(count);

        }
    }
}
