using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Datas
{
    public static class AppDbContext
    {
        public static List<Author> Authors()
        {
            return new List<Author>()
            {
                new Author() {Name="Victor",SurName="Hugo",Age=83},
                new Author() {Name="Franz",SurName="Kafka",Age=40},
                new Author() {Name="Huseyn",SurName="Cavid",Age=59},
                new Author() {Name="Metanet",SurName="Abbas",Age=21}

            };
        }
        
    }
}
