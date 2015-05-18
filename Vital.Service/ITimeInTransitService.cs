using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vital.Data.Models;

namespace Vital.Service
{
    public interface ITimeInTransitService
    {
        TimeInTransitCode GetTimeInTransitCode(string from, string to, string code);
        IEnumerable<TimeInTransitCode> GetTimeInTransitCodes(string from, string to);
    }
}
