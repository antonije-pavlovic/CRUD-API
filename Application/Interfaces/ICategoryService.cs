using Application.DataTransfer;
using Domain.Models;
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
        Category GetById(int id);
        void Update(Category category);
        void Insert(CategoryDTO dto);
    }
}
