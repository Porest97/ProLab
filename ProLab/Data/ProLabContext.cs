using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProLab.ImageUpload.Models;
using ProLab.Models.DataModels;
using ProLab.TheOneApp.Models.DataModels;
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

        public DbSet<ActivityPost> ActivityPosts { get; set; }
        public DbSet<ActivityPostStatus> ActivityPostStatuses { get; set; }

        public DbSet<Arena> Arena { get; set; }
        public DbSet<Club> Club { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyRole> CompanyRoles { get; set; }
        public DbSet<CompanyStatus> CompanyStatuses { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }

        public DbSet<GameCategory> GameCategory { get; set; }
        public DbSet<GameStatus> GameStatus { get; set; }
        public DbSet<GameType> GameType { get; set; }

        public DbSet<HealthActivity> HealthActivities { get; set; }


        public DbSet<HockeyGame> HockeyGame { get; set; }

        public DbSet<TSMHocekyGame> TSMHockeyGame { get; set; }

        public DbSet<TSMGame> TSMGames { get; set; }
        public DbSet<TSMSeries> TSMSeries { get; set; }
        public DbSet<Series> Series { get; set; }

        public DbSet<Referee> Referee { get; set; }

        public DbSet<RefReceipt> RefReceipt { get; set; }
        public DbSet<MDProtocol> MDProtocol { get; set; }

        public DbSet<RefFees> RefFees { get; set; }

        public DbSet<ImageModel> Images { get; set; }

        public DbSet<PlanPost> PlanPost { get; set; }

        //Projects !
        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectStatus> ProjectStatus { get; set; }

        public DbSet<ProjectPost> ProjectPosts { get; set; }

        public DbSet<CleverServicePayments> CleverServicePayments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<FoodRating> FoodRatings { get; set; }

        public DbSet<FoodDiaryPost> FoodDiaryPosts { get; set; }

        //public DbSet<RatingToFood> RatingsToFoods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        //public DbSet<Employee> Employees { get; set; }

        public DbSet<UploadModel> Uploads { get; set; }

        public DbSet<OfficialsGroup> OfficialsGroups { get; set; }
       
        
    }
}