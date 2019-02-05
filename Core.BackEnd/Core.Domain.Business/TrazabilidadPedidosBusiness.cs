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
    public class TrazabilidadPedidosBusiness : ITrazabilidadPedidosBusiness
    {
        private IGenericRepository<tbl_TrazabilidadPedidos> _TrazabilidadPRepository;
        public TrazabilidadPedidosBusiness(IGenericRepository<tbl_TrazabilidadPedidos> TrazabilidadPRepository)
        {
            _TrazabilidadPRepository = TrazabilidadPRepository;
        }
        public void Add(tbl_TrazabilidadPedidosModel entity)
        {
            _TrazabilidadPRepository.Add(Mapper.Map<tbl_TrazabilidadPedidos>(entity));
        }

        public void Delete(tbl_TrazabilidadPedidosModel entity)
        {
            _TrazabilidadPRepository.Delete(Mapper.Map<tbl_TrazabilidadPedidos>(entity));
        }

        public void Delete(object id)
        {
            _TrazabilidadPRepository.Delete(id);
        }

        public IList<tbl_TrazabilidadPedidosModel> FindBy(Expression<Func<tbl_TrazabilidadPedidosModel, bool>> filter)
        {
            var transportadoras = _TrazabilidadPRepository.FindBy(Mapper.Map<Expression<Func<tbl_TrazabilidadPedidos, bool>>>(filter));
            return Mapper.Map<IList<tbl_TrazabilidadPedidosModel>>(transportadoras);
        }

        public IList<tbl_TrazabilidadPedidosModel> GetAll()
        {
            return Mapper.Map<IList<tbl_TrazabilidadPedidosModel>>(_TrazabilidadPRepository.GetAll());
        }

        public void Update(tbl_TrazabilidadPedidosModel entity)
        {
            _TrazabilidadPRepository.Update(Mapper.Map<tbl_TrazabilidadPedidos>(entity));
        }
    }
}
