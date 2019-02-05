using Core.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Business.Interfaces
{
    public interface IPedidosc1W_2000Business
    {
        IList<pedidosc1W_2000Model> GetAll();
        IList<pedidosc1W_2000Model> FindBy(Expression<Func<pedidosc1W_2000Model, bool>> filter);
        void Add(pedidosc1W_2000Model entity);
        void Delete(object id);
        void Delete(pedidosc1W_2000Model entity);
        void Update(pedidosc1W_2000Model entity);
    }
}
