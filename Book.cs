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
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.Managers = new HashSet<Manager>();
        }
    
        public int Book_ID { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public Nullable<int> Published_Year { get; set; }
        public Nullable<int> Stock_ID { get; set; }
        public Nullable<int> Category_ID { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Stock Stock { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Manager> Managers { get; set; }
    }
}