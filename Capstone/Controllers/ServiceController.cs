using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Capstone.Models;

namespace Caspstone.Controllers
{
  public class ServiceController : Controller
  {
    private readonly CapstonePageContext _db;
    public ServiceController(CapstonePageContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Service> model = _db.Services.ToList();
      return View(model);
    }

    [HttpPost]
    public ActionResult Create(int clientId, string serviceName)
    {
      var client = _db.Clients.FirstOrDefault(c => c.ClientId == clientId);
      if (client == null)
      {
        return RedirectToAction("Index", "Home");
      }
      var newService = new Service
      {
        Name = serviceName,
        ClientId = clientId  
      };
      _db.Services.Add(newService);
      _db.SaveChanges();
      return RedirectToAction("Details", "Client", new { id = clientId });
    }
    public ActionResult Details(int id)
    {
      var service = _db.Services
          .Include(s => s.ServiceEmployeeEntities)
          .ThenInclude(se => se.Employee)
          .FirstOrDefault(s => s.ServiceId == id);

      if (service == null)
      {
          return NotFound();
      }

      return View(service);
    }
  }
}

