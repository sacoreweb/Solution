using Core.Domain.ViewModel;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Business.Interfaces
{
    public interface IBodegaBusiness
    {
        IList<bodegasModel> GetBodegasActivas();
    }
}
