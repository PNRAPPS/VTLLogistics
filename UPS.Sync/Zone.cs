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
    
    public partial class Zone
    {
        public Zone()
        {
            this.PostalCodeZones = new HashSet<PostalCodeZone>();
            this.ZoneDiscountPercentages = new HashSet<ZoneDiscountPercentage>();
            this.ZoneRates = new HashSet<ZoneRate>();
        }
    
        public int Id { get; set; }
        public string ZoneName { get; set; }
    
        public virtual ICollection<PostalCodeZone> PostalCodeZones { get; set; }
        public virtual ICollection<ZoneDiscountPercentage> ZoneDiscountPercentages { get; set; }
        public virtual ICollection<ZoneRate> ZoneRates { get; set; }
    }
}
