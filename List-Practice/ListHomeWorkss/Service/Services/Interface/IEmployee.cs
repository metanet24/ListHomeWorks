using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interface
{
    public interface IEmployee
    {
        public List<Employee> SortByData(DateTime StartDate,DateTime EndDate,int Salary);
    }
}
