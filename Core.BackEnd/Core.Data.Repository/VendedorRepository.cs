using Core.Data.Repository.Interfaces;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repository
{
    public class VendedorRepository : GenericRepository<vendedor>, IVendedorRepository
    {
        private FactuContext _context;
        public VendedorRepository(FactuContext context) 
            : base(context)
        {
            _context = context;
        }

        public IEnumerable<GetVendedores_Result> GetByNit_IdBodega(string nit, string idBodega)
        {
            var vendedores = _context.GetVendedores(nit, idBodega);
            return vendedores;
        }
    }
}
