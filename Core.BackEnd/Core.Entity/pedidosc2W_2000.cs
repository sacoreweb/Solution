//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class pedidosc2W_2000
    {
        public string id { get; set; }
        public string numero { get; set; }
        public string referencia { get; set; }
        public string descripcion { get; set; }
        public decimal valor { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public decimal descuento { get; set; }
        public int anulado { get; set; }
        public decimal tarifaiva { get; set; }
        public string ccostos { get; set; }
    
        public virtual pedidosc1W_2000 pedidosc1W_2000 { get; set; }
    }
}
