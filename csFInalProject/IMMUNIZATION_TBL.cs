//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace csFinalProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class IMMUNIZATION_TBL
    {
        public string PATIENT_ID { get; set; }
        public string IMMUNIZATION_ID { get; set; }
        public string IMMUNIZATION { get; set; }
        public System.DateTime DATE { get; set; }
        public string NOTE { get; set; }
    
        public virtual PATIENT_TBL PATIENT_TBL { get; set; }
    }
}