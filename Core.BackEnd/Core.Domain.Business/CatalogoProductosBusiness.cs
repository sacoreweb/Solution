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
    public class CatalogoProductosBusiness : ICatalogoProductosBusiness
    {
        private IGenericRepository<tbl_CatalogoProductos> _CatalogoProductosRepository;
        private IProductosRepository _productosRepository;
        public CatalogoProductosBusiness(IGenericRepository<tbl_CatalogoProductos> CatalogoProductosRepository, IProductosRepository productosRepository)
        {
            _CatalogoProductosRepository = CatalogoProductosRepository;
            _productosRepository = productosRepository;
        }

        public void Add(tbl_CatalogoProductosModel entity)
        {
            _CatalogoProductosRepository.Add(Mapper.Map<tbl_CatalogoProductos>(entity));
        }

        public void Delete(tbl_CatalogoProductosModel entity)
        {
            _CatalogoProductosRepository.Delete(Mapper.Map<tbl_CatalogoProductosModel>(entity));
        }

        public void Delete(object id)
        {
            _CatalogoProductosRepository.Delete(id);
        }

        public IList<tbl_CatalogoProductosModel> FindBy(Expression<Func<tbl_CatalogoProductosModel, bool>> filter)
        {
            var catalogoProductos = _CatalogoProductosRepository.FindBy(Mapper.Map<Expression<Func<tbl_CatalogoProductos, bool>>>(filter));
            return Mapper.Map<IList<tbl_CatalogoProductosModel>>(catalogoProductos);
        }

        public IList<tbl_CatalogoProductosModel> GetAll()
        {
            return Mapper.Map<IList<tbl_CatalogoProductosModel>>(_CatalogoProductosRepository.GetAll());
        }

        public IList<Get_ProductosByReferencia_ResultModel> Get_ProductosByReferencia()
        {
            return Mapper.Map<IList<Get_ProductosByReferencia_ResultModel>>(_productosRepository.Get_ProductosByReferencia());
        }

        public void Update(tbl_CatalogoProductosModel entity)
        {
            _CatalogoProductosRepository.Update(Mapper.Map<tbl_CatalogoProductos>(entity));
        }
    }
}
