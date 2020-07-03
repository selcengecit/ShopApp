using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Newtonsoft.Json;
using shopapp.entity;
using ShopApp.Business.Abstract;
using ShopApp.WEBUI.Identity;
using ShopApp.WEBUI.Models;

namespace ShopApp.WEBUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;


        public AdminController(IProductService productService, ICategoryService categoryService, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _productService = productService;
            _categoryService = categoryService;
            _roleManager = roleManager;
            _userManager = userManager;

        }
        public IActionResult RoleList()
        {
            return View(_roleManager.Roles);
        }
        public async Task<IActionResult> RoleEdit(string id)
        {

            var role = await _roleManager.FindByIdAsync(id);
            var members = new List<User>();
            var nonmembers = new List<User>();


            foreach (var user in _userManager.Users.ToList())
            {
                var list = await _userManager.IsInRoleAsync(user, role.Name) ? members : nonmembers;
                list.Add(user);
            }
            var model = new RoleDetail()
            {
                Role = role,
                Member = members,
                Nonmember = nonmembers
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel model)
        {

            if (model != null)
            {
                foreach (var userId in model.IdsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.AddToRoleAsync(user, model.RoleName);
                        if (result.Succeeded)
                        {
                            ViewBag.Result = "Role Güncellendi!";
                        }


                    }
                }



                foreach (var userId in model.IdsToDelete ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (result.Succeeded)
                        {
                            ViewBag.Result = "Role Silindi!";

                        }

                    }



                }

            }

            return Redirect("/Admin/RoleEdit/" + model.RoleId);
        }
        public IActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            if (model != null)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(model.Name));
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");

                }
            }
            return View();
        }


        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductModel model)
        {
            var entity = new Product()
            {
                ProductName = model.ProductName,
                UnitPrice = model.UnitPrice,
                CategoryID = model.CategoryID



            };
            _productService.Create(entity);

            var msg = new AlertMessage()
            {
                Message = $"{entity.ProductName} isimli ürün eklendi!",
                AlertType = "success"


            };
            TempData["message"] = JsonConvert.SerializeObject(msg);

            return RedirectToAction("List", "Product");
        }
        public IActionResult EditProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _productService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var product = new ProductModel()// paketlenip gönderildi!
            {
                ProductID = entity.ProductID,
                ProductName = entity.ProductName,
                UnitPrice = entity.UnitPrice,
                CategoryID = entity.CategoryID



            };

            return View(product);
        }
        [HttpPost]
        public IActionResult EditProduct(ProductModel model) //paketten döndü!//
        {
            var entity = _productService.GetById(model.ProductID);

            entity.ProductName = model.ProductName;
            entity.UnitPrice = model.UnitPrice;
            entity.CategoryID = model.CategoryID;




            _productService.Update(entity);
            var msg = new AlertMessage()
            {
                Message = $"{entity.ProductName} isimli ürün güncellendi!",
                AlertType = "warning"


            };
            TempData["message"] = JsonConvert.SerializeObject(msg);

            return RedirectToAction("List", "Product");
        }


        public IActionResult DeleteProduct(int id)
        {
            var entity = _productService.GetById(id);

            _productService.Delete(entity);
            var msg = new AlertMessage()
            {
                Message = $"{entity.ProductName} isimli ürün silindi!",
                AlertType = "danger"


            };
            TempData["message"] = JsonConvert.SerializeObject(msg);
            return RedirectToAction("List", "Product");
        }

        public IActionResult CategoryList()
        {
            return View(new CategoryListViewModel
            {
                Categories = _categoryService.GetAllCat()
            });
        }

        public IActionResult CreateCategories()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategories(CategoryModel model)
        {
            var entity = new Category()
            {
                CategoryName = model.CategoryName


            };
            _categoryService.Create(entity);

            var msg = new AlertMessage()
            {
                Message = $"{entity.CategoryName} isimli kategori eklendi!",
                AlertType = "success"


            };
            TempData["message"] = JsonConvert.SerializeObject(msg);

            return RedirectToAction("CategoryList", "Admin");
        }
        public IActionResult EditCategories(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _categoryService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var category = new CategoryModel()// paketlenip gönderildi!
            {
                CategoryID = entity.CategoryID,
                CategoryName = entity.CategoryName

            };

            return View(category);
        }
        [HttpPost]
        public IActionResult EditCategories(CategoryModel model) //paketten döndü!//
        {
            var entity = _categoryService.GetById(model.CategoryID);

            entity.CategoryName = model.CategoryName;


            _categoryService.Update(entity);
            var msg = new AlertMessage()
            {
                Message = $"{entity.CategoryName} isimli kategori güncellendi!",
                AlertType = "warning"


            };
            TempData["message"] = JsonConvert.SerializeObject(msg);

            return RedirectToAction("CategoryList", "Admin");
        }
        public IActionResult DeleteCategory(int id)
        {
            var entity = _categoryService.GetById(id);

            _categoryService.Delete(entity);
            var msg = new AlertMessage()
            {
                Message = $"{entity.CategoryName} isimli kategori silindi!",
                AlertType = "danger"


            };
            TempData["message"] = JsonConvert.SerializeObject(msg);
            return RedirectToAction("CategoryList", "Admin");
        }
        public IActionResult UserList()
        {
            return View(_userManager.Users);
        }

        public async Task<IActionResult> UserEdit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var selectedRoles = await _userManager.GetRolesAsync(user);
                var roles = _roleManager.Roles.Select(i => i.Name);
                ViewBag.Roles = roles;

                var model = new UserDetail()
                {
                    UserId = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserName = user.UserName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    SelectedRoles = selectedRoles

                };

                return View(model);

            }
            return RedirectToAction("UserList");


        }
        [HttpPost]
        public async Task<IActionResult> UserEdit(UserDetail model, string[] selectedRoles)
        {
            if (model!=null)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user!=null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    user.EmailConfirmed = model.EmailConfirmed;
                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        selectedRoles = selectedRoles ?? new string[] { };
                        await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles).ToArray<string>());
                        await _userManager.RemoveFromRolesAsync(user,userRoles.Except(selectedRoles).ToArray<string>());
                        return RedirectToAction("UserList");
                    }

                }
                return RedirectToAction("UserList");


            }
            return View(model);

        }
    }
}
