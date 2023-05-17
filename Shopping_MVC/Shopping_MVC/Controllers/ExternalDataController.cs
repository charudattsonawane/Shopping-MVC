using Microsoft.AspNetCore.Mvc;

namespace Shopping_MVC.Controllers
{
    public class ExternalDataController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }
    }
}
