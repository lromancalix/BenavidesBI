//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Benavides.MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSegmento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSegmento()
        {
            this.tblPromocionesAcumulacion = new HashSet<tblPromocionesAcumulacion>();
        }
    
        public int idSegmento { get; set; }
        public string segmento { get; set; }
        public Nullable<bool> activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPromocionesAcumulacion> tblPromocionesAcumulacion { get; set; }
    }
}