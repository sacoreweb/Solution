using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ViewModel
{
    public class pedidosc1W_2000Model
    {
        public string numero { get; set; }
        public string mes { get; set; }
        public System.DateTime fecha { get; set; }
        public int anulado { get; set; }
        public System.DateTime fechaDespacho { get; set; }
        public string nit { get; set; }
        public string vendedor { get; set; }
        public decimal iva { get; set; }
        public decimal valor { get; set; }
        public decimal descuento { get; set; }
        public Nullable<bool> estado { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string ZONA { get; set; }
        public string prefijo { get; set; }
        public string contacto { get; set; }
        public string BODEGA { get; set; }
        public string OBSERVACIONES { get; set; }
        public string Nombre_Producto { get; set; }
        public virtual ICollection<pedidosc2W_2000Model> pedidosc2W_2000 { get; set; }
        public virtual ICollection<GetVendedores_ResultModel> Vendedores { get; set; }
        public virtual ICollection<bodegasModel> Bodegas { get; set; }
    }
}
