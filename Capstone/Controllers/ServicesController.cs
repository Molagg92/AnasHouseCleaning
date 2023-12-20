using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Capstone.Models;

namespace Capstone.Controllers
{
  public class ServicesController : Controller
  {
    private readonly CapstonePageContext _db;
    public ServicesController(CapstonePageContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Service> model = _db.Services.ToList();
      return View(model);
    }

   } 
}


