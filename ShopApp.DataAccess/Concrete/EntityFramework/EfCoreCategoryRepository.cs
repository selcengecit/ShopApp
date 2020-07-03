using shopapp.entity;
using ShopApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EntityFramework
{
    public class EfCoreCategoryRepository : EFCoreGenericRepository<Category, ShopContext>, ICategoryRepository
    {
       
    }
}
