using Forma1projekt.Exceptionmy;
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
            try
            {
                Team t = new Team(teamName);
                f1Repository.add(t);
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }
    }
}
