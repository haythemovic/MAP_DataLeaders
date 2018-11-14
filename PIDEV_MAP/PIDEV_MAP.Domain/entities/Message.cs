using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Domain.entities
{
    public enum MessageType
    {
        Satisfaction,
        Comlaint,
        TechnicalProblem
    }
    public class Message
    {
        public int MessageId { get; set; }
        public MessageType messageType { get; set; }
        public string Messagecontent { get; set; }
        public int DiscussionId { get; set; }
        public Discussion discussion { get; set; }
    }
}
