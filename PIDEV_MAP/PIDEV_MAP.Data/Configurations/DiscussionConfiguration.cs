using PIDEV_MAP.Domain.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Data.Configurations
{
    public class DiscussionConfiguration: EntityTypeConfiguration<Discussion>
    {
        public DiscussionConfiguration()
        {

            // one to many Message
            HasMany<Message>(x => x.messages).WithRequired(y => y.discussion).HasForeignKey(c => c.DiscussionId);
        }
    }
}
