using Application.DataTransfer;
using Application.Interfaces;
using Domain.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRespository _categoryRespository;
        public CategoryService(ICategoryRespository categoryRespository)
        {
            _categoryRespository = categoryRespository;
        }
        public IEnumerable<Category> GetAll()
        {
            return _categoryRespository.GetAll();
        }

        public void Insert(CategoryDTO dto)
        {
            var obj = new Category
            {
                Name = dto.Name
            };
            _categoryRespository.Insert(obj);
        }
    }
}
