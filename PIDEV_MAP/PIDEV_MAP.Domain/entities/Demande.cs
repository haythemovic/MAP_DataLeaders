using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Domain.entities
{
  public class Demande
    {
       public int DemandeId { get; set; }
        public string specialite { get; set; }
        public string experience { get; set; }
        public string Profil { get; set; }
        public Applicant applicant { get; set; }

    }
}
