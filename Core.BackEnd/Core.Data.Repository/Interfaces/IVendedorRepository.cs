using Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repository.Interfaces
{
    public interface IVendedorRepository : IGenericRepository<vendedor>
    {
        IEnumerable<GetVendedores_Result> GetByNit_IdBodega(string nit, string idBodega);
    }
}
