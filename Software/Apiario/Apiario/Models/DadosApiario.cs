//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apiario.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DadosApiario
    {
        public int idDados { get; set; }
        public int idApiario { get; set; }
        public double temperatura { get; set; }
        public double umidade { get; set; }
        public System.DateTime dataDadosApiario { get; set; }
    
        public virtual Apiario Apiario { get; set; }
    }
}
