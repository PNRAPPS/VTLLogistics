using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vital.Data.Models;
using Repository;

namespace Vital.Service
{
    public class ServiceTypeService : IServiceTypeService
    {
        readonly IRepository<Vital.Data.Models.Service> _serviceRepository;
        readonly IUnitOfWork _unitOfWork;

        public ServiceTypeService(
            IRepository<Vital.Data.Models.Service> serviceRepository,
            IUnitOfWork unitOfWork)
        {
            this._serviceRepository = serviceRepository;
            this._unitOfWork = unitOfWork;
        }

        public Vital.Data.Models.Service GetServiceType(int Id)
        {
            return _serviceRepository.Query().Get().FirstOrDefault(r => r.Id == Id);
        }

        public Vital.Data.Models.Service GetServiceTypeByName(string name)
        {
            return _serviceRepository.Query().Get().FirstOrDefault(r => r.ServiceName == name);
        }
    }
}
