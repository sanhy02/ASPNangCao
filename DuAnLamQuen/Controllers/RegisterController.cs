using DuAnLamQuen.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace DuAnLamQuen.Controllers
{
    public class RegisterController : Controller
    {
        private IWebHostEnvironment hosting;
        public RegisterController(IWebHostEnvironment _hosting)
        {
            hosting = _hosting;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult XuLy(PersonViewModel m, IFormFile FHinh)
        {
            //tra ve view cho client
            if (FHinh != null) {
                string filename = Guid.NewGuid().ToString() + Path.GetExtension(FHinh.FileName);
                string path = Path.Combine(hosting.WebRootPath, "images");
                using (var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                {
                    //sao chep len server
                    FHinh.CopyTo(filestream);
                }
                m.Picture = filename;
            }
            return View(m);
        }
    }
}
