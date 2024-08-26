using EmployeesManagement.Context;
using EmployeesManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesManagement.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
       
        [ValidateAntiForgeryToken]
      
        public async Task<IActionResult> Create([Bind("Name")] ProjectAddModel model)
        {
            if (ModelState.IsValid)
            {
                // Kullanıcıdan alınan verileri Project modeline dönüştür
                var project = new Project
                {
                    Name = model.Name
                };

                // Veritabanına ekle
                _context.Projects.Add(project);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Projects");
            }
            return View(model); // Hata varsa tekrar formu göster
        }


    }
}
