//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_63131920.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_details
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public int product_item_id { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
    
        public virtual Shop_order Shop_order { get; set; }
        public virtual Product_item Product_item { get; set; }
    }
}
