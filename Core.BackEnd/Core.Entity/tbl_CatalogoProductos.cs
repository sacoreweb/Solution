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
    
    public partial class tbl_CatalogoProductos
    {
        public int Id { get; set; }
        public string Nit { get; set; }
        public string Referencia { get; set; }
        public string Nombre_Producto { get; set; }
        public string Referencia_Proveedor { get; set; }
        public Nullable<System.DateTime> FechaInicial { get; set; }
        public Nullable<System.DateTime> FechaFinal { get; set; }
        public decimal ValorNegociado { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string Imagen { get; set; }
    }
}