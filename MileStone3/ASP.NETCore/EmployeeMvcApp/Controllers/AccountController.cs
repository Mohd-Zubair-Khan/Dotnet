using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    public IActionResult Login() => View();

    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        // Dummy check
        if (username == "admin" && password == "admin")
        {
            HttpContext.Session.SetString("IsLoggedIn", "true");
            return RedirectToAction("Index", "Employee");
        }
        ViewBag.Error = "Invalid credentials";
        return View();
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login");
    }
}
