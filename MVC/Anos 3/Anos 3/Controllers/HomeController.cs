using Anos_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Anos_3.Controllers
{
    public class HomeController : Controller
    {
        MyDbContext db = new MyDbContext();
        // GET: Home
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Email,string Password)
        {
            User obj = db.Users.FirstOrDefault(i => i.Email == Email && i.Password == Password);
            if(obj==null)
            {
                ViewBag.msg = "Your Username or Password is incorrect";
                return View();
            }
            else
            {
                RedirectToAction("Index", "Users");
            }
        }
}