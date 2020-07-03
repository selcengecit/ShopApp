using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace ShopApp.DataAccess.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        Product GetDetails(int id);
        int GetCountByProduct();
        List<Product> GetSearchResult(string searchString);



    }
}
