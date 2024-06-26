//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeaCompanySales.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tea()
        {
            this.ProductionHistory = new HashSet<ProductionHistory>();
            this.Sale = new HashSet<Sale>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public int InStock { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int GradeId { get; set; }
    
        public virtual Grade Grade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductionHistory> ProductionHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sale { get; set; }
        public virtual Type Type { get; set; }
    }
}
