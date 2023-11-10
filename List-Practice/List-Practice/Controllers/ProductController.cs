using List_Practice.Models;
using List_Practice.Service;
using List_Practice.Service.interfacess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice.Controllers
{
    public class ProductController
    {
        private readonly IProductService _service;

        public ProductController()
        {
            _service=new ProductttsService();
        }

       public void GetAll()
        {
            var datas=_service.GetAll();

            foreach (var item in datas)
            {
                Console.WriteLine(item.Name+" "+item.Price);
            }
        }



        public void GetById(int id)
        {
            var data = _service.GetById(2);
            Console.WriteLine(data.Id+" "+data.Name+" "+data.Price);

        }

        public void Sort()
        {
            var datas = _service.GetAllByDescending();

            foreach (var item in datas)
            {
                Console.WriteLine(item.Name+" "+item.Price);
            }
        }
    }
}
