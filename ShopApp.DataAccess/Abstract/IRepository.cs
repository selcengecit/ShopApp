﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Abstract
{
   public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAllPage(int page, int pageSize);
        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
