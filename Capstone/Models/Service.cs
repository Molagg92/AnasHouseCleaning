using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Capstone.Models
{
  public class Service
  {
    public int ServiceId { get; set; }
    [Required(ErrorMessage = "The Employee's name can't be empty!")]
    public string Name { get; set; }
    public List<ServiceEmployeeEntity> ServiceEmployeeEntities{ get; set; }
  }
}