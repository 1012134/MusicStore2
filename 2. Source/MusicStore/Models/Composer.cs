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
    
    public partial class Composer
    {
        public Composer()
        {
            this.Songs = new HashSet<Song>();
        }
    
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Information { get; set; }
        public string LinkImage { get; set; }
    
        public virtual ICollection<Song> Songs { get; set; }
    }
}
