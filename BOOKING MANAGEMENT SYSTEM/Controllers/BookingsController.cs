using Microsoft.AspNetCore.Mvc;

namespace BOOKING_MANAGEMENT_SYSTEM.Controllers
{
  public class BookingsController : Controller
  {
    public IActionResult Index()
    {

      ViewBag.ActivePage = "Bookings";
      return View();
    }
  }
}
