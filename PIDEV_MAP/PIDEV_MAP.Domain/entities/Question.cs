using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Domain.entities
{
    public enum QuestionType
    {
        French,
        Technical
    }

   public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionValue { get; set; }
       public QuestionType questionType { get; set; }
        public int userId { get; set; }
        public Applicant applicant { get; set; }
       // public Answer answer { get; set; }
    }
}
