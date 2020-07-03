using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        List<Category> GetAllPage(int page, int pageSize);
        List<Category> GetAllCat();
        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
    }
}
