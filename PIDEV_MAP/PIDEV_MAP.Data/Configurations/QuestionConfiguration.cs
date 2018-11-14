using PIDEV_MAP.Domain.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Data.Configurations
{
    public class QuestionConfiguration : EntityTypeConfiguration<Question>
    {
        public QuestionConfiguration()
        {

            //OneToOne 1..1 question->reponse
            //HasOptional(a => a.answer).WithRequired(q=> q.question);
        }
    }
    }

