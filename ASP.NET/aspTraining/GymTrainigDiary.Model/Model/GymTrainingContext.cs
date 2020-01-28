using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTrainingDiary.Model
{
    public class GymTrainingContext : DbContext
    {
        public GymTrainingContext() : base("GymTrainingEntities")
        {
            Database.SetInitializer<GymTrainingContext>(new DbInitializer());
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Excersise>().Property(x => x.Id).HasPrecision(18, 0);
            modelBuilder.Entity<Training>().Property(x => x.Id).HasPrecision(18, 0);
            modelBuilder.Entity<RepeatSet>().Property(x => x.Id).HasPrecision(18, 0);
            modelBuilder.Entity<PARAM>().Property(x => x.Id).HasPrecision(18, 0);
            modelBuilder.Entity<User>().Property(x => x.Id).HasPrecision(18, 0);
            modelBuilder.Entity<Permission>().Property(x => x.Id).HasPrecision(18, 0);
            modelBuilder.Entity<UserPermisssion>().Property(x => x.Id).HasPrecision(18, 0);
        }

        public DbSet<Training> Trainings { get; set; }
        public DbSet<Excersise> Excersises { get; set; }
        public DbSet<RepeatSet> RepeatSets { get; set; }
        public DbSet<PARAM> Parameters { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPermisssion> UserPermisssions { get; set; }
        public DbSet<Permission> Permissions { get; set; }



    }
}
