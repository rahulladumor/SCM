//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMSProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentTB
    {
        public int Payment_id { get; set; }
        public int Student_id { get; set; }
        public int Course_id { get; set; }
        public int Payment_amount { get; set; }
        public System.DateTime Payment_date { get; set; }
    
        public virtual CourseTB CourseTB { get; set; }
        public virtual StudentTB StudentTB { get; set; }
    }
}
