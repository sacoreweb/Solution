using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ViewModel
{
    public class pedidosc2W_2000Model
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
        public string SUBTOTAL { get; set; }

        public virtual pedidosc1W_2000Model pedidosc1W_2000 { get; set; }
    }
}
