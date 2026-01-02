using Microsoft.AspNetCore.Mvc;

namespace BOOKING_MANAGEMENT_SYSTEM.Controllers
{
  public class EventsController : Controller
  {
    public IActionResult Events()
    {
      ViewBag.ActivePage = "Events";
      return View();
    }
  }
}
