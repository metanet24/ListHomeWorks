using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice.Models
{
    public class Animal:BaseEntitiy
    {
        string Name { get; set; }

        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }
        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
}
