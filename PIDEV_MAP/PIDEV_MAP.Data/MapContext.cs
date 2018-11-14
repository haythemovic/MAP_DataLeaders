using Microsoft.AspNet.Identity.EntityFramework;
using PIDEV_MAP.Data.Configurations;
using PIDEV_MAP.Domain.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PIDEV_MAP.Domain.entities.User;


namespace PIDEV_MAP.Data
{
   public class MapContext : IdentityDbContext<User, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {

        public MapContext():base("MAP_Identity")
        {
        }

        public new string[] Roles = { "Resource", "Applicant", "Customer" };
        public static MapContext Create()
        {
            return new MapContext();
        }

      
        //public DbSet<User> UserS { get; set; }
        public DbSet<Discussion> DiscussionS { get; set; }
        public DbSet<Leave> LeaveS { get; set; }
        public DbSet<Message> MessageS { get; set; }
       public DbSet<Project> ProjectS { get; set; }
        public DbSet<Question> QuestionS { get; set; }
        public DbSet<Request> RequestS { get; set; }
       public DbSet<Skill> SkillS { get; set; }
        public DbSet<Mandat> MandatS { get; set; }

        public DbSet<Demande> Demandes { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //les config + conventions
             // modelBuilder.Configurations.Add(new RessourceConfiguration());
           // modelBuilder.Configurations.Add(new CustomerConfiguration());
             modelBuilder.Configurations.Add(new ProjectConfiguration());
             modelBuilder.Configurations.Add(new DiscussionConfiguration());
           // modelBuilder.Configurations.Add(new ApplicantConfiguration());
           // modelBuilder.Configurations.Add(new QuestionConfiguration());

        }

        }
}
