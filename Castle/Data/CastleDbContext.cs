using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Castle.Models;

namespace Castle.Data
{
    public class CastleDbContext : DbContext
    {
        public DbSet<PotentialPlayer> PotentialPlayers { get; set; }

        public CastleDbContext(DbContextOptions<CastleDbContext> options) 
            :base(options)
        {

        }
        
    }
}
