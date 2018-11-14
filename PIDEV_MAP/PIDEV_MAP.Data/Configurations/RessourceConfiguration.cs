using PIDEV_MAP.Domain.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Data.Configurations
{
   public class RessourceConfiguration :EntityTypeConfiguration<Resource>
    {

        public RessourceConfiguration()
    {

            // OneToMany Disscusions
          // HasMany<Discussion>(x => x.Disscusions).WithRequired(y => y.resource).HasForeignKey(c => c.userId);

             //Many to Many configuration Belong Project
          /*  HasMany(x => x.Projects).WithMany(x => x.Resources)
                //nom de la table d'association
                .Map(e => {
                    e.ToTable("Mandat");
                    //on va specifier le nom de la foreign key de la classe parent 
                    e.MapLeftKey("userId");
                    //on va specifier le nom de la foreign key de la classe en relation avec la classe courante : 
                    e.MapRightKey("ProjectId");

                });*/

            // one to many skill
             HasMany<Leave>(x => x.Leaves).WithRequired(y => y.ressource).HasForeignKey(c => c.userId);

            // Many to Many configuration Belong Project
           /* HasMany(x => x.Skills).WithMany(x => x.resource)
                //nom de la table d'association
                .Map(e => {
                    e.ToTable("Ressource_Skill");
                    //on va specifier le nom de la foreign key de la classe parent 
                    e.MapLeftKey("userId");
                    //on va specifier le nom de la foreign key de la classe en relation avec la classe courante : 
                    e.MapRightKey("SkillId");

                });*/

        }
    }
}
