using Forma1projekt.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1projekt.Controller
{
    class F1Controller
    {
        TeamService teamService;

        public void addTeamToF1(string teamName)
        {
            teamService.addTeam(teamName);
        }

        /// <summary>
        /// Contorller réteg kapcsolatot teremt a GUI és a Service réteg között
        /// Feladata a bemenő adatok vizssgálata
        /// Feladata a megjelenítendő adatok átalakítása a GUI-ba
        /// Feladata a programozónak szánt hibaüzenetek megjelenítése
        /// </summary>
        public F1Controller()
        {
            teamService = new TeamService();
        }
    }
}
