using EntityFramework_Slider.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework_Slider.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
      public IActionResult Register()
      {
            return View();
      }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return View(model);
        }
    }
}
