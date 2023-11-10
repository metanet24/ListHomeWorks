using Domain.Models;
using Service.Services.Datas;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AuthorService : IAuthorService
    {
        public List<Author> GetByAge()
        {
           return AppDbContext.Authors().Where(x=>x.Age>40).ToList();
        }
    }
}
