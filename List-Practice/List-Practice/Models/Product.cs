using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice.Models
{
    public class Product:BaseEntitiy
    {
        public string Name {  get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
