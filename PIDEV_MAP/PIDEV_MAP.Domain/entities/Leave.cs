using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Domain.entities
{
    public enum LeaveType
    {
        Vacances,
        Maternity,
        Ilness

    }
    public class Leave
    {
        public int LeaveId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType leaveType { get; set; }
        public int userId { get; set; }
        public Resource ressource { get; set; }

    }
}
