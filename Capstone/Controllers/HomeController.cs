using Microsoft.AspNetCore.Mvc;
using Capstone.Models;
using System.Collections.Generic;
using System.Linq;
using Capstone.ViewModels; 

namespace Capstone.Controllers
{
    public class HomeController : Controller
    {
      private readonly CapstonePageContext _db;
      public HomeController(CapstonePageContext db)
      {
        _db = db;
      }

    [HttpGet("/")]
    public ActionResult Index()
    { 
      var model = new HomeIndexViewModel
      {
          Employees = _db.Employees.ToArray(),
          Services = _db.Services.ToArray(),
          Clients = _db.Clients.ToArray()
      };
      return View(model);
    }
} 
}