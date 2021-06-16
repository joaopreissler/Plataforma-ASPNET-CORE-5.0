using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.Models
{
    public class Empresa
    {   
        [Key]
        public int Id { get; set; }
   
        public string Nombre_Empresa { get; set; }
      
        public string Nombre_Comercial { get; set; }
        public int seguridad_social { get; set; }
      
        public string Nif { get; set; }
      
        public string Direccion { get; set; }
        
        public string Cp { get; set; }
       
        public string Provincia { get; set; }
     
        public string Localidad { get; set; }
     
        public string DireccionComercial { get; set; }
 
        public int CPComercial { get; set; }
     
        public string ProvinciaComercial { get; set; }
     
        public string LocalidadComercial { get; set; }
      
        public string Telefono { get; set; }
     
        public string email { get; set; }
      
        public string CuentaCotizacion { get; set; }
       
        public string sector { get; set; }
    
        public string convenio { get; set; }
       
        public string actividadprincial { get; set; }
       
        public string CNAE { get; set; }
        
        public Boolean Representacionlegal { get; set; }
       
        public Boolean nuevacreacion { get; set; }
      
        public int creditodisponible {get; set;}
  

        public string Banco { get; set; }
     
        public string Cuenta { get; set; }
       
        public DateTime creacion { get; set; }
       
        public Boolean venta { get; set; }
        
        public string Nombrereprensentante { get; set; }
       
        public Boolean Generorepresentante { get; set; }
        
        public string nifrepresentante { get; set; }
        
        public DateTime Fechafirma { get; set; }
        

        public string nombregestoria { get; set; }
       
        public string contatogestoria { get; set; }
        
        public string emailgestoria { get; set; }
        
        public string telefonogestoria { get; set; }
       [Required]
        public int ano { get; set; }
       [Required]
        public int Idcurso { get; set; }
        public string IdMember { get; set; }
        
    }
}
