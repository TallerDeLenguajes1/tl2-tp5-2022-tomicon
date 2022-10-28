using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;

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
        public IActionResult AltaCadete(int idCadete, string nombCadete, string apeCadete, string telCadete)
        {
            string linea= $"{idCadete};{nombCadete};{apeCadete};{telCadete}";
            string nombreArchivo= "Cadetes.csv";
            bool archivoExiste= System.IO.File.Exists(nombreArchivo);
            StreamWriter escritor = System.IO.File.AppendText(nombreArchivo);
            if (!archivoExiste)
            {
                escritor.WriteLine("ID;Nombre;Apellido;Telefono");
            }
            escritor.WriteLine(linea);
            escritor.Close();
            return View();
        }

        
        public IActionResult cargarCadete()
        {
            return View();
        }

        public IActionResult listarCadetes()
        {
            return View();
        }

        [HttpGet]
        public IActionResult bajaCadete(string idCadete)
        {
            string nombreArchivo = "Cadetes.csv";
            List<string> lineasCadetes= new List<string>();
                foreach (var linea in System.IO.File.ReadAllLines(nombreArchivo))
                {
                    if (linea != "")
                    {
                        var informacion = linea.Split(";");
                        string id= informacion[0];
                        if (id != idCadete.Trim())
                        {
                            string datosCadete=$"{informacion[0]};{informacion[1]};{informacion[2]};{informacion[3]}";
                            lineasCadetes.Add(datosCadete);
                        }
                    }
                }
                System.IO.File.Delete("Cadetes.csv");
                System.IO.File.WriteAllLines("Cadetes.csv",lineasCadetes);
            return RedirectToAction("listarCadetes");
        }
    }
}

       
