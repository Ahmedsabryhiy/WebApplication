using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
