using Plataforma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.ViewModels
{
    public class ContratoAutonomoViewModel
    {
        public class autonomo
        {

            public string TrabajadorNome { get; set; }
            public string TrabajadorNif { get; set; }


        }
        public Trabajadores Autonomo;
        public Empresa Empresas;
        public EmpresaCurso CursoNome;
    }
}
