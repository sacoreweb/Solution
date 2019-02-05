
using Core.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Business.Interfaces
{
    public interface ICCostosCompradoresBusinees
    {
        IList<tbl_CCostosCompradoresModel> GetAll();
        IList<tbl_CCostosCompradoresModel> FindBy(Expression<Func<tbl_CCostosCompradoresModel, bool>> filter);
        void Add(tbl_CCostosCompradoresModel entity);
        void Delete(object id);
        void Delete(tbl_CCostosCompradoresModel entity);
        void Update(tbl_CCostosCompradoresModel entity);
    }
}
