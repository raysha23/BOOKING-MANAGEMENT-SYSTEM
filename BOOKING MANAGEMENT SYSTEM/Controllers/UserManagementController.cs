using Microsoft.AspNetCore.Mvc;

namespace BOOKING_MANAGEMENT_SYSTEM.Controllers
{
  public class UserManagementController : Controller
  {
    public IActionResult UserManagement()
    {
      ViewBag.ActivePage = "UserManagement";
      return View();
    }
  }
}
