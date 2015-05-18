using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vital.Data.Models;

namespace Vital.Service
{
    public class ShipmentRateService : IShipmentRateService
    {
        readonly IRepository<ServiceShipmentRate> _shipmentRateRepository;
        readonly IUnitOfWork _unitOfWork;

        public ShipmentRateService(
            IRepository<ServiceShipmentRate> shipmentRateRepository,
            IUnitOfWork unitOfWork)
        {
            this._shipmentRateRepository = shipmentRateRepository;
            this._unitOfWork = unitOfWork;
        }

        public ServiceShipmentRate GetShipmentRate(string from, string to, string code)
        {
            return GetShipmentRates(from, to).FirstOrDefault(r => r.ServiceId.ToString() == code);
        }

        public IEnumerable<ServiceShipmentRate> GetShipmentRates(string from, string to)
        {
            var data = _shipmentRateRepository.Query().Get().ToList();

            switch (from.ToUpper())
            {
                case "PL":
                    data = data.Where(r => r.From == "PL").ToList();
                    break;
                case "PR":
                    data = data.Where(r => r.From == "PR").ToList();
                    break;
                case "MX":
                    data = data.Where(r => r.From == "MX").ToList();
                    break;
                case "CA":
                    data = data.Where(r => r.From == "CA").ToList();
                    break;
                case "US":
                    data = data.Where(r => r.From == "US").ToList();
                    break;
                default:
                    break;
            }

            //switch (to.ToUpper())
            //{
            //    case "PL":
            //        data = data.Where(r => r.To == "PL").ToList();
            //        break;
            //    case "PR":
            //        data = data.Where(r => r.To == "PR").ToList();
            //        break;
            //    case "MX":
            //        data = data.Where(r => r.To == "MX").ToList();
            //        break;
            //    case "CA":
            //        data = data.Where(r => r.To == "CA").ToList();
            //        break;
            //    case "US":
            //        data = data.Where(r => r.To == "US").ToList();
            //        break;
            //    default:
            //        break;
            //}

            return data;
        }
    }
}
