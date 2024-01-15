using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ghiran_Andrei_Project.Models;

namespace Ghiran_Andrei_Project.Data
{
    public class Ghiran_Andrei_ProjectContext : DbContext
    {
        public Ghiran_Andrei_ProjectContext (DbContextOptions<Ghiran_Andrei_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Ghiran_Andrei_Project.Models.Game> Game { get; set; } = default!;

        public DbSet<Ghiran_Andrei_Project.Models.Platform>? Platform { get; set; }

        public DbSet<Ghiran_Andrei_Project.Models.Developer>? Developer { get; set; }


        
    }
}
