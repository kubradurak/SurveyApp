using Microsoft.AspNetCore.Mvc;
using Survey.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.WebUI.Controllers
{
    public class UsersController : Controller
    {
        private IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Index()
        {
            var users = userService.GetUsers();
            return View(users);
        }
    }
}
