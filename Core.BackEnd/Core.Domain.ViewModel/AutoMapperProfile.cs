using AutoMapper;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ViewModel
{
    public class AutoMapperProfile : Profile
    {
        public static void Run()
        {
            Mapper.Initialize(a => {
                a.AddProfile<AutoMapperProfile>();
                });
        }
        
        public AutoMapperProfile()
        {
            CreateMap<tbl_CCostosCompradores, tbl_CCostosCompradoresModel>().ReverseMap();
            CreateMap<tbl_Transportadoras, tbl_TransportadorasModel>().ReverseMap();
            CreateMap<tbl_CatalogoProductos, tbl_CatalogoProductosModel>().ReverseMap();
            CreateMap<tbl_Transportadoras, tbl_TransportadorasModel>().ReverseMap();
            CreateMap<bodegas, bodegasModel>().ReverseMap();
            CreateMap<GetVendedores_Result, GetVendedores_ResultModel>().ReverseMap();
            CreateMap<pedidosc1W_2000, pedidosc1W_2000Model>().ReverseMap();
            CreateMap<pedidosc2W_2000, pedidosc2W_2000Model>().ReverseMap();
            CreateMap<Get_ProductosByReferencia_Result, Get_ProductosByReferencia_ResultModel>().ReverseMap();
            CreateMap<Expression<Func<tbl_CCostosCompradores, bool>>, Expression<Func<tbl_CCostosCompradoresModel, bool>>>().ReverseMap();
            CreateMap<Expression<Func<tbl_Transportadoras, bool>>, Expression<Func<tbl_TransportadorasModel, bool>>>().ReverseMap();
            CreateMap<Expression<Func<tbl_CatalogoProductos, bool>>, Expression<Func<tbl_CatalogoProductosModel, bool>>>().ReverseMap();
            CreateMap<Expression<Func<tbl_Transportadoras, bool>>, Expression<Func<tbl_TransportadorasModel, bool>>>().ReverseMap();
        }
    }
}
