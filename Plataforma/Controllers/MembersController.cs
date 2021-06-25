
using Amazon.S3;
using Amazon.S3.Model;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plataforma.Data;
using Plataforma.Models;
using Plataforma.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UploadToS3Demo;

namespace Plataforma.Controllers
{
    [Authorize(Roles = "Member")]
    public class MembersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly IHostingEnvironment Environment;

        public MembersController(ApplicationDbContext context, IHttpContextAccessor httpContext, IHostingEnvironment _environment)
        {
            _context = context;
            _httpContext = httpContext;
            Environment = _environment;
        }

        public IActionResult Index()
        {
            var user = User.Identity.GetUserId();
            var empresas = _context.Empresa.Where(x => x.IdMember == user).ToList();

            EmpresasEditViewModel result = new EmpresasEditViewModel
            {
                Empresas = empresas
            };
            return View(result);
        }
       

        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                empresa.IdMember = User.Identity.GetUserId();
                _context.Add(empresa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empresa);
        }
        public IActionResult Editar(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();
            return View(empresa);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, Empresa obj)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();


            empresa.Nombre_Empresa = obj.Nombre_Empresa;
            empresa.Nombre_Comercial = obj.Nombre_Comercial;
            empresa.Nif = obj.Nif;
            empresa.Direccion = obj.Direccion;
            empresa.Cp = obj.Cp;
            empresa.seguridad_social = obj.seguridad_social;
            empresa.Provincia = obj.Provincia;
            empresa.Localidad = obj.Localidad;
            empresa.DireccionComercial = obj.DireccionComercial;
            empresa.CPComercial = obj.CPComercial;
            empresa.ProvinciaComercial = obj.ProvinciaComercial;
            empresa.LocalidadComercial = obj.LocalidadComercial;
            empresa.Telefono = obj.Telefono;
            empresa.email = obj.email;
            empresa.CuentaCotizacion = obj.CuentaCotizacion;
            empresa.sector = obj.sector;
            empresa.convenio = obj.convenio;
            empresa.actividadprincial = obj.actividadprincial;
            empresa.CNAE = obj.CNAE;
            empresa.Representacionlegal = obj.Representacionlegal;
            empresa.nuevacreacion = obj.nuevacreacion;
            empresa.creditodisponible = obj.creditodisponible;
            empresa.Banco = obj.Banco;
            empresa.Cuenta = obj.Cuenta;
            empresa.creacion = obj.creacion;
            empresa.venta = obj.venta;
            empresa.Nombrereprensentante = obj.Nombrereprensentante;
            empresa.Generorepresentante = obj.Generorepresentante;
            empresa.nifrepresentante = obj.nifrepresentante;
            empresa.Fechafirma = obj.Fechafirma;
            empresa.nombregestoria = obj.nombregestoria;
            empresa.contatogestoria = obj.contatogestoria;
            empresa.emailgestoria = obj.emailgestoria;
            empresa.telefonogestoria = obj.telefonogestoria;




            _context.SaveChanges();
            return View(empresa);
        }
        public IActionResult Edit(int id)
        {

            var query = (from a in _context.Cursos
                         select a).ToList();
            var query2 = (from a in _context.Empresa
                          where a.Id.Equals(id)
                          select a).ToList();
            var anoempresa = (from a in _context.Empresa
                              where a.Id.Equals(id)
                              select a).FirstOrDefault();
            var query3 = (from s in _context.EmpresaCurso
                          where s.IdEmpresa.Equals(id)
                          select s).ToList();
            /*ViewBag.EmpresaQuery = query2;*/
            var empresacurso = _context.EmpresaCurso.Where(x => x.IdEmpresa == id).FirstOrDefault();

            var query4 = (from s in _context.Trabajadores where s.IdEmpresa.Equals(id) where s.AnoTrabajador.Equals(anoempresa.ano) where s.Mestrabajador.Equals(anoempresa.Idcurso) where s.TrabajadorAlta.Equals(true) select s).ToList();
            var query5 = (from s in _context.Trabajadores where s.IdEmpresa.Equals(id) where s.AnoTrabajador.Equals(anoempresa.ano) where s.Mestrabajador.Equals(anoempresa.Idcurso) where s.TrabajadorAlta.Equals(false) select s).ToList();
            EmpresasEditViewModel empresascurso = new EmpresasEditViewModel()
            {
                Empresas = query2,
                Curso = query,
                CursosNome = query3,
                Trabajadores = query4,
                TrabajadoresBaja = query5,
                NewCurso = empresacurso
            };
            return View(empresascurso);
        }


        // POST: Empresas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, EmpresaCurso obj)
        {
            EmpresaCurso empresacurso = new EmpresaCurso()
            {
                CursoNome = obj.CursoNome,
                IdEmpresa = id,
                Inicio = obj.Inicio,
                Final = obj.Final
            };
            _context.EmpresaCurso.Add(empresacurso);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }
        public IActionResult AddTrabajador()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddTrabajador(int id, Trabajadores obj)
        {
            var anoempresa = (from a in _context.Empresa
                              where a.Id.Equals(id)
                              select a).FirstOrDefault();
            Trabajadores trabajador = new Trabajadores()
            {
                TrabajadorNome = obj.TrabajadorNome,
                TrabajadorNif = obj.TrabajadorNif,
                IdEmpresa = id,
                Fundae = obj.Fundae,
                SeguridadSocial = obj.SeguridadSocial,
                FechaTrabajador = obj.FechaTrabajador,
                Trabajadortipo = obj.Trabajadortipo,
                TrabajadorAlta = obj.TrabajadorAlta,
                AnoTrabajador = anoempresa.ano,
                Mestrabajador = anoempresa.Idcurso

            };
            _context.Trabajadores.Add(trabajador);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }
        public IActionResult BajaTrabajador(int id)
        {
            var trabajadores = (from a in _context.Trabajadores
                                where a.Id.Equals(id)
                                select a).FirstOrDefault();
            trabajadores.TrabajadorAlta = false;
            _context.SaveChanges();
            return RedirectToAction("Edit", new { id = trabajadores.IdEmpresa });
        }
        public IActionResult AltaTrabajador(int id)
        {
            var trabajadores = (from a in _context.Trabajadores
                                where a.Id.Equals(id)
                                select a).FirstOrDefault();
            trabajadores.TrabajadorAlta = true;
            _context.SaveChanges();
            return RedirectToAction("Edit", new { id = trabajadores.IdEmpresa });
        }
        public IActionResult EditTrabajador(int id)
        {
            var trabajadores = (from a in _context.Trabajadores
                                where a.Id.Equals(id)
                                select a).FirstOrDefault();
            Trabajadores nuevo = new Trabajadores()
            {
                IdEmpresa = trabajadores.IdEmpresa,
                Id = id

            };
            TempData["Empresa"] = trabajadores.IdEmpresa;
            TempData["Id"] = trabajadores.Id;

            return View(trabajadores);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditarTrabajador(Trabajadores obj)
        {
            var trabajadores = (from a in _context.Trabajadores
                                where a.Id.Equals(TempData["Id"])
                                select a).FirstOrDefault();

            obj.AnoTrabajador = trabajadores.AnoTrabajador;


            trabajadores.IdEmpresa = (int)TempData["Empresa"];
            trabajadores.FechaTrabajador = obj.FechaTrabajador;
            trabajadores.TrabajadorNome = obj.TrabajadorNome;
            trabajadores.Fundae = obj.Fundae;
            trabajadores.SeguridadSocial = obj.SeguridadSocial;
            trabajadores.TrabajadorAlta = obj.TrabajadorAlta;
            trabajadores.TrabajadorNif = obj.TrabajadorNif;
            trabajadores.Trabajadortipo = obj.Trabajadortipo;
            _context.SaveChanges();

            return RedirectToAction("Edit", new { id = trabajadores.IdEmpresa });
        }
        
        public IActionResult UploadFile(IFormFile File)
        {

            /*string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;
            
            string path = System.IO.Path.Combine(this.Environment.WebRootPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }



            string fileName = System.IO.Path.GetFileName(File.FileName);
            using (FileStream stream = new FileStream(System.IO.Path.Combine(path, fileName), FileMode.Create))
                {
                    File.CopyTo(stream);
                

            }
            
            string fileToBackup = File.FileName; // test file
            string myBucketName = "eurobrazil-formacion-files"; //your s3 bucket name goes here
            string s3DirectoryName = "files";
            string s3FileName = File.FileName;


          
            
            AmazonUploader myUploader = new AmazonUploader();
            myUploader.sendMyFileToS3(Stream, myBucketName, s3DirectoryName, s3FileName);
          */
            if (File is null) return View();
            if (File.ContentType != "application/pdf") return View(); 

            PdfReader reader = new PdfReader(File.OpenReadStream());
            int PageNum = reader.NumberOfPages;
            string[] words;
            string line;

            for (int i = 1; i <= PageNum; i++)
            {
                var text = PdfTextExtractor.GetTextFromPage(reader, i, new LocationTextExtractionStrategy());

                words = text.Split('\n');
                for (int j = 0, len = words.Length; j < len; j++)
                {
                    line = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(words[j]));
                    ViewBag.line = line;
                }
                ViewBag.words = words;
                
            }
            
            string[] names = ViewBag.words;

            var Razonsocial = "RAZÓN SOCIAL: ";
            var result = Array.Find(names, element => element.Contains(Razonsocial));
            var returnData = result.Split(':');

            var Domicilio = "DOMICILIO:";
            var domi = Array.Find(names, element => element.Contains(Domicilio));
            var returnData2 = domi.Split(':');

            var Cp = "C.P.:";
            var cp = Array.Find(names, element => element.Contains(Cp));
            var returnData3 = cp.Split(':');

            
            var Datos = "CÓDIGO EMPRESARIO:";
            var datos = Array.Find(names, element => element.Contains(Datos));
            var returnData4 = datos.Split(' ');

            var cnae = "CNAE:";
            var CNAE = Array.Find(names, element => element.Contains(cnae));
            var returnData5 = CNAE.Split(' ');

            
            Empresa NewEmpresa = new Empresa
            {
                Nombre_Empresa = returnData[1],
                Nombre_Comercial = returnData[1],
                Direccion = returnData2[1],
                Cp = Regex.Replace(returnData3[6], "[A-Za-z ]", ""),
                Provincia = returnData3[8],
                Localidad = Regex.Replace(returnData3[7], "PROVINCIA", ""),
                Nif = returnData4[3].TrimStart('0'),
                seguridad_social = returnData4[8] + returnData4[9],
                CNAE = returnData5[1] + returnData5[2] + returnData5[3] + returnData5[4],
                ano = DateTime.UtcNow.Year,
                Idcurso = DateTime.UtcNow.Month,
                IdMember = User.Identity.GetUserId(),
                Fechafirma = DateTime.UtcNow
            };
            _context.Empresa.Add(NewEmpresa);

            _context.SaveChanges();
            var trabajadoresInicio = Array.FindIndex(names, element => element.Contains("APELLIDOS Y NOMBRE"));
            var trabajadoresFin = Array.FindIndex(names, element => element.Contains("FIN DE INFORME"));
            
            for (int i = trabajadoresInicio + 1; i <= trabajadoresFin-1; i++)
            {
                var empresa = _context.Empresa.Where(x => x.Nombre_Empresa == returnData[1]).OrderBy(y => y.Id).LastOrDefault();
                var nombre = names[i].Split('0' , 2);
               // var nombrefix = Regex.Replace(nombre.ToString(), "[0 - 9]{ 2,}", "");
                var nif = names[i].Split('0', 3);
                var seguridadsocial = names[i].Split('0', 2);
                var control = names[i].Length;
                var nombrenif = nombre[1].Substring(15, 10);
                if (nombre[1].Substring(15, 10).StartsWith("0")){
                  nombrenif = nombre[1].Substring(16, 10);
                }
                
                if (names[i].Length > 50 && nombre[0].Any(char.IsLetter) == true) { 

                Trabajadores newTrabajadores = new Trabajadores
                {
                    TrabajadorNome = nombre[0].TrimEnd(new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }),
                    TrabajadorNif = nombrenif,
                    IdEmpresa = empresa.Id,
                    SeguridadSocial =Regex.Replace(names[i].Substring(nombre[0].TrimEnd(new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }).Length, 13), " ", ""),
                    Trabajadortipo = "Trabajador",
                    AnoTrabajador = empresa.ano,
                    Mestrabajador = empresa.Idcurso,
                    TrabajadorAlta = true
                };
                _context.Trabajadores.Add(newTrabajadores);
                }
            }
            _context.SaveChanges();

            //System.IO.File.Delete(System.IO.Path.Combine(path, fileName));
            
            return RedirectToAction("Index");
        }
    }
}
