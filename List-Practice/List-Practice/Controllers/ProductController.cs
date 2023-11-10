using List_Practice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice.Controllers
{
    public class ProductController
    {
        private readonly IProductService _productService;
        public ProductController()
        {
            _productService = new ProductService();
        }
        public void GetAll()
        {
            var datas=_productService.GetAll();

            foreach (var item in datas)
            {
                Console.WriteLine(item.Name+" "+item.Price);
            }
        }
        public void GetById()
        {
            int Id=int.Parse(Console.ReadLine());
            var data = _productService.GetById(Id);
            Console.WriteLine(data.Name+" "+data.Count);

        }


        public void Sort()
        {
            var datas = _productService.GetAllDesc();

            foreach (var item in datas)
            {
                Console.WriteLine(item.Name + " " + item.Price);
            }
        }
    }
}
