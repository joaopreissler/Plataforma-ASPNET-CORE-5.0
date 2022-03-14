﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Plataforma.Data;
using Plataforma.Models;
using Plataforma.ViewModels;
using Microsoft.AspNetCore.Authorization;


namespace Plataforma.Controllers
{
    [Authorize]
    [Authorize(Roles = "Admin")]
    public class EmpresasController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public EmpresasController(ApplicationDbContext context)
        {
            _context = context;
            
        }

        // GET: Empresas

        
        public async Task<IActionResult> Index(int anosearch)
        {
            DateTime mydate = DateTime.Now;
            var anos = mydate.Year;
            if (anosearch != 0)
            {
                anos = anosearch;
            }
          
           
            var queryanos = await(from c in _context.Empresa select new Anos { ano = c.ano }).Distinct().OrderBy(c => c.ano).ToListAsync();

            var queryEnero = await _context.Empresa.Where(x => x.Idcurso == 1).Where(y => y.ano == anos).OrderBy(id => id).ToListAsync();
            var queryFebrero = await _context.Empresa.Where(x => x.Idcurso == 2).Where(y => y.ano == anos).OrderBy(id => id).ToListAsync();
            var queryMarzo = await _context.Empresa.Where(x => x.Idcurso == 3).Where(y => y.ano == anos).OrderBy(id => id).ToListAsync();
            var queryAbril = await  _context.Empresa.Where(x => x.Idcurso == 4).Where(y => y.ano == anos).OrderBy(id => id).ToListAsync();
            var queryMayo = await _context.Empresa.Where(x => x.Idcurso == 5).Where(y => y.ano == anos).OrderBy(id => id).ToListAsync();
            var queryJunio = await _context.Empresa.Where(x => x.Idcurso == 6).Where(y => y.ano == anos).OrderBy(id => id).ToListAsync();
            var queryJulio = await _context.Empresa.Where(x => x.Idcurso == 7).Where(y => y.ano == anos).OrderBy(id => id).ToListAsync();
            var queryAgosto = await _context.Empresa.Where(x => x.Idcurso == 8).Where(y => y.ano == anos).OrderBy(id => id).ToListAsync();
            var querySeptembro = await _context.Empresa.Where(x => x.Idcurso == 9).Where(y => y.ano == anos).OrderBy(id => id).ToListAsync();
            var queryOctubre = await _context.Empresa.Where(x => x.Idcurso == 10).Where(y => y.ano == anos).OrderBy(id => id).ToListAsync();
            var queryNoviembre = await _context.Empresa.Where(x => x.Idcurso == 11).Where(y => y.ano == anos).OrderBy(id => id).ToListAsync();
            var queryDeciembre = await _context.Empresa.Where(x => x.Idcurso == 12).Where(y => y.ano == anos).OrderBy(id => id).ToListAsync();
            /* select Nombre_Empresa,Nombre_Comercial,Nif,Final from Plataforma.dbo.Empresa as B
             outer apply 
             (SELECT TOP 1 * FROM Plataforma.dbo.EmpresaCurso A 
             where A.IdEmpresa = B.Id ORDER BY A.Final DESC) as A
             */




            var empresas = new EmpresasIndexViewModel()
            {
                anos = queryanos,
                Enero = queryEnero,
                Febrero = queryFebrero,
                Marzo = queryMarzo,
                Abril = queryAbril,
                Mayo = queryMayo,
                Junio = queryJunio,
                Julio = queryJulio,
                Agosto = queryAgosto,
                Setembro = querySeptembro,
                Outubro = queryOctubre,
                Novembro = queryNoviembre,
                Dezembro = queryDeciembre,
                anoatual = (int)anos
            };

           

            return View(empresas);
        }


        // GET: Empresas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresa = await _context.Empresa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

        // GET: Empresas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Empresas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empresa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empresa);
        }

        // GET: Empresas/Edit/5
        public IActionResult Edit(int id)
        {
            
            var query = (from a in _context.Cursos
                        select a).ToList(); 
            var query2= (from a in _context.Empresa
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
        public  IActionResult Edit(int id, EmpresaCurso obj)
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

        // GET: Empresas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresa = await _context.Empresa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

        // POST: Empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empresa = await _context.Empresa.FindAsync(id);
            _context.Empresa.Remove(empresa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpresaExists(int id)
        {
            return _context.Empresa.Any(e => e.Id == id);
        }

        public IActionResult salvarcurso(int id)
        {


            return RedirectToAction(nameof(Index));
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


            return RedirectToAction("Edit", new { id = id });
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
        public IActionResult Empresaano(int id)
        {
            var vm = new EmpresaanoViewModel() { 
            EmpresaId = id
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InsertarEmpresaAno(EmpresaanoViewModel obj)
        {

            if (ModelState.IsValid)
            {
                var empresas = (from a in _context.Empresa
                                where a.Id.Equals(obj.EmpresaId)
                                select a).FirstOrDefault();
                var trabajadores = (from a in _context.Trabajadores
                                    where a.IdEmpresa.Equals(obj.EmpresaId)
                                    where a.AnoTrabajador.Equals(empresas.ano)
                                    where a.Mestrabajador.Equals(empresas.Idcurso)
                                    select a).ToList();

                Empresa empresa = new Empresa()
                {
                    Nombre_Empresa = empresas.Nombre_Empresa,
                    Nombre_Comercial = empresas.Nombre_Comercial,
                    Nif = empresas.Nif,
                    Direccion = empresas.Direccion,
                    Cp = empresas.Cp,
                    Provincia = empresas.Provincia,
                    Localidad = empresas.Localidad,
                    DireccionComercial = empresas.DireccionComercial,
                    CPComercial = empresas.CPComercial,
                    ProvinciaComercial = empresas.ProvinciaComercial,
                    LocalidadComercial = empresas.LocalidadComercial,
                    Telefono = empresas.Telefono,
                    email = empresas.email,
                    CuentaCotizacion = empresas.CuentaCotizacion,
                    sector = empresas.sector,
                    convenio = empresas.convenio,
                    actividadprincial = empresas.actividadprincial,
                    CNAE = empresas.CNAE,
                    Representacionlegal = empresas.Representacionlegal,
                    nuevacreacion = empresas.nuevacreacion,
                    creditodisponible = empresas.creditodisponible,
                    Banco = empresas.Banco,
                    Cuenta = empresas.Cuenta,
                    creacion = empresas.creacion,
                    venta = empresas.venta,
                    Nombrereprensentante = empresas.Nombrereprensentante,
                    Generorepresentante = empresas.Generorepresentante,
                    nifrepresentante = empresas.nifrepresentante,
                    Fechafirma = empresas.Fechafirma,
                    nombregestoria = empresas.nombregestoria,
                    contatogestoria = empresas.contatogestoria,
                    emailgestoria = empresas.emailgestoria,
                    telefonogestoria = empresas.telefonogestoria,
                    ano = obj.Ano,
                    Idcurso = obj.mes,
                    seguridad_social = empresas.seguridad_social
                    
                };
                _context.Empresa.Add(empresa);
                _context.SaveChanges();

                var nuevaempresa = (from a in _context.Empresa
                                    where a.ano.Equals(obj.Ano)
                                    where a.Idcurso.Equals(obj.mes)
                                    orderby a.Id
                                    select a).LastOrDefault();
                foreach (var item in trabajadores)
                {
                    Trabajadores trabajador = new Trabajadores
                    {
                        TrabajadorNome = item.TrabajadorNome,
                        TrabajadorNif = item.TrabajadorNif,
                        IdEmpresa = nuevaempresa.Id,
                        Fundae = item.Fundae,
                        SeguridadSocial = item.SeguridadSocial,
                        FechaTrabajador = item.FechaTrabajador,
                        Trabajadortipo = item.Trabajadortipo,
                        TrabajadorAlta = item.TrabajadorAlta,
                        AnoTrabajador = obj.Ano,
                        Mestrabajador = obj.mes
                    };
                    _context.Trabajadores.Add(trabajador);
                    _context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View("Empresaano", obj);
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
        public IActionResult BorrarCurso(int id)
        { var curso = _context.EmpresaCurso.Where(x => x.Id == id).FirstOrDefault();
            var empresa = _context.Empresa.Where(x => x.Id == curso.IdEmpresa).FirstOrDefault();
            _context.EmpresaCurso.Remove(curso);
            _context.SaveChanges();
            
            return RedirectToAction("Edit", new { empresa.Id });
        }
    }
  
    
}
