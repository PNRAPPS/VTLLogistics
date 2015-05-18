using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vital.Model;

namespace Vital.Service
{
    public class QVService : IQVService
    {
        readonly IRepository<Vital.Data.Models.QVShipmentDetail> _qvShipmentRepository;
        readonly IRepository<Vital.Data.Models.QVSubscriptionFile> _qvSubscriptionRepository;
        readonly IRepository<Vital.Data.Models.QVSyncSummary> _qvSyncRepository;
        readonly IUnitOfWork _unitOfWork;

        public QVService(
            IRepository<Vital.Data.Models.QVShipmentDetail> qvShipmentRepository,
        IRepository<Vital.Data.Models.QVSubscriptionFile> qvSubscriptionRepository,
        IRepository<Vital.Data.Models.QVSyncSummary> qvSyncRepository, IUnitOfWork unitOfWork
            )
        {
            this._qvShipmentRepository = qvShipmentRepository;
            this._qvSubscriptionRepository = qvSubscriptionRepository;
            this._qvSyncRepository = qvSyncRepository;
            this._unitOfWork = unitOfWork;
        }

        IEnumerable<QuantumViewShipmentDetail> IQVService.GetShipmentData(string eventName, string status, string filter, string tag, string shipperNumber, string fromDate, string toDate, string dateType)
        {

            DateTime From = !string.IsNullOrEmpty(fromDate) ? Convert.ToDateTime(fromDate) : Convert.ToDateTime(DateTime.Now.ToShortDateString());
            DateTime To = !string.IsNullOrEmpty(toDate) ? Convert.ToDateTime(toDate).AddDays(1) : Convert.ToDateTime(DateTime.Now.AddDays(1).ToShortDateString());

            List<QuantumViewShipmentDetail> ReturnList = new List<QuantumViewShipmentDetail>();

            var shipments = _qvShipmentRepository
                .Query()
                .Filter(r => r.ShipmentEvent == eventName && (r.DeliveryDate >= From && r.DeliveryDate <= To));

            if (dateType.Equals("manifest"))
            {
                shipments = null;
                shipments = _qvShipmentRepository
                  .Query()
                  .Filter(r => r.ShipmentEvent == eventName && (r.ManifestDate >= From && r.ManifestDate <= To));
            }

            if (!string.IsNullOrEmpty(status))
                shipments = shipments.Filter(r => r.Status == status);

            if (!string.IsNullOrEmpty(shipperNumber))
                shipments = shipments.Filter(r => r.ShipperNumber == shipperNumber);

            switch (filter.ToLower())
            {
                case "reference number(s)":
                    shipments = shipments.Filter(r => r.ReferenceNumber.Contains(tag));
                    break;
                case "ship to name":
                    shipments = shipments.Filter(r => r.ShipToName.Contains(tag));
                    break;
                case "ship to postal code":
                    shipments = shipments.Filter(r => r.ShipToPostalCode.Contains(tag));
                    break;
                case "ship to state/province":
                    shipments = shipments.Filter(r => r.ShipToStateProvince.Contains(tag));
                    break;
                case "tracking number":
                    shipments = shipments.Filter(r => r.TrackingNumber.Contains(tag));
                    break;
                case "status":
                    shipments = shipments.Filter(r => r.ReferenceNumber.Contains(tag));
                    break;
                case "ship to":
                    shipments = shipments.Filter(r => r.ShipTo.Contains(tag));
                    break;
                case "ship to address line 1":
                    shipments = shipments.Filter(r => r.ShipToAddressLine1.Contains(tag));
                    break;
                case "ship to address line 2":
                    shipments = shipments.Filter(r => r.ShipToAddressLine2.Contains(tag));
                    break;
                case "ship to city":
                    shipments = shipments.Filter(r => r.ShipToCity.Contains(tag));
                    break;
                case "ship to country":
                    shipments = shipments.Filter(r => r.ShipToCountry.Contains(tag));
                    break;
                case "ship to attention":
                    shipments = shipments.Filter(r => r.ShipToAttention.Contains(tag));
                    break;
                case "service":
                    shipments = shipments.Filter(r => r.Service.Contains(tag));
                    break;
                default:
                    break;
            }

            foreach (var item in shipments.Get().ToList())
            {
                QuantumViewShipmentDetail model = new QuantumViewShipmentDetail()
                {
                    Type = eventName,
                    TrackingNumber = item.TrackingNumber,
                    Status = item.Status,
                    ShipTo = item.ShipTo,
                    ShipperNumber = item.ShipperNumber,
                    Service = item.Service,
                    ScheduledDelivery = item.DeliveryDate.ToString(),
                    ReferenceNumber = item.ReferenceNumber ?? "",
                    ManifestDate = item.ManifestDate.ToString(),
                    Images = item.Images ?? "",
                    ExceptionDescription = item.ExceptionDescription,
                    SignedBy = item.SignedBy,
                    ShipToTelephoneNumber = item.ShipToTelephoneNumber,
                    ShipToStateProvince = item.ShipToStateProvince,
                    ShipToPostalCode = item.ShipToPostalCode,
                    ShipToCountry = item.ShipToCountry,
                    ShipToCity = item.ShipToCity,
                    ShipToAttention = item.ShipToAttention,
                    ShipToAddressLine2 = item.ShipToAddressLine2,
                    ShipToAddressLine1 = item.ShipToAddressLine1,
                    ShipToName = item.ShipToName
                };

                ReturnList.Add(model);
            }

            return ReturnList;
        }
    }
}
