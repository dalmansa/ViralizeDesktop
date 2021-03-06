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
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.PROPUESTA_RETO = new HashSet<PROPUESTA_RETO>();
            this.RETOes = new HashSet<RETO>();
            this.SHAREs = new HashSet<SHARE>();
            this.USUARIO_LOGRO = new HashSet<USUARIO_LOGRO>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string username { get; set; }
        public string passw { get; set; }
        public Nullable<int> puntuacion { get; set; }
        public Nullable<int> nivelID { get; set; }
        public int administrador { get; set; }
        public int superusuario { get; set; }
        public int plataformaID { get; set; }
    
        public virtual NIVEL NIVEL { get; set; }
        public virtual PLATAFORMA PLATAFORMA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROPUESTA_RETO> PROPUESTA_RETO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RETO> RETOes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHARE> SHAREs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO_LOGRO> USUARIO_LOGRO { get; set; }
    }
}
