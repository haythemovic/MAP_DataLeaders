using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Domain.entities
{
   public class Admin :User
    {
        public virtual ICollection<Discussion> Discussions { get; set; }
    }
}
