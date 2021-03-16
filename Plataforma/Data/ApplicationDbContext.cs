using Microsoft.EntityFrameworkCore;
using Plataforma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plataforma.ViewModels;

namespace Plataforma.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<EmpresaCurso> EmpresaCurso { get; set; }
        public DbSet<Plataforma.ViewModels.EmpresasEditViewModel> EmpresasCurso { get; set; }
    }
}
