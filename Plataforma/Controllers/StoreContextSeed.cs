﻿
using Microsoft.Extensions.Logging;
using Plataforma.Data;
using Plataforma.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
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
            
             try {
                /*
                         var empresasdata = File.ReadAllText("C:/Users/joaov/Desktop/Projects/GitHub/Plataforma-ASPNET-CORE-5.0/Plataforma/Data/empresas2020.json");

               var empresas = JsonSerializer.Deserialize<List<EmpresaData>>(empresasdata);
             List<string> control = new List<string>();
             foreach (var item in empresas)
               {
               var mes = 00;



                 var result = control.Find(x => x.Contains(item.nif.ToString()));

                 if (result == null)
                 {
                     control.Add(item.nif.ToString());
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
                         seguridad_social = item.ss.ToString(),
                         Nif = item.nif.ToString(),
                         Direccion = item.direccion,
                         Cp = item.cp.ToString(),
                         Provincia = item.provincia,
                         Localidad = item.localidad,
                         DireccionComercial = item.direccionCom,
                         CPComercial = item.cpCom,
                         ProvinciaComercial = item.provinciaCom,
                         LocalidadComercial = item.localidadCom,
                         Telefono = item.telefono.ToString(),
                         email = item.email.ToString(),
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
                         nifrepresentante = item.nif_representante.ToString(),
                         Fechafirma = DateTime.UtcNow,
                         nombregestoria = item.nombre_gestor,
                         contatogestoria = item.gestoria,
                         emailgestoria = item.email.ToString(),
                         telefonogestoria = item.telefono_gestor.ToString(),
                         ano = 2021,
                         Idcurso = mes

                     };
                     context.Empresa.Add(novaempresa);
                 }

           }
                
                var trabajadoresdata =
                       File.ReadAllText("C:/Users/joaov/Desktop/Projects/GitHub/Plataforma-ASPNET-CORE-5.0/Plataforma/Data/alumnos2021.json");

                var trabajadores = JsonSerializer.Deserialize<List<TrabajadoresData>>(trabajadoresdata);

               foreach (var item in trabajadores)
               {

                       var empresa = context.Empresa.Where(x => x.Nif == item.nifempresa.ToString() && x.ano == 2020).FirstOrDefault();
                       var fundae = false;
                       var baja = false;
                       var trabajador = "Trabajador";
                       var nif = item.nif.ToString();
                       var ss = item.ss.ToString();

                       if (item.fundae != null)
                       {
                           fundae = true;
                       }
                       if (item.baja == "no")
                       {
                           baja = true;
                       }
                       string Nacimiento = item.nacimiento.ToString();
                       DateTime Date;

                       if (DateTime.TryParseExact(Nacimiento, "dd-MM-yyyy", CultureInfo.InvariantCulture, 0, out Date))
                       {
                           Date = DateTime.ParseExact(item.nacimiento.ToString(), "dd-MM-yyyy", null);
                       }
                       else
                       {
                           Date = DateTime.Now;
                       }
                       if (item.tipo != "trabajador")
                       {
                           trabajador = "Autonomo";
                       }
                       else
                       {
                           trabajador = "Trabajador";
                       }
                       if (empresa != null)
                       {
                           var novotrabajador = new Trabajadores
                           {
                               TrabajadorNome = item.nombre,
                               TrabajadorNif = nif,
                               IdEmpresa = empresa.Id,
                               Fundae = fundae,
                               SeguridadSocial = ss,
                               TrabajadorAlta = baja,
                               FechaTrabajador = Date,
                               Trabajadortipo = trabajador,
                               AnoTrabajador = 2020,
                               Mestrabajador = empresa.Idcurso


                           };
                           context.Trabajadores.Add(novotrabajador);
                        await context.SaveChangesAsync();
                    }

               }
               
                var duplicados = context.Trabajadores.Where( x => x.AnoTrabajador == 2020 ).ToList();
            foreach (var items in duplicados)
            {
                var duplicado = context.Trabajadores.Where(x => x.TrabajadorNif == items.TrabajadorNif && x.AnoTrabajador == 2020).ToList();
                var control = duplicado.Count;
                while (control > 1)
                {

                        var dept = context.Trabajadores.Where(x => x.TrabajadorNif == items.TrabajadorNif && x.AnoTrabajador == 2020).FirstOrDefault();
                        context.Trabajadores.Remove(dept);
                        await context.SaveChangesAsync();
                        control = control - 1;

                }
            }
          
            */




            }
            catch (Exception ex)
         {
             var logger = loggerFactory.CreateLogger<StoreContextSeed>();
             logger.LogError(ex.Message);
         }

  
        }

    }
}