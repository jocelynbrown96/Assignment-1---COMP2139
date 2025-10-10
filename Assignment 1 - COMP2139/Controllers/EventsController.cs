using Assignment_1___COMP2139.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1___COMP2139.Controllers;

public class EventsController : Controller
{
    public IActionResult Index()
    {
        // Retrieve events from the database and pass to the view
        return View();
    }

    // Add actions for Create, Edit, Delete as needed
}


