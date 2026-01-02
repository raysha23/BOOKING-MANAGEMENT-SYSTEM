using Microsoft.AspNetCore.Mvc;

namespace BOOKING_MANAGEMENT_SYSTEM.Controllers
{
  public class ReportsController : Controller
  {
    public IActionResult Index()
    {
      ViewBag.ActivePage = "Reports";
      return View();
    }
  }
}
