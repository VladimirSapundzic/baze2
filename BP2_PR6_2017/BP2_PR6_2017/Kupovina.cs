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
    
    public partial class Kupovina
    {
        public int Id { get; set; }
        public System.DateTime Datum { get; set; }
        public int KupacIdKor { get; set; }
    
        public virtual Kupac Kupac { get; set; }
        public virtual Knjiga Knjiga { get; set; }
    }
}
