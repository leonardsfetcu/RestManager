//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manager
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceInfo
    {
        public int InvoiceID { get; set; }
        public string SupplierName { get; set; }
        public string Product { get; set; }
        public decimal UnitPrice { get; set; }
        public double TVA { get; set; }
        public string Category { get; set; }
        public string Units { get; set; }
        public Nullable<int> UnitsInStore { get; set; }
    }
}