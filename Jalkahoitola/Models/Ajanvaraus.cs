//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jalkahoitola.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ajanvaraus
    {
        public int VarausID { get; set; }
        public int AsiakasID { get; set; }
        public int TyontekijaID { get; set; }
        public System.DateTime pvm { get; set; }
    
        public virtual Tyontekija Tyontekija { get; set; }
        public virtual Asiakas Asiakas { get; set; }
    }
}
