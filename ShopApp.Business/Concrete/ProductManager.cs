using shopapp.entity;
using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
      
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            // iş kuralları
            _productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll1()
        {
           return  _productRepository.GetAll();
        }

        public List<Product> GetAllPrList(int page, int pageSize)
        {
            return _productRepository.GetAllPage(page, pageSize);
        }

       

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public int GetCountByProduct()
        {
            return _productRepository.GetCountByProduct();
        }

        public Product GetDetails(int id)
        {
            return _productRepository.GetDetails(id);
        }

        public List<Product> GetSearchProduct(string searchString)
        {
            return _productRepository.GetSearchResult(searchString);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }
    }
}
