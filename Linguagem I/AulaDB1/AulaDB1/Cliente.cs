//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AulaDB1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public decimal IdCliente { get; set; }
        public string nome { get; set; }
        public decimal idade { get; set; }
        public decimal IdCidade { get; set; }
    
        public virtual Cidade Cidade { get; set; }
    }
}
