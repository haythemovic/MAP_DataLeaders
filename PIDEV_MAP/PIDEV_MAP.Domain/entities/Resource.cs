using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Domain.entities
{

    public enum ContractType
    {
        employee,
        freelancer
    }
    public enum AvailbliltyType
    {
        avilable,
        unvailable,
        availableSoon
    }
    public class Resource:User
    {
        public ContractType contracttype { get; set; }
        public string Senority { get; set; }
        public string bussniesprofile { get; set; }
        public int mark { get; set; }
        public AvailbliltyType availbliltyType { get; set; }
        public string sector { get; set; }
       public float Salary { get; set; }
        public DateTime HireDate { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Leave> Leaves { get; set; }
        public virtual ICollection<Discussion> Disscusions { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }

    }
}
