using Microsoft.AspNetCore.Mvc;

namespace BOOKING_MANAGEMENT_SYSTEM.Controllers
{
  public class AccountController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Login(string username, string password)
    {
      if (username == "admin" && password == "1234")
      {
        return RedirectToAction("Index", "Home");
      }

      ViewBag.Error = "Invalid username or password";
      return View();
    }

  }
}
