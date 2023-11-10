using Domain.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AppDbContext
{
    public static class UserDb
    {
       public static List<User> Users()
        {
            return new List<User>()
            {
                new User() {Id=1,Mail="m@mail.ru",Password="m123"},
                new User() {Id=2,Mail="c@mail.ru",Password="c123"},
                new User() {Id=3,Mail="b@mail.ru",Password="b123"},
            };
        }
           
        
    }
}
