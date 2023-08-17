using Microsoft.AspNetCore.Mvc;


namespace crud_back.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
