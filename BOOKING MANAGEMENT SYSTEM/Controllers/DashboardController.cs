using Microsoft.AspNetCore.Mvc;

namespace BOOKING_MANAGEMENT_SYSTEM.Controllers
{
  public class DashboardController : Controller
  {
    public IActionResult Dashboard()
    {
      ViewBag.ActivePage = "Dashboard";
      return View("Dashboard");
    }
  }

}
