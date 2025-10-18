using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class EmployeeController : Controller
{
    static List<Employee> employees = new List<Employee>();

    private bool IsLoggedIn() => HttpContext.Session.GetString("IsLoggedIn") == "true";
    private IActionResult NotLoggedIn() => RedirectToAction("Login", "Account");

    public IActionResult Index()
    {
        if (!IsLoggedIn()) return NotLoggedIn();
        return View(employees);
    }

    public IActionResult Create()
    {
        if (!IsLoggedIn()) return NotLoggedIn();
        return View();
    }

    [HttpPost]
    public IActionResult Create(Employee emp)
    {
        if (!IsLoggedIn()) return NotLoggedIn();
        employees.Add(emp);
        return RedirectToAction("Index");
    }

    /* Similarly: Edit, Delete, Details with IsLoggedIn() check */
}

