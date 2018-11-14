using PIDEV_MAP.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP_MVC.Models
{
    public class Project
    {
        public int ProjectId{ get; set; }
        public string ProjectName { get; set; }
        public string Address { get; set; }
       
        public float Proftability { get; set; }

        public int userId { get; set; }
        public Customer customer { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
    }
}
