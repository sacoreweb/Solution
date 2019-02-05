using Core.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Business.Interfaces
{
    public interface ITransportadorasBusiness
    {
        IList<tbl_TransportadorasModel> GetAll();
        IList<tbl_TransportadorasModel> FindBy(Expression<Func<tbl_TransportadorasModel, bool>> filter);
        void Add(tbl_TransportadorasModel entity);
        void Delete(object id);
        void Delete(tbl_TransportadorasModel entity);
        void Update(tbl_TransportadorasModel entity);
    }
}
