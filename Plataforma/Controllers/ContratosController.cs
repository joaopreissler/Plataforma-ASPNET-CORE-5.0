using Microsoft.AspNetCore.Mvc;
using Plataforma.Data;
using Plataforma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plataforma.ViewModels;


namespace Plataforma.Controllers
{
    public class ContratosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContratosController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index(int id)
        {
            var empresas = (from a in _context.Empresa
                         where a.Id.Equals(id)
                         select a).FirstOrDefault();


           
          /*  var autonomo = (from a in _context.Trabajadores
                            where a.Trabajadortipo.Equals("Autonomo") where a.IdEmpresa.Equals(empresas.Id)
                            select a).FirstOrDefault();*/
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
                ano = empresas.ano,
                Idcurso = empresas.Idcurso

            };
            
            ContratoEncomiendaViewModel contratoencomienda = new ContratoEncomiendaViewModel()
            {
                Empresas = empresa/*,
                Autonomo = new ContratoEncomiendaViewModel.autonomo()
                {
                    TrabajadorNome = autonomo.TrabajadorNome,
                    TrabajadorNif = autonomo.TrabajadorNif
                }*/

            };
            return View(contratoencomienda);
        }
        public IActionResult Adhesion(int id)
        {
            var empresa = (from a in _context.Empresa
                            where a.Id.Equals(id)
                            select a).FirstOrDefault();
            return View(empresa);
        }
        public IActionResult SolicitudCurso(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();
            var trabajadores = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.Trabajadortipo != "Autonomo" && a.AnoTrabajador.Equals(empresa.ano)
                                select a).ToList();
            var curso = (from a in _context.EmpresaCurso
                         where a.IdEmpresa.Equals(id)
                         orderby a.Id
                         select a).LastOrDefault();
            SolicitudCursoViewModel viewmodel = new SolicitudCursoViewModel()
            {
                Empresa = empresa,
                Trabajadores = trabajadores,
                Curso = curso,
            };
            return View(viewmodel);
        }
        public IActionResult SolicitudAutonomo(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();
            var trabajadores = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.Trabajadortipo == "Autonomo" && a.AnoTrabajador.Equals(empresa.ano)
                                select a).ToList();
            var curso = (from a in _context.EmpresaCurso
                         where a.IdEmpresa.Equals(id)
                         orderby a.Id
                         select a).LastOrDefault();
            SolicitudCursoViewModel viewmodel = new SolicitudCursoViewModel()
            {
                Empresa = empresa,
                Trabajadores = trabajadores,
                Curso = curso,
            };
            return View(viewmodel);
        }
        public IActionResult Factura(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();
           
            var curso = (from a in _context.EmpresaCurso
                         where a.IdEmpresa.Equals(id)
                         orderby a.Id
                         select a).LastOrDefault();
            FacturaViewModel viewmodel = new FacturaViewModel()
            {
                empresa = empresa,
                cursos = curso,
            };
            return View(viewmodel);
        }
        public IActionResult Boni(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();

          
            return View(empresa);
        }
    }


}
