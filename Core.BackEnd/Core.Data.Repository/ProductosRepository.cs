using Core.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace Core.Data.Repository
{
    public class ProductosRepository : GenericRepository<tbl_CatalogoProductos>,IProductosRepository
    {
        private FactuContext _context;
        public ProductosRepository(FactuContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Get_ProductosByReferencia_Result> Get_ProductosByReferencia()
        {
            return _context.Get_ProductosByReferencia();
        }
    }
}
