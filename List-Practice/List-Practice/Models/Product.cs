﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice.Models
{
    public class Product:BaseEntitiy
    {
        public string Name {  get; set; }
        public double Price { get; set; }

        public int Count { get; set; }

    }
}
