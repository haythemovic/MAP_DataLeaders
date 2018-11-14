using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Domain.entities
{

    public enum ApplciantType 
    {
        Preemployee,
        Employee,
        Rejected
    }
   public class Applicant :User
    {
     public ApplciantType applciantType { get; set; }
     public virtual ICollection<Question> Questions { get; set; }
    }
}
