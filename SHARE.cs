//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViralizeDesktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class SHARE
    {
        public int id { get; set; }
        public System.DateTime fechaPublicacion { get; set; }
        public string urlVideo { get; set; }
        public string urlThumbnail { get; set; }
        public int rating { get; set; }
        public int usuarioID { get; set; }
        public int retoID { get; set; }
    
        public virtual RETO RETO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
