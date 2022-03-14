using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plataforma.Models;
namespace Plataforma.ViewModels
{
    public class SolicitudCursoViewModel
    {
        public Empresa Empresa;
        public IEnumerable<Trabajadores> Trabajadores;
        public IEnumerable<Trabajadores> Fundae;
        public EmpresaCurso Curso;
    }
}
