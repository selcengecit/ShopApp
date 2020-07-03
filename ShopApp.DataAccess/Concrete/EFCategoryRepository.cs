using shopapp.entity;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.DataAccess.Concrete
{
    public class EFCategoryRepository : EFCoreGenericRepository<Category, ShopContext>, ICategoryRepository
    {


    }
}

