using AutoMapper;
using Core.Data.Repository;
using Core.Data.Repository.Interfaces;
using Core.Domain.Business.Interfaces;
using Core.Domain.ViewModel;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Business
{
    public class Pedidosc1W_2000Business : IPedidosc1W_2000Business
    {
        private IGenericRepository<pedidosc1W_2000> _TrazabilidadPRepository;
        private IPedidosc2W_2000Business _pedidoDetalleBusinees;
        public Pedidosc1W_2000Business(IGenericRepository<pedidosc1W_2000> TrazabilidadPRepository, IPedidosc2W_2000Business pedidoDetalleBusinees)
        {
            _TrazabilidadPRepository = TrazabilidadPRepository;
            _pedidoDetalleBusinees = pedidoDetalleBusinees;
        }
        public void Add(pedidosc1W_2000Model entity)
        {
            var ultimoNumeroEncabezado =  GetAll().Select(p => p.numero).OrderByDescending(p => p).FirstOrDefault();
            if (String.IsNullOrEmpty(ultimoNumeroEncabezado))
                entity.numero = "1";
            else
                entity.numero = (Convert.ToInt32(ultimoNumeroEncabezado) + 1) + "";


            entity.nit = "860001307-0";
            entity.mes = entity.fecha.Month.ToString();
            entity.FechaCreacion = DateTime.Now;

            var ultimonumeroDetalle = _pedidoDetalleBusinees.GetAll().Select(p => p.id).OrderByDescending(p => p).FirstOrDefault();

            int id = 1;
            if (String.IsNullOrEmpty(ultimonumeroDetalle))
                id = Convert.ToInt32(ultimonumeroDetalle) + 1;

            foreach (var detalle in entity.pedidosc2W_2000)
            {
                detalle.id = id + "";
                detalle.ccostos = "0";
                id++;
            }

            _TrazabilidadPRepository.Add(Mapper.Map<pedidosc1W_2000>(entity));
        }

        public void Delete(pedidosc1W_2000Model entity)
        {
            _TrazabilidadPRepository.Delete(Mapper.Map<pedidosc1W_2000>(entity));
        }

        public void Delete(object id)
        {
            _TrazabilidadPRepository.Delete(id);
        }

        public IList<pedidosc1W_2000Model> FindBy(Expression<Func<pedidosc1W_2000Model, bool>> filter)
        {
            var transportadoras = _TrazabilidadPRepository.FindBy(Mapper.Map<Expression<Func<pedidosc1W_2000, bool>>>(filter));
            return Mapper.Map<IList<pedidosc1W_2000Model>>(transportadoras);
        }

        public IList<pedidosc1W_2000Model> GetAll()
        {
            return Mapper.Map<IList<pedidosc1W_2000Model>>(_TrazabilidadPRepository.GetAll());
        }

        public void Update(pedidosc1W_2000Model entity)
        {
            _TrazabilidadPRepository.Update(Mapper.Map<pedidosc1W_2000>(entity));
        }
    }
}
