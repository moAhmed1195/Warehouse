//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreManagementProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class supply_permission
    {
        public int supply_perm_id { get; set; }
        public int product_id { get; set; }
        public int supplier_id { get; set; }
        public System.DateTime perm_date { get; set; }
    
        public virtual product product { get; set; }
        public virtual supplier supplier { get; set; }
    }
}
