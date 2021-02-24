using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Survey.Business.Abstract;
using Survey.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Survey.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserService userService;

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login( )
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginUserModel userLoginModel)
        {
            var user = userService.ValidUser(userLoginModel.UserName, userLoginModel.Password);
            if (user != null)
            {
               // yetkilendir.1

               List<Claim> claims = new List<Claim>(); // şifre tutulmaz.
               claims.Add(new Claim(ClaimTypes.Name, user.UserName));
                claims.Add(new Claim(ClaimTypes.Role, user.Role.ToString()));

               ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
               ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
               await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal); // giriş
               return Redirect("/");
            }
            TempData["LoginErrorMessage"] = "Kullanıcı adını veya parolayı yanlış!";
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(User RegisterUser)
        {
            if (ModelState.IsValid)
            {
                bool IsSaved = userService.CheckUser(RegisterUser);

                if (IsSaved != true)
                {
                    userService.AddUser(RegisterUser);
                    return RedirectToAction(nameof(Login));
                }
                TempData["Message"] = "Aynı kullanıcı adında hesap var!";

            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
