using Microsoft.AspNetCore.Mvc;

namespace BOOKING_MANAGEMENT_SYSTEM.Controllers
{
  public class Dashboard : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
