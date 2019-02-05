using Core.Domain.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;
using Core.Data.Repository.Interfaces;
using Core.Domain.ViewModel;
using AutoMapper;

namespace Core.Domain.Business
{
    public class BodegaBusiness : IBodegaBusiness
    {
        private IBodegasRepository _bodegasRepo;
        public BodegaBusiness(IBodegasRepository bodegasRepo)
        {
            _bodegasRepo = bodegasRepo;
        }
        public IList<bodegasModel> GetBodegasActivas()
        {
            return Mapper.Map<IList<bodegasModel>>(_bodegasRepo.GetBodegasActivas());
            
        }
    }
}
