using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Task.Controllers
{
    public class AccountController
    {
        private IAccountService _accountService;

        private IProductService _productService;
        public AccountController()
        {
            _accountService =new AccountService();
            _productService = new ProductService();
        }

        public void GetAll()
        {
           var datas= _productService.GetAll();
            foreach (var item in datas)
            {
                Console.WriteLine(item.Name);
            }
        }
        public void Search() 
        {
            Console.WriteLine("Add search txt");
            string txt=Console.ReadLine();
            var datas=_productService.Search(txt);
            foreach (var item in datas)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void LogIn()
        {
            
            Console.WriteLine("Add Mail");
            string mail=Console.ReadLine();
            Console.WriteLine("Add Password");
            string password=Console.ReadLine();
            var data = _accountService.LogIn(mail,password);
            Console.WriteLine("Please choose op 1(GetAll),2(Search)");
            Options: int op = int.Parse(Console.ReadLine());
            
            if (data)
            {
                switch (op)
                {
                    case 1: GetAll(); break; goto Options;

                    case 2: Search(); break;
                    
                    default:
                        Console.WriteLine("Add true Options");
                        break;
                }
            }
        
        }
    }
}
