//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TugasSE.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemNote { get; set; }
    
        public virtual ListDelivery ListDelivery { get; set; }
    }
}