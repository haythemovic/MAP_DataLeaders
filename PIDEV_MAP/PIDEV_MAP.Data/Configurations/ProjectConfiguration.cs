using PIDEV_MAP.Domain.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Data.Configurations
{
   public class ProjectConfiguration :EntityTypeConfiguration<Project>
    {
        public ProjectConfiguration()
        {
          
             //Many to Many configuration Belong skills
            HasMany(x =>x.Skills).WithMany(x => x.projects)
                //nom de la table d'association
                .Map(e => {
                    e.ToTable("Project Skill");
                    //on va specifier le nom de la foreign key de la classe parent 
                    e.MapLeftKey("ProjectId");
                    //on va specifier le nom de la foreign key de la classe en relation avec la classe courante : 
                    e.MapRightKey("SkillId");

                });
        }
    }
}
