using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice.Models
{
    public class Bird:Animal
    {
        public string Colour { get; set; }

        public Bird()
        {
            Console.WriteLine("bird constructor");
        }
    }
}
