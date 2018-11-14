﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP_MVC.Models
{
   public class Mandat
    {
        public int MandatId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public Boolean Billable { get; set; }
        public Project project { get; set; }
       public virtual ICollection<User> Resources { get; set; }
    }
}
