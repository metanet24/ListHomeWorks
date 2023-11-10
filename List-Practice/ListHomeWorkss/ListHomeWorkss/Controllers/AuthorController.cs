using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHomeWorkss.Controllers
{
    public class AuthorController
    {
        private readonly IAuthorService _authorService;
        public AuthorController()
        {
            _authorService=new AuthorService();
        }

        public void GetByAge()
        {
            var data=_authorService.GetByAge();
            foreach(var item in data)
            {
                Console.WriteLine(item.Name+" "+item.SurName);
            }
        }
    }
}
