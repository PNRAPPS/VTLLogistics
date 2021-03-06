using System;
using System.Collections.Generic;

namespace Vital.Data.Models
{
    public partial class BillingSummary
    {
        public System.Guid Id { get; set; }
        public System.DateTime BillingDate { get; set; }
        public string Customer { get; set; }
        public decimal TotalInvoiceAmount { get; set; }
        public decimal ExemptBRK { get; set; }
        public decimal CustomsGSTorVAT { get; set; }
        public decimal ExemptCharges { get; set; }
        public decimal TaxableBRK { get; set; }
        public decimal BRKTax { get; set; }
        public decimal GSTApp { get; set; }
        public decimal GSTAmt { get; set; }
        public decimal HBCApp { get; set; }
        public decimal HBCAmt { get; set; }
        public decimal HONApp { get; set; }
        public decimal HONAmt { get; set; }
        public decimal HNSApp { get; set; }
        public decimal HNSAmt { get; set; }
        public decimal HSTApp { get; set; }
        public decimal HSTAmt { get; set; }
        public int InvoiceNumber { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public decimal Commission { get; set; }
        public decimal AgentCommission { get; set; }
        public string Agent { get; set; }
    }
}
