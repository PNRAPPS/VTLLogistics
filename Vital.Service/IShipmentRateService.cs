using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vital.Data.Models;

namespace Vital.Service
{
    public interface IShipmentRateService
    {
        IEnumerable<ServiceShipmentRate> GetShipmentRates(string from, string to);
        ServiceShipmentRate GetShipmentRate(string from, string to, string code);
    }
}
