//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace regestraionandlogin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Order_id { get; set; }
        public Nullable<bool> Type { get; set; }
        public int StockID { get; set; }
        public int UserId { get; set; }
        public Nullable<System.DateTime> TransDate { get; set; }
        public int Quantity { get; set; }
        public string namer { get; set; }
        public string nameun { get; set; }
        public Nullable<double> price_quantity { get; set; }
    
        public virtual Stock Stock { get; set; }
        public virtual User User { get; set; }
    }
}
