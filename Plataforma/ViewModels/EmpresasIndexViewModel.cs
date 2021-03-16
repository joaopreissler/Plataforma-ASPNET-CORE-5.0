using Plataforma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.ViewModels
{
    public class teste {
        public string Nombre_Empresa;
        public string Nombre_Comercial;
        public string Nif;
        public DateTime Final;
        public int Id;

}
    public class anos
    {
        public int ano;
    }
    public class EmpresasIndexViewModel
    {
        public IEnumerable<teste> Enero;
        public IEnumerable<teste> Febrero;
        public IEnumerable<teste> Marzo;
        public IEnumerable<teste> Abril;
        public IEnumerable<teste> Mayo;
        public IEnumerable<teste> Junio;
        public IEnumerable<teste> Julio;
        public IEnumerable<teste> Agosto;
        public IEnumerable<teste> Setembro;
        public IEnumerable<teste> Outubro;
        public IEnumerable<teste> Novembro;
        public IEnumerable<teste> Dezembro;
        public IEnumerable<anos> anos;
    }
}
