//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DETALLEFACTURA
    {
        public System.Guid IDFACTURA { get; set; }
        public int IDPRODUCTO { get; set; }
        public short NOPRODUCTOS { get; set; }
        public Nullable<int> DESCUENTO { get; set; }
        public Nullable<int> VALORUNIDAD { get; set; }
        public Nullable<int> TOTALPAGO { get; set; }
    
        public virtual FACTURA FACTURA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
