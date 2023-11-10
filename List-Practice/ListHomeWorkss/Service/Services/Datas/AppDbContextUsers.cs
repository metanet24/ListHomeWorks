using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Datas
{
    public static class AppDbContextUsers
    {
        public static List<User> Users()
        {
            return new List<User>()
            {
                new User() {Mail="Metish@mail.ru",Password="m123" },
                new User() {Mail="Naide@mail.ru",Password="n123" },
                new User() {Mail="Cavid@mail.ru",Password="c123" },
            };
        }
    }
}
