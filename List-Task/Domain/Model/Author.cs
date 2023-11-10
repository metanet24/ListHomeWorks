using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Author:BaseEntitiy
    {
        public string Name {  get; set; }
        public string SurName {  get; set; }

        public int Age {  get; set; }
    }
}
