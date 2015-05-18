using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vital.Data.Models
{
    public partial class Service : Repository.EntityBase
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string RateCode { get; set; }
        public string ShipmentCode { get; set; }
    }
}
