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
    
    public partial class Atendimento
    {
        public int idAtendimento { get; set; }
        public int idCliente { get; set; }
        public string assunto { get; set; }
        public string mensagem { get; set; }
        public string situacao { get; set; }
        public System.DateTime dataAtendimento { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
