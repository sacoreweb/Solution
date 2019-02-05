using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ViewModel
{
    public class tbl_CCostosCompradoresModel
    {
        public int IdCentroCostos { get; set; }
        public string DescripcionCentroCostos { get; set; }
        public decimal ValorPresupuesto { get; set; }
        public string Cedula { get; set; }
    }
}
