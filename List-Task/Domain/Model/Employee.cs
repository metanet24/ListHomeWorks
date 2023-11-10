using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Employee:BaseEntitiy
    {
        public string Name {  get; set; }
        public string SurName { get; set; }
        public double Salary {  get; set; }
        public DateTime Birthday { get; set; }
    }
}
