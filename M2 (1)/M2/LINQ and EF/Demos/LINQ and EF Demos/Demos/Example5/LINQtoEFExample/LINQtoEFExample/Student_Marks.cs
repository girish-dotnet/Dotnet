//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQtoEFExample
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_Marks
    {
        public Nullable<decimal> Stud_Code { get; set; }
        public int Stud_Year { get; set; }
        public Nullable<decimal> Subject1 { get; set; }
        public Nullable<decimal> Subject2 { get; set; }
        public Nullable<decimal> Subject3 { get; set; }
    
        public virtual Student_master Student_master { get; set; }
    }
}
