using Forma1projekt.Exceptionmy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1projekt.Repository
{
    /// <summary>
    /// A F1 nyilvántartó osztály, összes csapat a F1-be
    /// Szolgáltatást nyújt a service rétegnek
    /// </summary>
    class Forma1
    {
        /// <summary>
        /// F1 csapatok ezt tárolja
        /// </summary>
        List<Team> teams;

        public  Forma1()
        {
            teams = new List<Team>();
        }

        /// <summary>
        /// A Teamet hozzáadja a csapatok listájához
        /// </summary>
        /// <param name="A cspat listájához hozzáadott csapat"></param>
        public void add(Team t)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba a team nincs példányosítva.");
            else
                teams.Add(t);
        }

        public List<Team> getTeams()
        {
            if (teams == null)
            {
                throw new F1Exception("Végzetes hiba a team nincs példányosítva.");
            }  
            else
            {
                return teams;
            }
        }

        /// <summary>
        /// Létrehoz eg csapatoto egy név alapján
        /// </summary>
        /// <param name="Csapat név"></param>
        public void Add( string name)
        {
            if (teams == null)
                throw new F1Exception("Végzetes hiba a team nincs példányosítva.");
            else
            {
                Team t = new Team(name);
                teams.Add(t);
            }
            
        }
    }
}
