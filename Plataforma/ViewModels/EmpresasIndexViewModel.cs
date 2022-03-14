using Plataforma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.ViewModels
{
    
    public class Anos
    {
        public int ano;
    }

    public class EmpresasIndexViewModel
    {
        public IEnumerable<Empresa> Enero;
        public IEnumerable<Empresa> Febrero;
        public IEnumerable<Empresa> Marzo;
        public IEnumerable<Empresa> Abril;
        public IEnumerable<Empresa> Mayo;
        public IEnumerable<Empresa> Junio;
        public IEnumerable<Empresa> Julio;
        public IEnumerable<Empresa> Agosto;
        public IEnumerable<Empresa> Setembro;
        public IEnumerable<Empresa> Outubro;
        public IEnumerable<Empresa> Novembro;
        public IEnumerable<Empresa> Dezembro;
        public IEnumerable<Anos> anos;
        public int anoatual;
        
        
    }
}
