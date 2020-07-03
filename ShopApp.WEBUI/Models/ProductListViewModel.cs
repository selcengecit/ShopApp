using shopapp.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WEBUI.Models
{
    public class PageInfo
    {
        public int TotalItems { get; set; } /// veritabanında kaç ürün var
        public int ItemsPerpage { get; set; } // sayfa başına kaç ürün gosterılcek
        public int CurrentPage { get; set; } // şuanki bulundugum sayfa

       public int TotalPages()  // kac sayfa olacak???
        {
            decimal sayi = ((decimal)TotalItems / ItemsPerpage);
            return (int)Math.Ceiling(sayi);
        }
    }
    public class ProductListViewModel
    {
        public PageInfo pageInfo { get; set; }
        public List<Product> Products { get; set; }

       
    }
}
