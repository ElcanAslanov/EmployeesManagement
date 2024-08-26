using EmployeesManagement.Context;
using EmployeesManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Logout()
        {
            // Your logout logic here
            // For example, clearing authentication cookies

            // Redirect to the login page
            return RedirectToAction("Login", "Account");
        }
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users
                                   .FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);

                if (user != null)
                {
                    // Kullanıcıyı oturum açtı olarak işaretleyin
                    // Oturum yönetimi kodları buraya eklenecek
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Geçersiz kullanıcı adı veya şifre");
            }

            return View(model);
        }
    }

}
