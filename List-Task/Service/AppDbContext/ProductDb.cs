using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AppDbContext
{
    public static class ProductDb
    {
        public static List<Product> Products()
        {
            return new List<Product>()
            {
                new Product() {Id=1, Name="Samsung",Price=2000,Count=10},
                new Product() {Id=2, Name="Iphone",Price=3000,Count=20},
                new Product() {Id=3, Name="LG",Price=4000,Count=30}
            };
        }
    }
}
