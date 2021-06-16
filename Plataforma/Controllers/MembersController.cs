using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plataforma.Data;
using Plataforma.Models;
using Plataforma.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Plataforma.Controllers
{
    [Authorize(Roles = "Member")]
    public class MembersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContext;

        public MembersController(ApplicationDbContext context, IHttpContextAccessor httpContext)
        {
            _context = context;
            _httpContext = httpContext;
            
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
            trabajadores.AnoTrabajador = obj.AnoTrabajador;
            trabajadores.TrabajadorNome = obj.TrabajadorNome;
            trabajadores.Fundae = obj.Fundae;
            trabajadores.SeguridadSocial = obj.SeguridadSocial;
            trabajadores.TrabajadorAlta = obj.TrabajadorAlta;
            trabajadores.TrabajadorNif = obj.TrabajadorNif;
            trabajadores.Trabajadortipo = obj.Trabajadortipo;
            _context.SaveChanges();

            return RedirectToAction("Edit", new { id = trabajadores.IdEmpresa });
        }
        

    }
}
