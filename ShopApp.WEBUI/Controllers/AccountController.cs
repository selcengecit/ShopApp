using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Shopapp.Entity;
using ShopApp.Business.Abstract;
using ShopApp.WEBUI.EmailServices;
using ShopApp.WEBUI.Identity;
using ShopApp.WEBUI.Models;

namespace ShopApp.WEBUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;
        private ICartService _cartService;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender, ICartService cartService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _cartService = cartService;

        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                });
                await _emailSender.SendEmailAsync(model.Email, "Hesabınızı onaylayın", $"Lütfen Email hesabınızı onaylamak için linke <a href='https://localhost:44307{url}'> tıklayınız</a>");

                return RedirectToAction("Login", "Account");
            }
            else
            {
                ViewBag.Message = "Bilgileri hatalı doldurdunuz. Lütfen tekrar deneyiniz.";
                return View(model);
            }

        }

        public IActionResult Login(string ReturnUrl = null)
        {

            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl

            });
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // var user = await _userManager.FindByNameAsync(model.UserName);
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ViewBag.Message = "Kullanıcı adı bulunmamaktadır. Lütfen Tekrar deneyiniz!";
                return View(model);
            }
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ViewBag.Confirm = "Hesabınız onaylanmadı! Lütfen mail adresinize gelen linkten onaylama işlemi yapın";
                return View(model);

            }
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
            if (result.Succeeded)

            {
                return Redirect(model.ReturnUrl ?? "~/");
                //return RedirectToAction("CreateProduct", "Admin");

            }
            else
            {
                return View(model);
            }

        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");

        }

        public async Task<IActionResult> ConfirmEmail(string userId,string Token)
        {
            if (userId == null || Token==null)
            {
                ViewBag.Token = "Geçersiz token";
                return View();

            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, Token);
                if (result.Succeeded)
                {
                    _cartService.InitializeCart(user.Id);
                    ViewBag.Token = "Hesabınız onaylandı";
                    return View();
                }

            }
            ViewBag.Token = "Hesabınız onaylanmadı";
            return View();

        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            if(string.IsNullOrEmpty(Email))
            {
                return View();
            }
            var user = await _userManager.FindByEmailAsync(Email);
            if (user==null)
            {
                ViewBag.Message = "Kullanıcı bulunamadı!";
                return View();

            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "Account", new { 
                userId=user.Id,
                token=code
            
            });
            await _emailSender.SendEmailAsync(Email, "ResetPassword", $"Lütfen şifenizi yenilemek için linke <a href='https://localhost:44307{url}'> tıklayınız</a>");


            return View();
        }
        public IActionResult ResetPassword(string userId, string token)
        {
            if(userId==null || token == null)
            {
                ViewBag.Message = "Bilgileriniz geçersizdir.";
                return RedirectToAction("Index", "Home");
            }
            var model = new ResetPasswordModel
            {
              Token=token
            };
           
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user==null)
            {
                ViewBag.Message = "Kullanıcı bulunamadı.";
                return RedirectToAction("Index", "Home");
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
            if (result.Succeeded)
            {
                ViewBag.Message = "Parolanız yenilenmiştir.";
                return RedirectToAction("Login", "Account");

            }

            return View(model);
        }
        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}
