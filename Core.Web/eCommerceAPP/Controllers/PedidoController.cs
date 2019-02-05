using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Domain.Business.Interfaces;
using Core.Domain.ViewModel;
using eCommerceAPP.Models;

namespace eCommerceAPP.Controllers
{
    [Authorize]
    public class PedidoController : Controller
    {
        private ICatalogoProductosBusiness _catalogoBusiness;
        private IBodegaBusiness _bodegasBusiness;
        private IVendedorBusiness _vendedorBusiness;
        private IPedidosc1W_2000Business _pedidoBusiness;
        private pedidosc1W_2000Model pedido;

        public PedidoController(ICatalogoProductosBusiness catalogoBusiness, IBodegaBusiness bodegasBusiness, IVendedorBusiness vendedorBusiness, IPedidosc1W_2000Business pedidoBusiness)
        {
            _catalogoBusiness = catalogoBusiness;
            _bodegasBusiness = bodegasBusiness;
            _vendedorBusiness = vendedorBusiness;
            _pedidoBusiness = pedidoBusiness;
        }
        // GET: Pedido
        public ActionResult Index()
        {
            if (pedido == null)
                pedido = new pedidosc1W_2000Model();
            pedido.Bodegas = _bodegasBusiness.GetBodegasActivas();
            if (pedido.pedidosc2W_2000 == null)
                pedido.pedidosc2W_2000 = new List<pedidosc2W_2000Model>();

            pedido.fecha = DateTime.Now;
            return View(pedido);
        }

        [HttpPost]
        public JsonResult GetProducts(string prefix)
        {
            var productos = _catalogoBusiness.Get_ProductosByReferencia().Where(prod => prod.Nombre_Producto.Contains(prefix.ToUpper())).Take(10);
            return Json(productos, JsonRequestBehavior.AllowGet);
        }

        
        public JsonResult GetVendedores(string idBodega)
        {
            var vendedores = _vendedorBusiness.GetByNit_IdBodega(/*"860001307-0"*/Session["Nit"].ToString(), idBodega);
            return Json(vendedores, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SavePedido(pedidosc1W_2000Model pedido)
        {
            if(Session["Nit"] != null)
                pedido.nit = Session["Nit"].ToString();

            _pedidoBusiness.Add(pedido);

            return Json("true", JsonRequestBehavior.AllowGet);
        }
    }
}