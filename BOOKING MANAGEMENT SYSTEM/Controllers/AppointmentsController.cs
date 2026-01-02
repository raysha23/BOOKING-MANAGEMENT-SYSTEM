using Microsoft.AspNetCore.Mvc;

namespace BOOKING_MANAGEMENT_SYSTEM.Controllers
{
  public class AppointmentsController : Controller
  {
    public IActionResult Appointments()
    {
      ViewBag.ActivePage = "Appointments";
      return View("Appointments");
    }
  }
}
