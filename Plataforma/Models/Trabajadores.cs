using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.Models
{
    public class Trabajadores
    {[Key]
        public int Id { get; set; }
        public string TrabajadorNome { get; set; }
        public string TrabajadorNif { get; set; }
        public int IdEmpresa { get; set; }
        public Boolean Fundae { get; set; }
        public string SeguridadSocial { get; set; }
        public DateTime FechaTrabajador { get; set; }
        public string Trabajadortipo { get; set; }
        public Boolean TrabajadorAlta { get; set; }
        public int AnoTrabajador { get; set; }
        public int Mestrabajador { get; set; }

    }
}
