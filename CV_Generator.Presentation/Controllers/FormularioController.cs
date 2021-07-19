using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using CV_Generator.Domain.Correos;
using CV_Generator.Domain.CV;
using CV_Generator.Domain.Model;
using CV_Generator.Presentation.Models;
using System.Configuration;

namespace CV_Generator.Presentation.Controllers
{
    [Route("[controller]/[action]")]
    public class FormularioController : Controller
    {

        // GET: FormularioController
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(InfoDTOModel DTO)
        {

            if (ModelState.IsValid)
            {
                InfoDTO info = new InfoDTO(DTO.Nombre, DTO.Apellidos, DTO.Empresa, DTO.Email);

                if (CvGenerator.GenerarCurriculum(info))
                    if (Correo.EnviarCorreo(info))
                        return View("Agradecimiento");

                return View("Disculpas");
            } 
            else
            {
                return View(DTO);
            }

        }

        [HttpGet]
        public FileResult Descarga()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(ConfigurationManager.AppSettings["PathCurriculum"]);
            string fileName = "CV_JuanAntonioSanchezCarmona.pdf";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Pdf, fileName);
        }



    }
}
