using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Capstone.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    [Required(ErrorMessage = "The Client's name can't be empty!")]
    public string Name { get; set; }
    public List<Service> Services { get; set; }
  }
}