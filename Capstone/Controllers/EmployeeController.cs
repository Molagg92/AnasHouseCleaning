using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Capstone.Models;

namespace Capstone.Controllers
{
  public class EmployeeController : Controller
  {
    private readonly CapstonePageContext _db;
    public EmployeeController(CapstonePageContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Employee> model = _db.Employees.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Employee employee)
    {
      if (!ModelState.IsValid)
      {
        return View(employee);
      }
      else
      {
        _db.Employees.Add(employee);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }
   } 
}


