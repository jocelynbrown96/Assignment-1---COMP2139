
using Microsoft.AspNetCore.Mvc;


namespace Assignment_1___COMP2139.Controllers;

public class CategoriesController : Controller
{
    public IActionResult Index()
    {
        // Retrieve events from the database and pass to the view
        return View();
    }

    // Add actions for Create, Edit, Delete as needed
}