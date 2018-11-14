using PIDEV_MAP.Domain.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MAP_MVC.Models
{
    public class RequestViewModels
    {
        [Key]
        public int RequestID { get; set; }
        public string requiredProfile { get; set; }
        public int NbRequiredProfile { get; set; }
        public int yearExperience { get; set; }
        [Display(Name = "Education 2 Date")]
        public string Education { get; set; }
        public DateTime DateDeposit { get; set; }
        public DateTime DateStart_Mandat { get; set; }
        public DateTime DateEnd_Mandat { get; set; }
        public StateRequest stateRequest { get; set; }
        public int userId { get; set; }
        public Customer customer { get; set; }

    }

}