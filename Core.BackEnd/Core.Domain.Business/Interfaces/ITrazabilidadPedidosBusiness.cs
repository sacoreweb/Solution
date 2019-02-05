using Core.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Business.Interfaces
{
    public interface ITrazabilidadPedidosBusiness
    {
        IList<tbl_TrazabilidadPedidosModel> GetAll();
        IList<tbl_TrazabilidadPedidosModel> FindBy(Expression<Func<tbl_TrazabilidadPedidosModel, bool>> filter);
        void Add(tbl_TrazabilidadPedidosModel entity);
        void Delete(object id);
        void Delete(tbl_TrazabilidadPedidosModel entity);
        void Update(tbl_TrazabilidadPedidosModel entity);
    }
}
