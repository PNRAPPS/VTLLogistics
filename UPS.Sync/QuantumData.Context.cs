﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VITALDB_TESTEntities : DbContext
    {
        public VITALDB_TESTEntities()
            : base("name=VITALDB_TESTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<provision_marker_dss> provision_marker_dss { get; set; }
        public virtual DbSet<schema_info_dss> schema_info_dss { get; set; }
        public virtual DbSet<scope_config_dss> scope_config_dss { get; set; }
        public virtual DbSet<scope_info_dss> scope_info_dss { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AccessorialChargeAmount> AccessorialChargeAmounts { get; set; }
        public virtual DbSet<AccessorialCharge> AccessorialCharges { get; set; }
        public virtual DbSet<AddressBookInfo> AddressBookInfoes { get; set; }
        public virtual DbSet<AdminUser> AdminUsers { get; set; }
        public virtual DbSet<BillingSummary> BillingSummaries { get; set; }
        public virtual DbSet<Carrier> Carriers { get; set; }
        public virtual DbSet<Consignee> Consignees { get; set; }
        public virtual DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public virtual DbSet<CustomerMarkup> CustomerMarkups { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerShipment> CustomerShipments { get; set; }
        public virtual DbSet<CustomerSpInstructionAmount> CustomerSpInstructionAmounts { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<LookupTable> LookupTables { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<PostalCode> PostalCodes { get; set; }
        public virtual DbSet<PostalCodeZone> PostalCodeZones { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ShipmentDetail> ShipmentDetails { get; set; }
        public virtual DbSet<ShipmentRequest> ShipmentRequests { get; set; }
        public virtual DbSet<ShippingType> ShippingTypes { get; set; }
        public virtual DbSet<SkidRate> SkidRates { get; set; }
        public virtual DbSet<Skid> Skids { get; set; }
        public virtual DbSet<SkidWeight> SkidWeights { get; set; }
        public virtual DbSet<SpecialInstructionAmount> SpecialInstructionAmounts { get; set; }
        public virtual DbSet<SpecialInstruction> SpecialInstructions { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Tax> Taxes { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<Weight> Weights { get; set; }
        public virtual DbSet<ZoneDiscountPercentage> ZoneDiscountPercentages { get; set; }
        public virtual DbSet<ZoneRate> ZoneRates { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }
        public virtual DbSet<QVSyncSummary> QVSyncSummaries { get; set; }
        public virtual DbSet<QVSubscriptionFile> QVSubscriptionFiles { get; set; }
        public virtual DbSet<QVShipmentDetail> QVShipmentDetails { get; set; }
    }
}
