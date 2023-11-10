using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AppDbContext
{
    public class AuthorDb
    {
        public static List<Author> Authors()
        {
            return new List<Author>()
            {
                new Author(){Id=1,Name="Nizami",SurName="Ganjavi",Age=51},
                new Author(){Id=2,Name="Mikayil",SurName="Musfiq",Age=23},
                new Author(){Name="Abdulla",SurName="Shaiq",Age=18}
            };
        }
    }
}
