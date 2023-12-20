using Microsoft.AspNetCore.Mvc;
using Capstone.Models;
using System.Collections.Generic;
using System.Linq;

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
      Employee[] empls =_db.Employees.ToArray();
      Service[] servs = _db.Services.ToArray();
      Dictionary<string,object[]> model = new Dictionary<string, object[]>();
      model.Add("employees", empls);
      model.Add("services", servs);
      return View(model);
    }
  }
}