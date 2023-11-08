using BusinessLayer.Concrete;
using Confident.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Confident.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel p)
        {
            if (!p.IsAcceptTheContract)
            {
                ModelState.AddModelError("IsAcceptTheContract",
                    "Sayfamıza kayıt olabilmek için gizlilik sözleşmesini kabul etmeniz gerekmektedir.");
                return View(p);
            }

            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Email = p.Email,
                    UserName = p.UserName,
                    Isim = p.Name,
                    Soyisim = p.Surname,
                    Sifre = p.Password,
                    PhoneNumber = p.Phone,
                    Status = false,
                    Pozisyon = "Gayrimenkul Danışmanı"
                };


                var result = await _userManager.CreateAsync(user, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }
    }
}
