using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The treat's name can't be empty!")]
    public string Name { get; set; }

    [Required(ErrorMessage = "The treat's price can't be empty!")]
    public int Price { get; set; }

    // [Range(1, 10, ErrorMessage = "You must give a rating on a scale of 1 to 10.")]
    // public int Rating { get; set; }
    public List<FlavorTreat> JoinEntities { get;}
    public ApplicationUser User { get; set; }
  }
}