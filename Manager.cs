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
    
    public partial class Manager
    {
        public int Manager_ID { get; set; }
        public Nullable<int> Book_ID { get; set; }
        public Nullable<int> Member_ID { get; set; }
        public Nullable<System.DateTime> Date_Time_Borrowed { get; set; }
        public Nullable<System.DateTime> Date_Time_Returned { get; set; }
        public Nullable<double> Amount { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Member Member { get; set; }
    }
}
