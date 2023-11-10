using Domain.Model;
using Service.AppDbContext;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AuthorService : IAuthor
    {
        public List<Author> GetAll()
        {
            return AuthorDb.Authors();
        }

        public List<Author> GetByAge(int age)
        {
            return GetAll().Where(m=>m.Age>age).ToList();
        }
    }
}
