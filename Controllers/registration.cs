using Microsoft.AspNetCore.Mvc;
using RegisterForm_InCore.Models;

namespace RegisterForm_InCore.Controllers
{
    public class registration : Controller
    {
        private readonly ApplicationUser _auc;
        public registration(ApplicationUser auc)
        {
            _auc = auc;
        }
         public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(User uc)
        {
            _auc.Add(uc);
            _auc.SaveChanges();
            ViewBag.message = "The user " + uc.UserName + " is registered successfully";
            return View();
        }
    }
}
