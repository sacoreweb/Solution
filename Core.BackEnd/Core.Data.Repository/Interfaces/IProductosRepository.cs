using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repository.Interfaces
{
    public interface IProductosRepository : IGenericRepository<tbl_CatalogoProductos>
    {
        IEnumerable<Get_ProductosByReferencia_Result> Get_ProductosByReferencia();
    }
}
