using Core.Data.Repository.Interfaces;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private FactuContext context = new FactuContext();
        
        public FactuContext DbContext
        {
            get
            {
                if(context == null)
                {
                    context = new FactuContext();
                }
                return context;
            }
        }

        public int Save()
        {
            try
            {
                return context.SaveChanges();
            }
            catch(Exception xc)
            {
                throw xc;
            }
        }

        public void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(context != null)
                {
                    context.Dispose();
                    context = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
    }
}
