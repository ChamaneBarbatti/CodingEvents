using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{

    public class EventsController : Controller
    {
         private static readonly Dictionary<string,string> Events = new Dictionary<string, string>();
        [HttpGet]
        public IActionResult Index()
        {
           
            
            ViewBag.events = Events;
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult NewEvent(string name, string desc)
        {
            Events.Add(name, desc);
            return Redirect("/Events");
        }
    }
}
