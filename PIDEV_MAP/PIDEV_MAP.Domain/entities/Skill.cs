using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Domain.entities
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillValue { get; set; }
      

        public virtual ICollection<Project> projects { get; set; }
        public virtual ICollection<Resource> resource { get; set; }
    }
}
