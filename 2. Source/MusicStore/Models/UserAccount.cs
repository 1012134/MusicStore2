//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAccount
    {
        public UserAccount()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public string UserName { get; set; }
        public string Facebook { get; set; }
        public Nullable<int> Money { get; set; }
        public string Addresss { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
