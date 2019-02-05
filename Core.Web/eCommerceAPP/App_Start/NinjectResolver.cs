using Core.Data.Repository;
using Core.Domain.Business;
using Core.Domain.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using System.Web.ModelBinding;
using Core.Data.Repository.Interfaces;

namespace eCommerceAPP.App_Start
{
    public class NinjectResolver : System.Web.Mvc.IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectResolver()
        {
            _kernel = new StandardKernel();
            _kernel.Unbind<ModelValidatorProvider>();
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            // Registering Types  
            _kernel.Bind(typeof(IGenericRepository<>)).To(typeof(GenericRepository<>));
            _kernel.Bind<IVendedorRepository>().To<VendedorRepository>();
            _kernel.Bind<IBodegasRepository>().To<BodegasRepository>();
            _kernel.Bind<IPedidosc1W_2000Business>().To<Pedidosc1W_2000Business>(); 
            _kernel.Bind<IUnitOfWork>().To<UnitOfWork>();

            _kernel.Bind<ICatalogoProductosBusiness>().To<CatalogoProductosBusiness>();
            _kernel.Bind<ICCostosCompradoresBusinees>().To<CCostosCompradoresBusinees>();
            _kernel.Bind<ITransportadorasBusiness>().To<TransportadorasBusiness>();
            _kernel.Bind<ITrazabilidadPedidosBusiness>().To<TrazabilidadPedidosBusiness>();
            _kernel.Bind<IVendedorBusiness>().To<VendedorBusiness>();
            _kernel.Bind<IBodegaBusiness>().To<BodegaBusiness>();
            _kernel.Bind<IPedidosc2W_2000Business>().To<Pedidosc2W_2000Business>();
            _kernel.Bind<IProductosRepository>().To<ProductosRepository>();

        }
    }
}