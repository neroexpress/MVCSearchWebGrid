//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCSimpleWebgrid
{
    using System;
    using System.Collections.Generic;
    
    public partial class Offering
    {
        public Offering()
        {
            this.Enrollments = new HashSet<Enrollment>();
        }
    
        public int OfferNo { get; set; }
        public string CourseNo { get; set; }
        public string OffTerm { get; set; }
        public int OffYear { get; set; }
        public string OffLocation { get; set; }
        public string OffTime { get; set; }
        public string FacNo { get; set; }
        public string OffDays { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}