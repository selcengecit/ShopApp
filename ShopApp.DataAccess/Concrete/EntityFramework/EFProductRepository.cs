using Microsoft.EntityFrameworkCore;
using shopapp.entity;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShopApp.DataAccess.Concrete.SQL
{
    public class EFProductRepository : EFCoreGenericRepository<Product, ShopContext>, IProductRepository
    {
        public int GetCountByProduct()
        {
            using(var context= new ShopContext())
            {
                return context.Products.Count();
            }
        }

        public Product GetDetails(int id)
        {

            using (var context = new ShopContext())
            {

                return context.Products.Where(i => i.ProductID == id).FirstOrDefault();

                




                

                //var result = (from prd in context.Products
                //              join ctg in context.Categories on prd.CategoryID equals ctg.CategoryID
                //              where prd.ProductID == id
                //              select new Product());



               // return result.FirstOrDefault();


            }

        }

        public List<Product> GetSearchResult(string searchString)
        {
            using (var context = new ShopContext())
            {
                return context.Products.Where(i => i.ProductName.ToLower().Contains(searchString.ToLower())).ToList();
            }
        }
    }
}
