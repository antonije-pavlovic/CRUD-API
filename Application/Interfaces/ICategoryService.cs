﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICategoryService
    {
        //Task<IEnumerable<Category>> ListAsync();
        IEnumerable<Category> GetAll();
    }
}
