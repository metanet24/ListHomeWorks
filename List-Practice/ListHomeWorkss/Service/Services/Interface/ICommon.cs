﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interface
{
    public interface ICommon
    {
        public List<Products> GetProducts(string maail,string password);
    }
}
