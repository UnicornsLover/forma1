using Forma1projekt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1projekt.Service
{
    /// <summary>
    /// Service rééteg feladata az üzleti logika megvalósítása
    /// Kapcsolatot teremt a Controller és a Repository réteg között
    /// </summary>
    class TeamService
    {
        Forma1 f1Repository;

        public TeamService()
        {
            f1Repository = new Forma1();
        }

        public void addTeam(string teamName)
        {
            
        }
    }
}
