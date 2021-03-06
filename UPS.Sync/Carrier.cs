//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPS.Sync
{
    using System;
    using System.Collections.Generic;
    
    public partial class Carrier
    {
        public Carrier()
        {
            this.ShipmentRequests = new HashSet<ShipmentRequest>();
            this.SkidRates = new HashSet<SkidRate>();
            this.SpecialInstructionAmounts = new HashSet<SpecialInstructionAmount>();
        }
    
        public System.Guid Id { get; set; }
        public string BillToAdd { get; set; }
        public string Company { get; set; }
        public string AccountNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<ShipmentRequest> ShipmentRequests { get; set; }
        public virtual ICollection<SkidRate> SkidRates { get; set; }
        public virtual ICollection<SpecialInstructionAmount> SpecialInstructionAmounts { get; set; }
    }
}
