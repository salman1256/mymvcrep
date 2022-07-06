using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCore.Models;

namespace WebAppCore.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Index()
        {
            List<Player> lstPlayers = new List<Player>
        {
        new Player{ PId=1,PName="MSD",PAvg=56.90,PTeam="CSK"},
             new Player{ PId=1,PName="Bumrah",PAvg=56.90,PTeam="MI"},
             new Player{ PId=4,PName="Shami",PAvg=56.90,PTeam="Punjab"},
             new Player{ PId=3,PName="Umran",PAvg=56.90,PTeam="SRH"},
             new Player{ PId=2,PName="Vijay",PAvg=56.90,PTeam="CSK"},};
            return View(lstPlayers);
        }
    }
}
