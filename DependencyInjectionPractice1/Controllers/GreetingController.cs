using DependencyInjectionPractice1.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionPractice1.Controllers
{
    public class GreetingController : Controller
    {

        private readonly IGreetingServices _greetingServices;

        public GreetingController(IGreetingServices greetingServices)
        {
            _greetingServices = greetingServices;
        }

        public IActionResult Index()
        {

            ViewBag.Greetings = _greetingServices.Greet("Kishore");
            return View();
        }
    }
}
