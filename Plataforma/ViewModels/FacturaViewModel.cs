using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plataforma.Models;
namespace Plataforma.ViewModels
{
    public class FacturaViewModel
    {
        public EmpresaCurso cursos;
        public Empresa empresa;
        public IEnumerable<Trabajadores> trabajadores;
        public int numero;
    }
}
