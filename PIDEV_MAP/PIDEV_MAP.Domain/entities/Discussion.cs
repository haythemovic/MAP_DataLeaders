using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Domain.entities
{
   public class Discussion
    {
        public int DiscussionId { get; set; }
        public string ReferenceDiscusion { get; set; }
        public virtual ICollection<Message> messages { get; set; }
        public Admin admin { get; set; }
        public Customer customer { get; set; }
        public string userId { get; set; }
        public Resource resource { get; set; }
    }
}
