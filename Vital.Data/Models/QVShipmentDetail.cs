﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vital.Data.Models
{
    public class QVShipmentDetail : Repository.EntityBase
    {
        public int QVShipmentDetailId { get; set; }
        public int SubscriptionFieldId { get; set; }
        public string TrackingNumber { get; set; }
        public string ShipperNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public string Status { get; set; }
        public string Service { get; set; }
        public DateTime? ManifestDate { get; set; }
        public string ShipTo { get; set; }
        public DateTime? OriginalDeliveryDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Images { get; set; }

        public string ShipmentEvent { get; set; }
        public string SignedBy { get; set; }
        public string ShipToAttention { get; set; }
        public string ShipToAddressLine1 { get; set; }
        public string ShipToAddressLine2 { get; set; }
        public string ShipToTelephoneNumber { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToStateProvince { get; set; }
        public string ShipToPostalCode { get; set; }
        public string ShipToCountry { get; set; }
        public string ShipToName { get; set; }
        public string ExceptionDescription { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

    }
}
