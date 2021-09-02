
using Microsoft.Extensions.Logging;
using Plataforma.Data;
using Plataforma.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Plataforma.Controllers
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                   
                    var empresasdata = 
                        File.ReadAllText("C:/Users/João Victor/Desktop/Plataforma/Plataforma/Plataforma/Data/data.json");
                
                    var empresas = JsonSerializer.Deserialize<List<EmpresaData>>(empresasdata);
                    foreach (var item in empresas)
                    {
                    var mes = 00;
                    switch (item.mes)
                    {
                        case "G":
                            mes = 01;
                            break;
                        case "F":
                            mes = 02;
                            break;
                        case "M":
                            mes = 03;
                            break;
                        case "AB":
                            mes = 04;
                            break;
                        case "MG":
                            mes = 05;
                            break;
                        case "JN":
                            mes = 06;
                            break;
                        case "JL":
                            mes = 07;
                            break;
                        case "AG":
                            mes = 08;
                            break;
                        case "S":
                            mes = 09;
                            break;
                        case "O":
                            mes = 10;
                            break;
                        case "N":
                            mes = 11;
                            break;
                        case "D":
                            mes = 12;
                            break;

                    }
                   var novaempresa = new Empresa
                    {
                        Nombre_Empresa = item.empresa,
                        Nombre_Comercial = item.nombre_comercial,
                        seguridad_social = item.ss,
                        Nif = item.nif,
                        Direccion = item.direccion,
                        Cp = item.cp.ToString(),
                        Provincia = item.provincia,
                        Localidad = item.localidad,
                        DireccionComercial = item.direccionCom,
                        CPComercial = item.cpCom,
                        ProvinciaComercial = item.provinciaCom,
                        LocalidadComercial = item.localidadCom,
                        Telefono = item.telefono,
                        email = item.email,
                        CuentaCotizacion = item.cc,
                        sector = item.sector,
                        convenio = item.convenio.ToString(),
                        actividadprincial = item.actividad,
                        CNAE = item.cnae.ToString(),
                        Representacionlegal = true,
                        nuevacreacion = false,
                        creditodisponible = 00,
                        Banco = " ",
                        Cuenta = " ",
                        creacion = DateTime.UtcNow,
                        venta = true,
                        Nombrereprensentante = item.nombre_representante,
                        Generorepresentante = true,
                        nifrepresentante = item.nif_representante,
                        Fechafirma = DateTime.UtcNow,
                        nombregestoria = item.nombre_gestor,
                        contatogestoria = item.gestoria,
                        emailgestoria = item.email,
                        telefonogestoria = item.telefono_gestor.ToString(),
                        ano = 2020,
                        Idcurso = mes
                        
                       };
                    context.Empresa.Add(novaempresa);
                }
                    await context.SaveChangesAsync();
                
                
               
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
            }

        }
    }
}
