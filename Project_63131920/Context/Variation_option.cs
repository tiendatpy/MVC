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
    
    public partial class Variation_option
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Variation_option()
        {
            this.Product_item = new HashSet<Product_item>();
        }
    
        public int id { get; set; }
        public int variation_id { get; set; }
        public string value { get; set; }
    
        public virtual Variation Variation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_item> Product_item { get; set; }
    }
}
