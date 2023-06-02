using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "The flavor's description can't be empty!")]
    public string FlavorDescription { get; set; }
    public List<FlavorTreat> JoinEntities { get;} 
    public ApplicationUser User { get; set; }
  }
}