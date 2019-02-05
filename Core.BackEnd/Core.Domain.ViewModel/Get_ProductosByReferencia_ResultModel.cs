using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ViewModel
{
    public class Get_ProductosByReferencia_ResultModel
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
        public Nullable<decimal> PORCENTAJEIVA { get; set; }
    }
}
