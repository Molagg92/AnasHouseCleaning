using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Capstone.Models
{
  public class Employee
  {
    public int EmployeeId { get; set; }
    [Required(ErrorMessage = "The Employee's name can't be empty!")]
    public string Name { get; set; }
    public int Phone { get; set; }
    public List<ServiceEmployeeEntity> ServiceEmployeeEntities { get; set; }

  }
    
}
