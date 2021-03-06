﻿using DataAccess;
using Domain.Models;
using Repository.Interfaces;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implementation
{
    public class CategoryRespository : BaseRepository, ICategoryRespository
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryRespository(Context context,IUnitOfWork unitOfWork): base(context)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Category> GetAll()
        {
            return _context.Categories;
        }
        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Insert(Category dto)
        {
            try
            {
                _context.Categories.Add(dto);
                this.Save();
            }
            catch(Exception e)
            {
                
            }
        }

        public void Save()
        {
            _unitOfWork.Save();           
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
            this.Save();
        }
    }
}
