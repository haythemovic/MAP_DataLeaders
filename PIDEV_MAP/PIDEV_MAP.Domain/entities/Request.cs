using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Domain.entities
{

    public enum StateRequest
    {
        Accepted,
        Pending,
        NoAccepted
    }
    public class Request
    {

        public int RequestID { get; set; }
        [Display(Name = "Required Profile")]
        [Required(ErrorMessage = "Profile Cannot Be Empty")]
        public string requiredProfile { get; set; }

        [Display(Name = "Number Of Required Profile")]
        public int NbRequiredProfile { get; set; }

        [Display(Name = "Experience Years")]
        public int yearExperience { get; set; }

        [Display(Name = "Education")]
        public string Education { get; set; }
        public DateTime DateDeposit { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [CurrentDate(ErrorMessage = "Date must be after or equal to current date")]
        public DateTime DateStart_Mandat { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [CurrentDate(ErrorMessage = "Date must be after or equal to current date")]
        public DateTime DateEnd_Mandat { get; set; }
        public StateRequest stateRequest { get; set; }
        public int userId { get; set; }
        public Customer customer { get; set; }
    }
}
