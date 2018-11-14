using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Domain.entities
{

    public enum CustomerType
    {
        ActualCustomer,
        NewCustomer,
        CompletedContaract
    }
    public enum Category
    {
        Public,
        Private,
        
    }

    public  class Customer : User
    {
        public CustomerType customertype{ get; set; }
        public Category category { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Discussion> Discussions { get; set; }
    }
}
