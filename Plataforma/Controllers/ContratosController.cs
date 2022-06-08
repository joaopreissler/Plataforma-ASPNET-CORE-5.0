using Microsoft.AspNetCore.Mvc;
using Plataforma.Data;
using Plataforma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plataforma.ViewModels;
using Microsoft.EntityFrameworkCore;


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

            EmpresaCurso curso = _context.EmpresaCurso.Where(x => x.IdEmpresa == id).FirstOrDefault();
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
                    Empresas = empresa,
                    curso = curso
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
        public IActionResult evaluacionfinal(int id)
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
                                where a.IdEmpresa.Equals(id) && a.Trabajadortipo == "Trabajador" && a.AnoTrabajador.Equals(empresa.ano)
                                && a.TrabajadorAlta.Equals(true)
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
            var trabajadores = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.Trabajadortipo == "Trabajador" && a.AnoTrabajador.Equals(empresa.ano)
                                && a.TrabajadorAlta == true && a.Fundae == true
                                select a).ToList();
            var query = _context.Empresa.Where(x => x.Idcurso == empresa.Idcurso).Where(y => y.ano == empresa.ano).OrderBy(id => id).ToList();
            int index = query.FindIndex(c => c.Nif == empresa.Nif)+1;
            FacturaViewModel viewmodel = new FacturaViewModel()
            {
                empresa = empresa,
                cursos = curso,
                trabajadores = trabajadores,
                numero = index
            };
            return View(viewmodel);
        }

        public IActionResult FacturaccEuro(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();

            var curso = (from a in _context.EmpresaCurso
                         where a.IdEmpresa.Equals(id)
                         orderby a.Id
                         select a).LastOrDefault();
            var trabajadores = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.Trabajadortipo == "Trabajador" && a.AnoTrabajador.Equals(empresa.ano)
                                && a.TrabajadorAlta == true && a.Fundae == true
                                select a).ToList();
            var query = _context.Empresa.Where(x => x.Idcurso == empresa.Idcurso).Where(y => y.ano == empresa.ano).OrderBy(id => id).ToList();
            int index = query.FindIndex(c => c.Nif == empresa.Nif) + 1;
            FacturaViewModel viewmodel = new FacturaViewModel()
            {
                empresa = empresa,
                cursos = curso,
                trabajadores = trabajadores,
                numero = index
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
        public IActionResult Caratulas(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();
            var trabajadores = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.TrabajadorAlta == true && a.AnoTrabajador.Equals(empresa.ano)
                                select a).ToList();
            var curso = (from a in _context.EmpresaCurso
                         where a.IdEmpresa.Equals(id)
                         orderby a.Id
                         select a).LastOrDefault();
            SolicitudCursoViewModel datos = new SolicitudCursoViewModel()
            {
                Empresa = empresa,
                Curso = curso,
                Trabajadores = trabajadores
            };

            return View(datos);
        }
        public IActionResult TestAlergenos(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();
            var trabajadores = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.TrabajadorAlta == true && a.AnoTrabajador.Equals(empresa.ano)
                                select a).ToList();
            var curso = (from a in _context.EmpresaCurso
                         where a.IdEmpresa.Equals(id)
                         orderby a.Id
                         select a).LastOrDefault();
            SolicitudCursoViewModel datos = new SolicitudCursoViewModel()
            {
                Empresa = empresa,
                Curso = curso,
                Trabajadores = trabajadores
            };

            return View(datos);
        }
        public IActionResult TestManipulador(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();
            var trabajadores = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.TrabajadorAlta == true && a.AnoTrabajador.Equals(empresa.ano)
                                select a).ToList();
            var curso = (from a in _context.EmpresaCurso
                         where a.IdEmpresa.Equals(id)
                         orderby a.Id
                         select a).LastOrDefault();
            SolicitudCursoViewModel datos = new SolicitudCursoViewModel()
            {
                Empresa = empresa,
                Curso = curso,
                Trabajadores = trabajadores
            };

            return View(datos);
        }
        public IActionResult TestPrevencion(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();
            var trabajadores = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.TrabajadorAlta == true && a.AnoTrabajador.Equals(empresa.ano)
                                select a).ToList();
            var curso = (from a in _context.EmpresaCurso
                         where a.IdEmpresa.Equals(id)
                         orderby a.Id
                         select a).LastOrDefault();
            SolicitudCursoViewModel datos = new SolicitudCursoViewModel()
            {
                Empresa = empresa,
                Curso = curso,
                Trabajadores = trabajadores
            };

            return View(datos);
        }
        public IActionResult TestPeluqueria(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();
            var trabajadores = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.TrabajadorAlta == true && a.AnoTrabajador.Equals(empresa.ano)
                                select a).ToList();
            var curso = (from a in _context.EmpresaCurso
                         where a.IdEmpresa.Equals(id)
                         orderby a.Id
                         select a).LastOrDefault();
            SolicitudCursoViewModel datos = new SolicitudCursoViewModel()
            {
                Empresa = empresa,
                Curso = curso,
                Trabajadores = trabajadores
            };

            return View(datos);
        }
        public IActionResult CertificadoCat(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();
            var trabajadores = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.TrabajadorAlta == true && a.AnoTrabajador.Equals(empresa.ano)
                                select a).ToList();
            var curso = (from a in _context.EmpresaCurso
                         where a.IdEmpresa.Equals(id)
                         orderby a.Id
                         select a).LastOrDefault();
            SolicitudCursoViewModel datos = new SolicitudCursoViewModel()
            {
                Empresa = empresa,
                Curso = curso,
                Trabajadores = trabajadores
            };

            return View(datos);
        }
        public IActionResult CertificadoCas(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();
            var trabajadores = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.TrabajadorAlta == true && a.AnoTrabajador.Equals(empresa.ano)
                                select a).ToList();
            var curso = (from a in _context.EmpresaCurso
                         where a.IdEmpresa.Equals(id)
                         orderby a.Id
                         select a).LastOrDefault();
            SolicitudCursoViewModel datos = new SolicitudCursoViewModel()
            {
                Empresa = empresa,
                Curso = curso,
                Trabajadores = trabajadores
            };

            return View(datos);
        }
        public IActionResult lopd(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();
            var trabajadores = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.TrabajadorAlta == true && a.AnoTrabajador.Equals(empresa.ano)
                                select a).ToList();
            var autonomo = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.Trabajadortipo == "Autonomo" && a.AnoTrabajador.Equals(empresa.ano)
                                select a).FirstOrDefault();

            ContratoEncomiendaViewModel datos = new ContratoEncomiendaViewModel()
            {
                Empresas = empresa,
                Autonomo = new ContratoEncomiendaViewModel.autonomo()
                {
                    TrabajadorNome = autonomo.TrabajadorNome,
                    TrabajadorNif = autonomo.TrabajadorNif
                },

                trabajadores = trabajadores
            };

            return View(datos);
        }
        public IActionResult Renovacion(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();
            var trabajadores = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.TrabajadorAlta == true && a.AnoTrabajador.Equals(empresa.ano) && a.Trabajadortipo.Equals("Trabajador")
                                select a).ToList();
            var autonomo = (from a in _context.Trabajadores
                            where a.IdEmpresa.Equals(id) && a.Trabajadortipo == "Autonomo" && a.AnoTrabajador.Equals(empresa.ano)
                            select a).FirstOrDefault();
            var curso = (from a in _context.EmpresaCurso
                         where a.IdEmpresa.Equals(id)
                         orderby a.Id
                         select a).LastOrDefault();
            ContratoEncomiendaViewModel datos = new ContratoEncomiendaViewModel()
            {
                Empresas = empresa,
                Autonomo = new ContratoEncomiendaViewModel.autonomo()
                {
                    TrabajadorNome = autonomo.TrabajadorNome,
                    TrabajadorNif = autonomo.TrabajadorNif
                },

                trabajadores = trabajadores,
                curso = curso
            };

            return View(datos);
        }
        public IActionResult TodosContratos(int id)
        {
            var empresa = (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefault();
            var trabajadores = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.Trabajadortipo == "Trabajador" && a.TrabajadorAlta == true && a.AnoTrabajador.Equals(empresa.ano)
                                select a).ToList();
            var trabajadoresfundae = (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.Trabajadortipo == "Trabajador" && a.TrabajadorAlta == true && a.AnoTrabajador.Equals(empresa.ano) && a.Fundae == true
                                select a).ToList();
            var curso = (from a in _context.EmpresaCurso
                         where a.IdEmpresa.Equals(id)
                         orderby a.Id
                         select a).LastOrDefault();

            SolicitudCursoViewModel datos = new SolicitudCursoViewModel()
            {
                Empresa = empresa,
                Curso = curso,
                Fundae = trabajadoresfundae,
                Trabajadores = trabajadores
            };

            return View(datos);
        }
         public async Task<ActionResult<SolicitudCursoViewModel>> prl(int id)
        {
            var empresa = await (from a in _context.Empresa
                           where a.Id.Equals(id)
                           select a).FirstOrDefaultAsync();
            
            var trabajadores = await (from a in _context.Trabajadores
                                where a.IdEmpresa.Equals(id) && a.TrabajadorAlta == true && a.AnoTrabajador.Equals(empresa.ano) && a.Trabajadortipo == "Trabajador"
                                      select a).ToListAsync();
            var curso = await (from a in _context.EmpresaCurso
                         where a.IdEmpresa.Equals(id)
                         orderby a.Id
                         select a).LastOrDefaultAsync();

            SolicitudCursoViewModel datos = new SolicitudCursoViewModel()
            {
                Empresa =  empresa,
                Curso =  curso,
                Trabajadores =  trabajadores
            };

            return  View(datos);
        }
        public async Task<ActionResult<SolicitudCursoViewModel>> certificadoform(int id)
        {
            var empresa = await _context.Empresa.Where(x => x.Id == id).FirstOrDefaultAsync();
            var curso = await _context.EmpresaCurso.Where(x => x.IdEmpresa == id).OrderBy(s => s.Id).LastOrDefaultAsync();

            FacturaViewModel resultado = new FacturaViewModel()
            {
                empresa = empresa,
                cursos = curso
            };
            return View(resultado);
        }
        public async Task<ActionResult<ContratoAutonomoViewModel>> contratoAutonomo(int id)
        {
            var autonomo = await _context.Trabajadores.Where(x => x.Id == id).FirstOrDefaultAsync();
            var empresa = await _context.Empresa.Where(x => x.Id == autonomo.IdEmpresa).FirstOrDefaultAsync();
            var curso = await _context.EmpresaCurso.Where(x => x.IdEmpresa == empresa.Id).OrderBy(s => s.Id).LastOrDefaultAsync();

            
            ContratoAutonomoViewModel resultado = new ContratoAutonomoViewModel()
            {
                Autonomo = autonomo,
                Empresas = empresa,
                CursoNome = curso

            };
            return View(resultado);
        }
    }
   

    }
