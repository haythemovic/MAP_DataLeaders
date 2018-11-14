using PIDEV_MAP.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Domain.entities
{
    public enum StateProject
    {
      NewProject,
      ActualProject,
      ProjectTerminetd
    }
    

    public class Project
    {
        public int ProjectId{ get; set; }
        public string ProjectName { get; set; }
        public string Address { get; set; }
       
        public float Proftability { get; set; }
        public StateProject stateProject { get; set; }
        public string ProjectType{ get; set; }
        public DateTime DateProject { get; set; }
        public int userId { get; set; }
        public Customer customer { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
    }
}
