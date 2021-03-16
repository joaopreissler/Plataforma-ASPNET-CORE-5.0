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
    public class EmpresasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmpresasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Empresas
        public IActionResult Index(int anos)
        {
            if (anos == 0)
            {
                DateTime mydate = DateTime.Now;
                anos = mydate.Year;
            }
            var queryanos = (from c in _context.Empresa select new anos { ano = c.ano}).Distinct();
              
            var queryEnero = (from c in _context.Empresa
                         let variable = _context.EmpresaCurso.Where(y => y.IdEmpresa == c.Id).Select(x => x.Final).OrderByDescending(b => b).FirstOrDefault()
                         where c.Idcurso.Equals(1) where c.ano.Equals(anos)
                              select new teste{
                            Nombre_Empresa = c.Nombre_Empresa.Replace(" ",""),
                            Nombre_Comercial = c.Nombre_Comercial,
                            Nif = c.Nif,
                            Final = variable,
                            Id = c.Id
                        }).ToList();
            var queryFebrero = (from c in _context.Empresa
                              let variable = _context.EmpresaCurso.Where(y => y.IdEmpresa == c.Id).Select(x => x.Final).OrderByDescending(b => b).FirstOrDefault()
                              where c.Idcurso.Equals(2) where c.ano.Equals(anos)
                              select new teste
                              {
                                  Nombre_Empresa = c.Nombre_Empresa.Replace(" ", ""),
                                  Nombre_Comercial = c.Nombre_Comercial,
                                  Nif = c.Nif,
                                  Final = variable,
                                  Id = c.Id
                              }).ToList();

            /*
             * select Nombre_Empresa,Nombre_Comercial,Nif,Final from Plataforma.dbo.Empresa as B
             outer apply 
             (SELECT TOP 1 * FROM Plataforma.dbo.EmpresaCurso A 
             where A.IdEmpresa = B.Id ORDER BY A.Final DESC) as A
             */




            EmpresasIndexViewModel empresas = new EmpresasIndexViewModel()
            {
                anos = (IEnumerable<anos>)queryanos,
                Enero = queryEnero,
                Febrero = queryFebrero
                
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
        public async Task<IActionResult> Create([Bind("Id,Nombre_Empresa,Nombre_Comercial,Nif,Direccion,Cp,Provincia,Localidad,DireccionComercial,CPComercial,ProvinciaComercial,LocalidadComercial,Telefono,email,CuentaCotizacion,sector,convenio,actividadprincial,CNAE,Representacionlegal,nuevacreacion,creditodisponible,Banco,Cuenta,creacion,venta,Nombrereprensentante,Generorepresentante,nifrepresentante,Fechafirma,nombregestoria,contatogestoria,emailgestoria,telefonogestoria,ano")] Empresa empresa)
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
            var query3 = (from s in _context.EmpresaCurso
                          where s.IdEmpresa.Equals(id)
                          select s).ToList();
            /*ViewBag.EmpresaQuery = query2;*/

            EmpresasEditViewModel empresascurso = new EmpresasEditViewModel()
            {
                Empresas = query2,
                Curso = query,
                CursosNome = query3 
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
    }
}
