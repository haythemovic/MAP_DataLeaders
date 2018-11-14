using PIDEV_MAP.Domain.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Data.Configurations
{
   public class ApplicantConfiguration : EntityTypeConfiguration<Applicant>
    {
        public ApplicantConfiguration()
        {
            // one to many question
            HasMany<Question>(x => x.Questions).WithRequired(y => y.applicant).HasForeignKey(c => c.userId);
        }
    }
}
