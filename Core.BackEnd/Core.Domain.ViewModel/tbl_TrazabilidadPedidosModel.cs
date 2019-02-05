using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ViewModel
{
    public class tbl_TrazabilidadPedidosModel
    {
        public int IdTrazabilidad { get; set; }
        public string NumeroPedido { get; set; }
        public Nullable<System.DateTime> FechaDespacho { get; set; }
        public Nullable<System.DateTime> FechaEntrega { get; set; }
        public string NumeroGuia { get; set; }
        public int IdTransportadora { get; set; }
        public string LinkSeguimiento { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }

        public virtual tbl_TransportadorasModel tbl_Transportadoras { get; set; }
    }
}
