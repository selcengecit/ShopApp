using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        Product GetDetails(int id);
        List<Product> GetAllPrList(int page,int pageSize);
        List<Product> GetAll1();
        int GetCountByProduct();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        List<Product> GetSearchProduct(string searchString);

    }
}
