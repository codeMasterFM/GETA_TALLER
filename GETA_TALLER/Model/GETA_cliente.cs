//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GETA_TALLER.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class GETA_cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GETA_cliente()
        {
            this.GETA_factura = new HashSet<GETA_factura>();
            this.GETA_vehiculo = new HashSet<GETA_vehiculo>();
        }
    
        public int id_cliente { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public Nullable<System.DateTimeOffset> FECHA_REGISTRO { get; set; }
        public Nullable<int> ESTADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GETA_factura> GETA_factura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GETA_vehiculo> GETA_vehiculo { get; set; }
    }
}