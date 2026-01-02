using Microsoft.AspNetCore.Mvc;

namespace BOOKING_MANAGEMENT_SYSTEM.Controllers
{
  public class Dashboard : Controller
  {
    public IActionResult Index()
    {
      ViewBag.ActivePage = "Dashboard";
      return View();
    }
  }
}
