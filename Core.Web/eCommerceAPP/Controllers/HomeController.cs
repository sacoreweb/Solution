using Core.Domain.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerceAPP.Controllers
{
    public class HomeController : Controller
    {
        private ITransportadorasBusiness _transportadorasBusiness;
        private IVendedorBusiness _vendedorBusiness;
        private IBodegaBusiness _bodegasBusiness;


        public HomeController(ITransportadorasBusiness transportadorasBusiness, IVendedorBusiness vendedorBusiness,
            IBodegaBusiness bodegasBusiness)
        {
            _transportadorasBusiness = transportadorasBusiness;
            _vendedorBusiness = vendedorBusiness;
            _bodegasBusiness = bodegasBusiness;
        }
        public ActionResult Index()
        {
            //var transportadoras = _transportadorasBusiness.GetAll();
            //
            //var vendedores = _vendedorBusiness.GetByNit_IdBodega("860001307-0", "002");
            //var bodegas = _bodegasBusiness.GetBodegasActivas();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}