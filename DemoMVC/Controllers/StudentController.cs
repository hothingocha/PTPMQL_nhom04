using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class StudentController : Controller
    { 
        // GET: /Student/
        public IActionResult Index()
        {
            return View();
        } 
        // GET: /Student/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}


