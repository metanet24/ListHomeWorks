using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IAuthor
    {
        List<Author> GetAll();

        List<Author> GetByAge(int age);
    }
}
