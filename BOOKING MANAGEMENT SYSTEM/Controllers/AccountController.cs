using BOOKING_MANAGEMENT_SYSTEM.Models;
using Microsoft.AspNetCore.Mvc;

namespace BOOKING_MANAGEMENT_SYSTEM.Controllers
{
  public class AccountController : Controller
  {
    [HttpGet]
    public IActionResult LoginView()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Authenticate(LoginViewModel model)
    {
      if (!ModelState.IsValid)
      {
        return View("LoginView", model);
      }

      // TEMP: hardcoded (replace with DB later)
      if (model.Email == "admin@demo.com" && model.Password == "admin123")
      {
        return RedirectToAction("Dashboard", "Dashboard");
      }

      ViewBag.Error = "Invalid email or password";
      return View("LoginView",model);
    }

  }
}
