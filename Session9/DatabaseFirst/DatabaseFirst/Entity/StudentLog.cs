//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentLog
    {
        public int LogId { get; set; }
        public int StudentId { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
    }
}
