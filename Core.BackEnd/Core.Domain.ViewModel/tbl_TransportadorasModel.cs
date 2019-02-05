using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ViewModel
{
    public class tbl_TransportadorasModel
    {
        public int IdTransportadora { get; set; }
        public string DescripcionTransportadora { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public ICollection<tbl_TrazabilidadPedidosModel> tbl_TrazabilidadPedidos { get; set; }
    }
}
