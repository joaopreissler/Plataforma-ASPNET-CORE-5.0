using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.ViewModels
{
    public class EmpresaanoViewModel
    {
        public int EmpresaId { get; set; }
        [Required]
        [Range(1990, 2100, ErrorMessage = "Es necessário poner 4 números para el Año como por exemplo: 2021")]
        public int Ano { get; set; }
        [Required]
        public int mes { get; set; }
    }
}
