using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repository.Interfaces
{
    public interface IBodegasRepository : IGenericRepository<bodegas>
    {
        IQueryable<bodegas> GetBodegasActivas();
    }
}
