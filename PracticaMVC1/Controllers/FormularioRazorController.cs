using Microsoft.AspNetCore.Mvc;

namespace PracticaMVC1.Controllers
{
    public class FormularioRazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
