using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.Models
{
    public class EmpresaCurso
    {
        public int Id {get; set;}
        public string CursoNome { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }
    }
}
