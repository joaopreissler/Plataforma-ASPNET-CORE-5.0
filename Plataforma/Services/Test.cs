using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plataforma.Data;
using Plataforma.Interface;
using Plataforma.Models;
using Plataforma.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.Services
{
    public class Test : Itest
    {

        private readonly ApplicationDbContext _context;

        public Test(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<EmpresasIndexViewModel> GetCustomersAsync(int anos)
        {

            
            if (anos == 0)
            {
                DateTime mydate = DateTime.Now;
                anos = mydate.Year;

            }
            var queryanos = await (from c in _context.Empresa select new Anos { ano = c.ano }).Distinct().ToListAsync();

            var queryEnero =  await(from c in _context.Empresa
                              let variable = _context.EmpresaCurso.Where(y => y.IdEmpresa == c.Id).Select(x => x.Final).OrderByDescending(b => b).FirstOrDefault()
                              where c.Idcurso.Equals(1)
                              where c.ano.Equals(anos)
                              select new teste
                              {
                                  Nombre_Empresa = c.Nombre_Empresa,
                                  Nombre_Comercial = c.Nombre_Comercial,
                                  Nif = c.Nif,
                                  Final = variable,
                                  Id = c.Id,
                                  venta = c.venta
                              }).ToListAsync();
            var queryFebrero = await (from c in _context.Empresa
                                let variable = _context.EmpresaCurso.Where(y => y.IdEmpresa == c.Id).Select(x => x.Final).OrderByDescending(b => b).FirstOrDefault()
                                where c.Idcurso.Equals(2)
                                where c.ano.Equals(anos)
                                select new teste
                                {
                                    Nombre_Empresa = c.Nombre_Empresa,
                                    Nombre_Comercial = c.Nombre_Comercial,
                                    Nif = c.Nif,
                                    Final = variable,
                                    Id = c.Id,
                                    venta = c.venta
                                }).ToListAsync();

            /*
             * select Nombre_Empresa,Nombre_Comercial,Nif,Final from Plataforma.dbo.Empresa as B
             outer apply 
             (SELECT TOP 1 * FROM Plataforma.dbo.EmpresaCurso A 
             where A.IdEmpresa = B.Id ORDER BY A.Final DESC) as A
             */




           var empresas = new EmpresasIndexViewModel()
            {
                anos = queryanos,
                Enero = queryEnero,
                Febrero = queryFebrero,
                anoatual = anos
            };

            return  empresas;
           
        }
    }
}
