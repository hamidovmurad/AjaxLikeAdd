//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajaxsteast.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int id { get; set; }
        public string prod_name { get; set; }
        public Nullable<int> cat_id { get; set; }
        public Nullable<int> product_like { get; set; }
    
        public virtual category category { get; set; }
    }
}
