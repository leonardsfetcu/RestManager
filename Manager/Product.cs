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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.InvoiceUnits = new HashSet<InvoiceUnit>();
            this.Ingredients = new HashSet<Ingredient>();
            this.TransfetNoteUnits = new HashSet<TransfetNoteUnit>();
        }
    
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public double TVA { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> UnitID { get; set; }
        public Nullable<int> UnitsInStore { get; set; }
        public Nullable<int> UnitsInKitchen { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceUnit> InvoiceUnits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public virtual Unit Unit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransfetNoteUnit> TransfetNoteUnits { get; set; }
    }
}
