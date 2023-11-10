using List_Practice.Datas;
using List_Practice.Models;
using List_Practice.Service.interfacess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice.Service
{
    internal class ProductttsService : IProductService
    {
        public List<Product> GetAll()
        {
            return AppDbContext.products();
        }

        public List<Product> GetAllByDescending()
        {
            return AppDbContext.products().OrderByDescending(x=>x.Price).ToList();
        }

        public Product GetById(int id)
        {
            return AppDbContext.products().FirstOrDefault(m => m.Id == id);
        }
    }
}
