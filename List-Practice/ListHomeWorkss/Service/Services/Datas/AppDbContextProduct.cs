using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Datas
{
    public static class AppDbContextProduct
    {
        public static List<Products> Products()
        {
            return new List<Products>()
            {
                new Products() {Name="Shirts",Price=25 },
                new Products() {Name="Trousers",Price=35 },
                new Products() {Name="Jackets",Price=45 }
            };
        }
    }
}
