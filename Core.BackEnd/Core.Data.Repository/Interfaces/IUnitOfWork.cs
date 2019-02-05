using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        FactuContext DbContext { get; }
        int Save();
    }
}
