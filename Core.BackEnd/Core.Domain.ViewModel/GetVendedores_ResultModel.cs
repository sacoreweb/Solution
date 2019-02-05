using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ViewModel
{
    public class GetVendedores_ResultModel
    {
        public string SucursalNissan { get; set; }
        public string Vendedor { get; set; }
        public string Nombre { get; set; }
        public string CorreodelVendedor { get; set; }
        public string vALOR { get; set; }
        public string EmailVendedorInterno { get; set; }
    }
}
