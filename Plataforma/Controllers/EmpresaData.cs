using System;

namespace Plataforma.Controllers
{
    public class EmpresaData
    {
        public string empresa { get; set; }
        public string nombre_comercial { get; set; }
        public object ss { get; set; }
        public object nif { get; set; }
        public string direccion { get; set; }
        public int cp { get; set; }
        public string provincia { get; set; }
        public string localidad { get; set; }
        public string direccionCom { get; set; }
        public int cpCom { get; set; }
        public string provinciaCom { get; set; }
        public string localidadCom { get; set; }
        public object telefono { get; set; }
        public object email { get; set; }
        public string cc { get; set; }
        public string sector { get; set; }
        public int convenio { get; set; }
        public string actividad { get; set; }
        public object cnae { get; set; }
        public string legal { get; set; }
        public object fecha_creacion { get; set; }

        public string nombre_representante { get; set; }
        public string genero_representante { get; set; }
        public object nif_representante { get; set; }
        public string fecha_firma { get; set; }
        public string nombre_gestor { get; set; }
        public string gestoria { get; set; }
        public object telefono_gestor { get; set; }
       
        public string mes { get; set; }

    }
    public class number
    {
        public int id { get; set; }
        public int numero { get; set; }
    }
}