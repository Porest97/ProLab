using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProLab.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Data
{

    public class ProLabContext : IdentityDbContext<ApplicationUser>
    {
        public ProLabContext(DbContextOptions<ProLabContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<Club> Club { get; set; }
        public DbSet<Arena> Arena { get; set; }
        public DbSet<GameCategory> GameCategory { get; set; }
        public DbSet<GameStatus> GameStatus { get; set; }
        public DbSet<GameType> GameType { get; set; }
        public DbSet<HockeyGame> HockeyGame { get; set; }
        public DbSet<Series> Series { get; set; }

        public DbSet<Referee> Referee { get; set; }

    }
}