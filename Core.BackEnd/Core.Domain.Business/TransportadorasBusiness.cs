using Core.Domain.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.ViewModel;
using System.Linq.Expressions;
using Core.Data.Repository;
using Core.Entity;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Data.Repository.Interfaces;

namespace Core.Domain.Business
{
    public class TransportadorasBusiness : ITransportadorasBusiness
    {
        private IGenericRepository<tbl_Transportadoras> _TransportadorasRepository;
        public TransportadorasBusiness(IGenericRepository<tbl_Transportadoras> TransportadorasRepository)
        {
            _TransportadorasRepository = TransportadorasRepository;
        }
        public void Add(tbl_TransportadorasModel entity)
        {
            _TransportadorasRepository.Add(Mapper.Map<tbl_Transportadoras>(entity));
        }

        public void Delete(tbl_TransportadorasModel entity)
        {
            _TransportadorasRepository.Delete(Mapper.Map<tbl_Transportadoras>(entity));
        }

        public void Delete(object id)
        {
            _TransportadorasRepository.Delete(id);
        }

        public IList<tbl_TransportadorasModel> FindBy(Expression<Func<tbl_TransportadorasModel, bool>> filter)
        {
            var transportadoras = _TransportadorasRepository.FindBy(Mapper.Map<Expression<Func<tbl_Transportadoras, bool>>>(filter));
            return Mapper.Map<IList<tbl_TransportadorasModel>>(transportadoras);
        }

        public IList<tbl_TransportadorasModel> GetAll()
        {
            return Mapper.Map<IList<tbl_TransportadorasModel>>(_TransportadorasRepository.GetAll());
        }

        public void Update(tbl_TransportadorasModel entity)
        {
            _TransportadorasRepository.Update(Mapper.Map<tbl_Transportadoras>(entity));
        }
    }
}
