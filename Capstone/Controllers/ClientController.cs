using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Capstone.Models;

namespace Capstone.Controllers
{
  public class ClientController : Controller
  {
    private readonly CapstonePageContext _db;
    public ClientController(CapstonePageContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      if (!ModelState.IsValid)
      {
        return View(client);
      }
      else
      {
        _db.Clients.Add(client);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }
   } 
}