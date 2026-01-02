using Microsoft.AspNetCore.Mvc;

namespace BOOKING_MANAGEMENT_SYSTEM.Controllers
{
  public class EventsController : Controller
  {
    public IActionResult Index()
    {
      ViewBag.ActivePage = "Events";
      return View();
    }
  }
}
