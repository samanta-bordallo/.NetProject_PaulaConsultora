using Microsoft.AspNetCore.Mvc;

namespace testeSiteIrmaMassa.Controllers
{
    public class AboutMeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
