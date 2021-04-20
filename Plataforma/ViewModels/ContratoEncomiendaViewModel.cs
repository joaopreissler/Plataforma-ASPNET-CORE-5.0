using Plataforma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.ViewModels
{

    public class ContratoEncomiendaViewModel
    {
        public class autonomo
        {
           
            public string TrabajadorNome { get; set; }
            public string TrabajadorNif { get; set; }
            
          
                   }
        public Empresa Empresas;
        public autonomo Autonomo;

        public IEnumerable<Trabajadores> trabajadores;

    }
}
