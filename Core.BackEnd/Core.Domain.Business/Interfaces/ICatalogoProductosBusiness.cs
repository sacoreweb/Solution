using Core.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Business.Interfaces
{
    public interface ICatalogoProductosBusiness
    {
        IList<tbl_CatalogoProductosModel> GetAll();
        IList<tbl_CatalogoProductosModel> FindBy(Expression<Func<tbl_CatalogoProductosModel, bool>> filter);
        void Add(tbl_CatalogoProductosModel entity);
        void Delete(object id);
        void Delete(tbl_CatalogoProductosModel entity);
        void Update(tbl_CatalogoProductosModel entity);

        IList<Get_ProductosByReferencia_ResultModel> Get_ProductosByReferencia();
    }
}
