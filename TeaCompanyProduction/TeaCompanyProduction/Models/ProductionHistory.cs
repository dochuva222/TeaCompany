//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeaCompanyProduction.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductionHistory
    {
        public int Id { get; set; }
        public int TeaId { get; set; }
        public System.DateTime DateTime { get; set; }
        public int ProducedQuantity { get; set; }
        public int UserId { get; set; }
    
        public virtual Tea Tea { get; set; }
        public virtual User User { get; set; }
    }
}