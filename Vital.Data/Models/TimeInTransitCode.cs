using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vital.Data.Models
{
    public class TimeInTransitCode : Repository.EntityBase
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Code { get; set; }
    }
}
