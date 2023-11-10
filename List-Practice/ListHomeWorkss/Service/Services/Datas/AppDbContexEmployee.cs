using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Datas
{
    public static class AppDbContexEmployee
    {
        public static List<Employee> Employees()
        {
            return new List<Employee>()
            {
                new Employee() {FullName="Metanet Abbasova",Salary=3000,Birthday=new DateTime(2002,04,19)},
                new Employee() {FullName="Qurban Qurbanov",Salary=2000,Birthday=new DateTime(2002,02,09)},
                new Employee() {FullName="Naide Basharatova",Salary=1000,Birthday=new DateTime(1983,02,01)}
            };
        }
        

       

    }
}
