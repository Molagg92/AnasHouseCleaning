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
    public ActionResult Details(int id)
    {
      Employee thisEmployee = _db.Employees
                                .Include(employee => employee.ServiceEmployeeEntities)
                                .ThenInclude(join => join.Service)
                                .FirstOrDefault(employee => employee.EmployeeId == id);
      return View(thisEmployee);
    }
    public ActionResult Edit(int id)
    {
      Employee thisEmployee = _db.Employees.FirstOrDefault(employee => employee.EmployeeId == id);
      return View(thisEmployee);
    }
    [HttpPost]
    public ActionResult Edit(Employee employee)
    {
      _db.Employees.Update(employee);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      Employee thisEmployee = _db.Employees.FirstOrDefault(employee => employee.EmployeeId == id);
      return View(thisEmployee);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Employee thisEmployee = _db.Employees.FirstOrDefault(employee => employee.EmployeeId == id);
      _db.Employees.Remove(thisEmployee);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult AddService(int id)
    {
      Employee thisEmployee = _db.Employees.FirstOrDefault(employee => employee.EmployeeId == id);
      ViewBag.ServiceId = new SelectList(_db.Services, "ServiceId", "Name");
      return View(thisEmployee);
    }
    [HttpPost]
    public ActionResult AddService(Employee employee, int serviceId)
    {
      #nullable enable
      ServiceEmployeeEntity? joinEntity = _db.ServiceEmployeeEntities.FirstOrDefault(join => (join.ServiceId == serviceId && join.EmployeeId == employee.EmployeeId));
      #nullable disable
      if (joinEntity == null && serviceId != 0)
      {
        _db.ServiceEmployeeEntities.Add(new ServiceEmployeeEntity() {ServiceId = serviceId, EmployeeId = employee.EmployeeId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = employee.EmployeeId });
    }
    [HttpPost]
    public ActionResult DeleteJoin(int joinId)
    {
      ServiceEmployeeEntity joinEntry = _db.ServiceEmployeeEntities.FirstOrDefault(entry => entry.ServiceEmployeeEntityId == joinId);
      _db.ServiceEmployeeEntities.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  } 
}


