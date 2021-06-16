using Plataforma.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.ViewModels
{
    
    public class MembersCreateViewModel
    {
        [Key]
        public int id { get; set; }
        public Empresa Empresas;
        public IEnumerable<Trabajadores> trabajador;
    }
}
