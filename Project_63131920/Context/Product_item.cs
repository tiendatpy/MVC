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
    
    public partial class Product_item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product_item()
        {
            this.Order_details = new HashSet<Order_details>();
            this.Shopping_cart_item = new HashSet<Shopping_cart_item>();
            this.Variation_option = new HashSet<Variation_option>();
        }
    
        public int id { get; set; }
        public int product_id { get; set; }
        public int qty_in_stock { get; set; }
        public string product_image { get; set; }
        public int price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_details> Order_details { get; set; }
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shopping_cart_item> Shopping_cart_item { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Variation_option> Variation_option { get; set; }
    }
}
