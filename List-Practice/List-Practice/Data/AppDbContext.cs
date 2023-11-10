using List_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice.Data
{
    public static class AppDbContext
    {
        public static List<Product> Products()
        {
            return new List<Product>()
            {
                new Product
                {
                    Id=1,
                    Name="Samsung",
                    Price=300,
                    Count=20,
                },
                 new Product
                {
                    Id=2,
                    Name="Apple",
                    Price=3000,
                    Count=21,
                },
                  new Product
                {
                    Id=3,
                    Name="LG",
                    Price=900,
                    Count=15,
                }
            };
        }

        
    }
}
