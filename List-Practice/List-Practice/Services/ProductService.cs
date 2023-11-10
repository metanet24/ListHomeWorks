using List_Practice.Data;
using List_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetAll()
        {
            return AppDbContext.Products();
        }

        public List<Product> GetAllDesc()
        {
            return GetAll().OrderByDescending(m=>m.Price).ToList();
        }

        public Product GetById(int Id)
        {
            return GetAll().FirstOrDefault(m => m.Id == Id);
        }
    }
}
