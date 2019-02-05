using Core.Domain.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.ViewModel;
using Core.Entity;
using Core.Data.Repository.Interfaces;
using AutoMapper;

namespace Core.Domain.Business
{
    public class Pedidosc2W_2000Business : IPedidosc2W_2000Business
    {
        private IGenericRepository<pedidosc2W_2000> _PedidoDetalleRepository;

        public Pedidosc2W_2000Business(IGenericRepository<pedidosc2W_2000> PedidoDetalleRepository)
        {
            _PedidoDetalleRepository = PedidoDetalleRepository;
        }
        public IList<pedidosc2W_2000Model> GetAll()
        {
            return Mapper.Map<IList<pedidosc2W_2000Model>>(_PedidoDetalleRepository.GetAll());
        }
    }
}
