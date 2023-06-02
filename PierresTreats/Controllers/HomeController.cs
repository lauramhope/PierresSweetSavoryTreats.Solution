using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierresTreats.Controllers
{
    public class HomeController : Controller
    {
      private readonly PierresTreatsContext _db;
      private readonly UserManager<ApplicationUser> _userManager;

      public HomeController(UserManager<ApplicationUser> userManager, PierresTreatsContext db)
      {
        _userManager = userManager;
        _db = db;
      }

      [HttpGet("/")]
      public async Task<ActionResult> Index()
      {
        Treats[] treats = _db.Treats.ToArray();
        Dictionary<string, object[]> model = new Dictionary<string, object[]>();
        model.Add("treats", treats);
        string userId = this._userManager.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
        if (currentUser != null)
        {
          Flavor[] flavors = _db.Flavors
                          .Where(entry => entry.User.Id == currentUser.Id)
                          .ToArray();
          model.Add("flavors", flavors);
        }
        return View(model);
      }
    }
}