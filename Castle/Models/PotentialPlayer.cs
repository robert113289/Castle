using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Castle.Models
{
    public class PotentialPlayer
    {
        public static List<PotentialPlayer> PotentialPlayers = new List<PotentialPlayer>();
        public string Name { get; set; }
        public string Email { get; set; }
        public int Experience { get; set; }
        public string Position { get; set; }
        public string PreviousExperience { get; set; }
        public int Id { get; set; }
        private static int nextId = 0;

        public PotentialPlayer()
        {
            nextId++;
        }

        public static void Add(PotentialPlayer newPotentialPlayer)
        {
            PotentialPlayers.Add(newPotentialPlayer);

        }

        public static void Update(PotentialPlayer updatedPlayer)
        {
            PotentialPlayer playerToUpdate = PotentialPlayers(x => updatedPlayer)
            this.Name = updatedPlayer.Name;
        }

    }
}
