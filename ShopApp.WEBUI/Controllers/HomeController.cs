using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using ShopApp.WEBUI.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WEBUI.Controllers
{
    public class HomeController:Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            this._productService = productService;
        }
        public IActionResult Index()
        {

            var prdListViewModel = new ProductListViewModel
            {
                Products = _productService.GetAllPrList(3,5)
            };
            return View(prdListViewModel);
        }
        
    }
}
