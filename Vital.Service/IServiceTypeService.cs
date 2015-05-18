using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vital.Service
{
    public interface IServiceTypeService
    {
        Vital.Data.Models.Service GetServiceType(int Id);
        Vital.Data.Models.Service GetServiceTypeByName(string name);
    }
}
