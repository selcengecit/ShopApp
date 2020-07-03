using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WEBUI.WiewComponent
{
    public class CategoriesViewComponent:ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoriesViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;

        }
        public IViewComponentResult Invoke()
        {
            return View(_categoryService.GetAllPage(1, 5));
        }
    }
}
