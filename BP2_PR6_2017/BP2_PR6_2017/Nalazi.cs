//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BP2_PR6_2017
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nalazi
    {
        public int Id { get; set; }
        public int SkladisteIdSkl { get; set; }
    
        public virtual Skladiste Skladiste { get; set; }
        public virtual Knjiga Knjiga { get; set; }
    }
}
