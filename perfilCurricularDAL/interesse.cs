//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace perfilCurricularDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class interesse
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int Curriculo { get; set; }
    
        public virtual curriculo curriculo1 { get; set; }
    }
}
