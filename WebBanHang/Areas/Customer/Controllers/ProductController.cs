using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebBanHang.Areas.Customer.Models;
using WebBanHang.Models;

namespace WebBanHang.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProductController : Controller
    {
        private ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int catid=1)
        {
            var dsLoai = _db.Categories.Select(c => new CategoryViewModel
            {
                Id = c.Id,
                Name = c.Name,
                TotalProduct = _db.Products.Count(p => p.CategoryId == c.Id)
            }).ToList();
            var dsSanPham = _db.Products.Where(p =>  p.CategoryId == catid).ToList();
            ViewBag.DsLoai = dsLoai;
            ViewBag.CATEGORY_NAME = _db.Categories.Find(catid).Name;
            return View(dsSanPham);
        }

        public IActionResult LoadPartial(int catid = 1)
        {
            // action tra ve view khong co layout(chi hien thi danh sach can xem)  
            var dsSanPham = _db.Products.Where(p => p.CategoryId == catid).ToList();
            ViewBag.CATEGORY_NAME = _db.Categories.Find(catid).Name;
            return PartialView("_ProductPartial", dsSanPham);
        }

    }
}
