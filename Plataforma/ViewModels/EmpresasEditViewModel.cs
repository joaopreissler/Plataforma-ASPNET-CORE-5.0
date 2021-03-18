using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plataforma.Models;
namespace Plataforma.ViewModels
{
    public class EmpresasEditViewModel
    {
        public int Id { get; set; }

        public IEnumerable<Empresa> Empresas;
        public IEnumerable<Cursos> Curso;
        public IEnumerable<EmpresaCurso> CursosNome;
        public IEnumerable<Trabajadores> Trabajadores;
        public IEnumerable<Trabajadores> TrabajadoresBaja;
        public Cursos NewCurso;
        public EmpresaCurso Inicio;
        public EmpresaCurso Final;
        public EmpresaCurso IdEmpresa;
        public EmpresaCurso CursoNome;
    }
}
