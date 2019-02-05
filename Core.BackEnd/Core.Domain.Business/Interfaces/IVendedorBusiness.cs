using Core.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Business.Interfaces
{
    public interface IVendedorBusiness
    {
        IEnumerable<GetVendedores_ResultModel> GetByNit_IdBodega(string nit, string idBodega);
    }
}
