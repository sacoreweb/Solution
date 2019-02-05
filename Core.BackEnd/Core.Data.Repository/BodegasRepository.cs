using Core.Data.Repository.Interfaces;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repository
{
    public class BodegasRepository : GenericRepository<bodegas>, IBodegasRepository
    {
        public BodegasRepository(FactuContext context) 
            : base(context)
        {
        }

        public IQueryable<bodegas> GetBodegasActivas()
        {
            return GetAll().Where(b => b.bodega.Equals("001") || b.bodega.Equals("002") || b.bodega.Equals("003") || b.bodega.Equals("004") || b.bodega.Equals("005"));
        }
    }
}
