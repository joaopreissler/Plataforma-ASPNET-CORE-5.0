using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        [Required]
        public string Nombre_Empresa { get; set; }
        [Required]
        public string Nombre_Comercial { get; set; }
        [Required]
        public string Nif { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public int Cp { get; set; }
        [Required]
        public string Provincia { get; set; }
        [Required]
        public string Localidad { get; set; }
        [Required]
        public string DireccionComercial { get; set; }
        [Required]
        public int CPComercial { get; set; }
        [Required]
        public string ProvinciaComercial { get; set; }
        [Required]
        public string LocalidadComercial { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string CuentaCotizacion { get; set; }
        [Required]
        public string sector { get; set; }
        [Required]
        public string convenio { get; set; }
        [Required]
        public string actividadprincial { get; set; }
        [Required]
        public string CNAE { get; set; }
        [Required]
        public Boolean Representacionlegal { get; set; }
        [Required]
        public Boolean nuevacreacion { get; set; }
        [Required]
        public int creditodisponible {get; set;}
        [Required]

        public string Banco { get; set; }
        [Required]
        public string Cuenta { get; set; }
        [Required]
        public DateTime creacion { get; set; }
        [Required]
        public Boolean venta { get; set; }
        [Required]
        public string Nombrereprensentante { get; set; }
        [Required]
        public Boolean Generorepresentante { get; set; }
        [Required]
        public string nifrepresentante { get; set; }
        [Required]
        public DateTime Fechafirma { get; set; }
        [Required]

        public string nombregestoria { get; set; }
        [Required]

        public string contatogestoria { get; set; }
        [Required]
        public string emailgestoria { get; set; }
        [Required]
        public string telefonogestoria { get; set; }
        [Required]

        public int ano { get; set; }
        [Required]
        public int Idcurso { get; set; }
        
    }
}
