using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tp5Solution.Helpers;
using Tp5Solution.Models;
using Tp5Solution.ViewModels;

namespace Tp5Solution.Controllers
{
    public class CadetesController : Controller
    {
        // GET: CadetesController
        public ActionResult Index()
        {
            List<Cadete> cadetes = new List<Cadete>();
            cadetes = ArchivosHelper.LeerCadetes();
            IMapper mapper = AutoMapperBase.Instance().CreateMapper();
            List<CadeteViewModel> cadeteViewModels = mapper.Map<List<Cadete>, List<CadeteViewModel>>(cadetes);
            return View(cadeteViewModels);
        }
        // GET: CadetesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadetesController/Create
        [HttpPost]
        public IActionResult AltaCadete(CadeteViewModel viewModel)
        {
            IMapper mapper = AutoMapperBase.Instance().CreateMapper();
            var cadete = mapper.Map<CadeteViewModel, Cadete>(viewModel);
            ArchivosHelper.InsertarCadete(cadete);
            return RedirectToAction("Index");  
        }

        [HttpGet]
        public IActionResult Delete(string Id)
        {
            ArchivosHelper.EliminarCadete(Id);
            return RedirectToAction("Index");
        }
    }
}
