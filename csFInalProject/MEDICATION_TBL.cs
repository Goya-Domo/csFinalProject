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
    
    public partial class MEDICATION_TBL
    {
        public string PATIENT_ID { get; set; }
        public string MED_ID { get; set; }
        public string MEDICATION { get; set; }
        public System.DateTime DATE { get; set; }
        public bool CHRONIC { get; set; }
        public string NOTE { get; set; }
    
        public virtual PATIENT_TBL PATIENT_TBL { get; set; }
    }
}
