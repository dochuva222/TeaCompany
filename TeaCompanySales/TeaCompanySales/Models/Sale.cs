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
    
    public partial class Sale
    {
        public int Id { get; set; }
        public System.DateTime DateTime { get; set; }
        public int TeaId { get; set; }
        public int Quantity { get; set; }
    
        public virtual Tea Tea { get; set; }
    }
}