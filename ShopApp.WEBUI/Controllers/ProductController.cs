using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using shopapp.entity;
using ShopApp.Business.Abstract;
using ShopApp.WEBUI.Models;

namespace ShopApp.WEBUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }
        public IActionResult List(int page = 1)
        {

            const int pageSize = 10;
            var prdListViewModel = new ProductListViewModel

            {
                pageInfo = new PageInfo()
                {
                    TotalItems = _productService.GetCountByProduct(),
                    CurrentPage = page,
                    ItemsPerpage = pageSize
                },
                Products = _productService.GetAllPrList(page, pageSize)

            };
            return View(prdListViewModel);
        }

        public IActionResult Details(int? id)
        {



            if (id == null)
            {
                return NotFound();
            }
            Product product = _productService.GetDetails((int)id);

            if (product == null)
            {
                return NotFound();
            }

            return View(new ProductDetailModel
            {
                Product = product


            });

        }
        public IActionResult Search(string q)
        {
            var prdListViewModel = new ProductListViewModel
            {
                Products = _productService.GetSearchProduct(q).ToList()
            };
            return View(prdListViewModel);

        }


    }

}

