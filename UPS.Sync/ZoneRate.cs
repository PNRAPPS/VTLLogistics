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
    
    public partial class ZoneRate
    {
        public System.Guid Id { get; set; }
        public string Type { get; set; }
        public double Minimum { get; set; }
        public double Rate { get; set; }
        public int RateYear { get; set; }
        public int ZoneId { get; set; }
        public int WeightId { get; set; }
    
        public virtual Weight Weight { get; set; }
        public virtual Zone Zone { get; set; }
    }
}
