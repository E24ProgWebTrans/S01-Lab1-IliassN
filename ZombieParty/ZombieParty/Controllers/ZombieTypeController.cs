using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZombieParty.Models;

namespace ZombieParty.Controllers
{
    public class ZombieTypeController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.MaListe = new List<Zombietype>()
    {
            new Zombietype(){TypeName= "Virus", Id=1},
        new Zombietype(){TypeName= "Contact", Id=2}
    };

            return View();
        }
    }
}
