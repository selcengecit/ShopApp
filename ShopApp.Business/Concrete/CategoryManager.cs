using shopapp.entity;
using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;

        }

        public void Create(Category entity)
        {
            _categoryRepository.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryRepository.Delete(entity);
        }

        public List<Category> GetAllPage(int page,int pageSize)
        {
            return _categoryRepository.GetAllPage(3,5);
        }

     

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void Update(Category entity)
        {
            _categoryRepository.Update(entity);
        }

        public List<Category> GetAllCat()
        {
            return _categoryRepository.GetAll();
        }
    }
}
