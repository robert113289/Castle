using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Castle.Models
{
    public class PotentialPlayer
    {
        //public static List<PotentialPlayer> PotentialPlayers = new List<PotentialPlayer>();

        public int PotentialPlayerID { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public int Experience { get; set; }
        public string Position { get; set; }
        public string PreviousExperience { get; set; }
        

        public PotentialPlayer()
        {
 
        }

    }
}
