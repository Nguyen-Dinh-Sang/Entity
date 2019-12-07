using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Models;
using Entity.Services;
using Microsoft.AspNetCore.Mvc;

namespace Entity.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser iUser;

        public UserController(IUser iUser)
        {
            this.iUser = iUser;
        } 

        public IActionResult Index()
        {
            return View(iUser.getUsers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                iUser.add(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        [Route("User/Delete/{maUser}")]
        public IActionResult Delete(int? maUser)
        {
            if(maUser == null)
            {

            } else
            {
                iUser.remove(maUser);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}