//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Punto_de_venta.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalle_ventas
    {
        public int id { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<decimal> precio { get; set; }
        public Nullable<int> idProducto { get; set; }
        public Nullable<int> idventa { get; set; }
    
        public virtual productos productos { get; set; }
        public virtual ventas ventas { get; set; }
    }
}
