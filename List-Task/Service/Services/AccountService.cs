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
    public class AccountService : IAccountService
    {
        
        public List<User> GetAll()
        {
            return UserDb.Users();
        }

        public bool LogIn(string mail, string password)
        {
            bool success=true;
            foreach (var item in GetAll())
            {
                if (item.Mail == mail && item.Password == password)
                {
                    return success;
                }
               
            }
           
            

            return false;
        }
    }
}
