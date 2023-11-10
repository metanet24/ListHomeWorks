using Domain.Model;
using Service.AppDbContext;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetAll()
        {
            return ProductDb.Products();
        }

        public List<Product> Search(string searchtxt)
        {
            return GetAll().Where(m=>m.Name.ToLower().Contains(searchtxt.ToLower())).ToList();
        }
    }
}
