using Assignment_MVC_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVC_2.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult GetMovie(int id , string name , Movie emp)
        {
            return Content($"Movie with id : {id} and name : {name}", "text/html");
        }
        public IActionResult Index()
        {
            return RedirectToAction(nameof(GetMovie), new { id = 22 });
        }
        public ViewResult Hamada()
        {
            return View();
        }
    }
}
