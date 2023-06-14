using Microsoft.AspNetCore.Mvc;

namespace NetAndVue.Controllers
{
   
    public class VueController : Controller
    {
        public  IActionResult Index()
        {
            return View();
        }
    }
}
