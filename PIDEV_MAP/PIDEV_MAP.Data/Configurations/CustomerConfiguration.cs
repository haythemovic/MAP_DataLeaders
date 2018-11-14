using PIDEV_MAP.Domain.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Data.Configurations
{
   public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            // one to many Project
            HasMany<Project>(x => x.Projects).WithRequired(y => y.customer).HasForeignKey(c => c.userId);

        // OneToMany Disscusions
           //HasMany<Discussion>(x => x.Discussions).WithRequired(y => y.customer).HasForeignKey(c => c.userId);

            // OneToMany Request
            HasMany<Request>(x => x.Requests).WithRequired(y => y.customer).HasForeignKey(c => c.userId);
        }
       
    }
}
