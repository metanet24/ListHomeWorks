using List_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice.Datas
{
    public static class AppDbContext
    {
        public static List<Product> products()
        {
            return new List<Product>()
            {
                new Product() {Id=1, Name="Iphone",Price=5000},
                new Product() {Id=2, Name="Nokia",Price=1000},
                new Product() {Id=3, Name="Samsung",Price=3000},
            };
        }
    }
}
