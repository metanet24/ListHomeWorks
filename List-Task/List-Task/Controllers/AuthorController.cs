using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Task.Controllers
{
    public class AuthorController
    {
        private readonly IAuthor _authorservice;

        public AuthorController()
        {
            _authorservice = new AuthorService();
        }

        public void GetAll()
        {
            var datas=_authorservice.GetAll();
            foreach (var author in datas)
            {
                Console.WriteLine(author.Name+" "+author.SurName+" "+author.Age);
            }
        }

        public void GetByAge()
        {
            Console.WriteLine("Add age:");
        Age: string str=Console.ReadLine();
            int age;
            bool check=int.TryParse(str, out age);
          
            if(check&&age>0)
            {
                var datas = _authorservice.GetByAge(age);
                foreach (var author in datas)
                {
                    Console.WriteLine(author.Name + " " + author.SurName + " " + author.Age);
                }
            }
            else
            {
                Console.WriteLine("Format is wrong,write again:");
                goto Age;
            }

           
        }
    }
}
