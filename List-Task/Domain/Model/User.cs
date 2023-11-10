using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class User:BaseEntitiy
    {
        public string Mail {  get; set; }
        public string Password { get; set; }
    }
}
