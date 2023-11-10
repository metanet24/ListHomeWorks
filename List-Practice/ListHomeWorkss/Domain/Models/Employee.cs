using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Employee:BaseEntitiy
    {
        public string FullName {  get; set; }
        public int Salary { get; set; }

        public DateTime Birthday { get; set; }

    }
}
