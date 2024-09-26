using Microsoft.AspNetCore.Mvc;

namespace SocialMedia.PLL.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
