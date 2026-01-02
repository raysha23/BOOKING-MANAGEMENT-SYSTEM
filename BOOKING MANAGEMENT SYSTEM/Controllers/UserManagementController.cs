using Microsoft.AspNetCore.Mvc;

namespace BOOKING_MANAGEMENT_SYSTEM.Controllers
{
  public class UserManagement : Controller
  {
    public IActionResult Index()
    {
      ViewBag.ActivePage = "UserManagement";
      return View();
    }
  }
}
