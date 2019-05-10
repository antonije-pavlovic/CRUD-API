using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface ICategoryRespository
    {
        IEnumerable<Category> GetAll();
        Category GetById(int id);
        void Insert(Category dto);
        void Update(Category category);
        void Save();
    }
}
