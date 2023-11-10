using List_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int Id);

        List<Product> GetAllDesc();
    }
}
