using Core.Domain.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.ViewModel;
using Core.Data.Repository;
using Core.Data.Repository.Interfaces;
using AutoMapper;

namespace Core.Domain.Business
{
    public class VendedorBusiness : IVendedorBusiness
    {
        private IVendedorRepository _vendedorRepository;
        public VendedorBusiness(IVendedorRepository vendedorRepository)
        {
            _vendedorRepository = vendedorRepository;
        }
        public IEnumerable<GetVendedores_ResultModel> GetByNit_IdBodega(string nit, string idBodega)
        {
            //Ahora Si!! a crear un repositorio concreto.....
            var vendedores = _vendedorRepository.GetByNit_IdBodega(nit, idBodega);
            return Mapper.Map<IEnumerable<GetVendedores_ResultModel>>(vendedores);
            
        }
    }
}
