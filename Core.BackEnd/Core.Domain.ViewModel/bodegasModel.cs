using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ViewModel
{
    public class bodegasModel
    {
        public string bodega { get; set; }
        public string nombre { get; set; }
        public string cuentacontable { get; set; }
        public string CENTROCOSTOS { get; set; }
        public string NUMEROMAQUINA { get; set; }
        public Nullable<decimal> DIAS { get; set; }
        public string CODIGORETEICA { get; set; }
        public string DIRECCIONBODEGA { get; set; }
        public string TELEFONOBODEGA { get; set; }
        public string FAXBODEGA { get; set; }
    }
}
