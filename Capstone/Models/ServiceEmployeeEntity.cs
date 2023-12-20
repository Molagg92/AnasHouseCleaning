using System.Collections.Generic;
namespace Capstone.Models;

public class ServiceEmployeeEntity
{
   public int ServiceEmployeeId { get; set; }
  public int EmployeeId { get; set; }
  public Employee Employee { get; set; }
  public int ServiceId { get; set; }
  public Service Service { get; set; }
}