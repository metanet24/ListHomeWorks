using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice.Models
{
    public class Fish:Animal
    {
        public string Scale { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Fish Sound");
        }

    }
}
