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
    
    public partial class factura_detalleA3_Result
    {
        public int id_cliente { get; set; }
        public string NOMBRE_CLIENTE { get; set; }
        public string APELLIDO_CLIENTE { get; set; }
        public string DIRECCION { get; set; }
        public Nullable<System.DateTimeOffset> FECHA_REGISTRO { get; set; }
        public string NOMBRE_MECANICO { get; set; }
        public string APELLIDO_MECANICO { get; set; }
        public string CEDULA { get; set; }
        public string NOMBRE_PIEZAS { get; set; }
        public string CANTIDAD { get; set; }
        public Nullable<double> PRECIO { get; set; }
        public Nullable<double> MANO_OBRA { get; set; }
        public Nullable<double> SUB_TOTAL { get; set; }
        public Nullable<double> ITB { get; set; }
    }
}