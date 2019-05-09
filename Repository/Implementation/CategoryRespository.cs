using DataAccess;
using Domain.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implementation
{
    public class CategoryRespository : BaseRepository, ICategoryRespository
    {
        public CategoryRespository(Context context): base(context) { }
        public IEnumerable<Category> GetAll()
        {
            return _context.Categories;
        }
    }
}
