//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taekwondo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class inventory
    {
        public string inventoryID { get; set; }
        public string productID { get; set; }
        public string costprice { get; set; }
        public string sellingprice { get; set; }
        public string profit { get; set; }
        public string quantityinstock { get; set; }
        public string supplierID { get; set; }
    
        public virtual product product { get; set; }
        public virtual supplier supplier { get; set; }
    }
}
