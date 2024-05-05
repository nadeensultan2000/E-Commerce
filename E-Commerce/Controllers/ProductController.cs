using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
