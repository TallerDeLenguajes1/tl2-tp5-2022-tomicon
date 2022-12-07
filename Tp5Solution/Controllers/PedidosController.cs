using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tp5Solution.Models;
using Tp5Solution.ViewModels;
using Tp5Solution.Helpers;
using AutoMapper;

namespace Tp5Solution.Controllers
{
    public class PedidosController : Controller
    {
        // GET: PedidosController
        public ActionResult Index()
        {
            List<Pedido> listadoPedidos = new List<Pedido>();
            listadoPedidos = ArchivosHelper.LeerPedidos();
            List<PedidoViewModel> listadoPedidoViewModels = new List<PedidoViewModel>();
            IMapper mapper = AutoMapperBase.Instance().CreateMapper();
            listadoPedidoViewModels = mapper.Map<List<Pedido>, List<PedidoViewModel>>(listadoPedidos);
            return View(listadoPedidoViewModels);
        }

        // GET: PedidosController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AltaPedido(PedidoViewModel viewModel)
        {
            IMapper mapper = AutoMapperBase.Instance().CreateMapper();
            var pedido = mapper.Map<PedidoViewModel, Pedido>(viewModel);
            ArchivosHelper.InsertarPedido(pedido);
            return RedirectToAction("Index");  
        }

        // GET: PedidosController/Delete/5
        public ActionResult Delete(string id)
        {
            ArchivosHelper.EliminarPedido(id);
            return RedirectToAction("Index");
        }
    }
}
