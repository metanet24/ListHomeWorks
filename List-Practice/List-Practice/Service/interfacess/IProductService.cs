using List_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice.Service.interfacess
{
    public interface IProductService
    {
        List<Product> GetAll(); 
        Product GetById(int id);

        List<Product> GetAllByDescending();
    }
}
