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
using Core.Data.Repository.Interfaces;

namespace Core.Domain.Business
{
    public class CCostosCompradoresBusinees : ICCostosCompradoresBusinees
    {
        private IGenericRepository<tbl_CCostosCompradores> _cCostosRepository;
        public CCostosCompradoresBusinees(IGenericRepository<tbl_CCostosCompradores> cCostosRepository)
        {
            _cCostosRepository = cCostosRepository;
        }
        public void Add(tbl_CCostosCompradoresModel entity)
        {
            _cCostosRepository.Add(Mapper.Map<tbl_CCostosCompradores>(entity));
        }

        public void Delete(tbl_CCostosCompradoresModel entity)
        {
            _cCostosRepository.Delete(Mapper.Map<tbl_CCostosCompradores>(entity));
        }

        public void Delete(object id)
        {
            _cCostosRepository.Delete(id);
        }

        public IList<tbl_CCostosCompradoresModel> FindBy(Expression<Func<tbl_CCostosCompradoresModel, bool>> filter)
        {
            var costos = _cCostosRepository.FindBy(Mapper.Map<Expression<Func<tbl_CCostosCompradores, bool>>>(filter));
            return Mapper.Map<IList<tbl_CCostosCompradoresModel>>(costos);
        }

        public IList<tbl_CCostosCompradoresModel> GetAll()
        {
            return Mapper.Map<IList<tbl_CCostosCompradoresModel>>(_cCostosRepository.GetAll());
        }

        public void Update(tbl_CCostosCompradoresModel entity)
        {
            _cCostosRepository.Update(Mapper.Map<tbl_CCostosCompradores>(entity));
        }
    }
}
