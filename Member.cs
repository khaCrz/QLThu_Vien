//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLThu_Vien1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.Managers = new HashSet<Manager>();
        }
    
        public int Member_ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Nullable<int> User_ID { get; set; }
        public Nullable<int> Phone { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> NS { get; set; }
        public string CMND { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual User User { get; set; }
    }
}
