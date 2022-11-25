using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using Cadeteria.Models;
using Cadeteria.ViewModels;

namespace Cadeteria.Controllers
{

    public class CadeteriaController : Controller
    {
        private readonly ILogger<CadeteriaController> _logger;

        public CadeteriaController(ILogger<CadeteriaController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult AltaCadete(CadeteViewModel viewModel)
        {
            var cadete = CadeteMapper.mappearACadete(viewModel);
            HelperDeArchivos.insertarCadete(cadete);
            return View();
        }

        
        public IActionResult cargarCadete()
        {
            return View();
        }

        public IActionResult Index()
        {
            List<Cadete> listadoCadetes = new List<Cadete>();
            listadoCadetes = HelperDeArchivos.leerCadetes();
            List<CadeteViewModel> listadoCadeteViewModels = new List<CadeteViewModel>();
            foreach (var item in listadoCadetes)
            {
                var cadeteViewModel = new CadeteViewModel();
                cadeteViewModel = CadeteMapper.mappearACadeteViewModel(item);
                listadoCadeteViewModels.Add(cadeteViewModel);
            }
            return View(listadoCadeteViewModels);
        }

        [HttpGet]
        public IActionResult bajaCadete(string idCadete)
        {
            HelperDeArchivos.eliminarCadete(idCadete);
            return RedirectToAction("Index");
        }

        public IActionResult cargarPedido()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AltaPedido(PedidoViewModel viewModel)
        {
            var pedido= PedidoMapper.mappearAPedido(viewModel);
            HelperDeArchivos.insertarPedido(pedido);
            return RedirectToAction("Index");
        }
    }
}

       
