using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        } 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
