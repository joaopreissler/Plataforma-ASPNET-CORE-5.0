#pragma checksum "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee422a99470ac56be7806b52678ff02d191ea1d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contratos_lopd), @"mvc.1.0.view", @"/Views/Contratos/lopd.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\_ViewImports.cshtml"
using Plataforma;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\_ViewImports.cshtml"
using Plataforma.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee422a99470ac56be7806b52678ff02d191ea1d5", @"/Views/Contratos/lopd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"419e03b9f5afb17e76ff6540606c73c87f585a34", @"/Views/_ViewImports.cshtml")]
    public class Views_Contratos_lopd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plataforma.ViewModels.ContratoEncomiendaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("save_lopd.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
   
.contenedor{
	position: relative;
	display: inline-block;
	text-align: center;
}

.texto-encima{
	position: absolute;
	top: 10px;
	left: 10px;
}
.responsable{
	position: fixed;
	text-align:left;
	top: 56%;
	left: 24%;
	transform: translate(-50%, -50%);
	font-family: Calibri;
	font-size: 21pt;
}
.derechos{
	position: fixed;
	text-align:left;
	top: 72%;
	left: 24%;
	transform: translate(-50%, -50%);
	font-family:Calibri;
	font-size:21pt;
}
.infor{
	position: absolute;
	text-align:left;
	top: 88%;
	left: 10%;
	transform: translate(-50%, -50%);
	font-family:Calibri;
	font-size:21pt;
}
/* CSS Document */

</style>    
<div class=""row justify-content-md-center white shadow"">
		<div class=""col"">
			");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee422a99470ac56be7806b52678ff02d191ea1d54660", async() => {
                WriteLiteral("\n\n\t\t\t\t\n\t\t\t\t<br><h3>");
#nullable restore
#line 50 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
                   Write(Model.Empresas.Nombre_Comercial);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>     <br><br>
				<div class=""pregunta"">
					<h3><strong><u> Datos de la empresa </u></strong></h3><h3>
					</h3>
				</div>

				<br><br>
				<div class=""pregunta"">

					<h6> CIF Empresa: </h6>
					<input class=""form-control"" type=""text"" name=""2""");
                BeginWriteAttribute("value", " value=\"", 1121, "\"", 1148, 1);
#nullable restore
#line 60 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
WriteAttributeValue("", 1129, Model.Empresas.Nif, 1129, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\t\t\t\t\t<h6> Dirección Empresa: </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"3\"");
                BeginWriteAttribute("value", " value=\"", 1292, "\"", 1325, 1);
#nullable restore
#line 67 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
WriteAttributeValue("", 1300, Model.Empresas.Direccion, 1300, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\t\t\t\t\t<h6> CP Empresa: </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"4\"");
                BeginWriteAttribute("value", " value=\"", 1461, "\"", 1487, 1);
#nullable restore
#line 73 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
WriteAttributeValue("", 1469, Model.Empresas.Cp, 1469, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Locales o sedes sociales (dirección): </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"5\"");
                BeginWriteAttribute("value", " value=\"", 1650, "\"", 1658, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\t\t\t\t\t<h6> Teléfono de contacto: </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"6\"");
                BeginWriteAttribute("value", " value=\"", 1804, "\"", 1836, 1);
#nullable restore
#line 86 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
WriteAttributeValue("", 1812, Model.Empresas.Telefono, 1812, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\t\t\t\t\t<h6> Correo Electrónico: </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"7\"");
                BeginWriteAttribute("value", " value=\"", 1980, "\"", 2010, 1);
#nullable restore
#line 92 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
WriteAttributeValue(" ", 1988, Model.Empresas.email, 1989, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
				</div>

				<br><br>
				<div class=""pregunta"">
					<h3><strong><u> Datos del representante </u></strong></h3><h3>
					</h3>
				</div>

				<br><br>
				<div class=""pregunta"">
					<h6> Nombre y apellidos del administrador o apoderado de la empresa: </h6>
					<input class=""form-control"" type=""text"" name=""9""");
                BeginWriteAttribute("value", " value=\"", 2329, "\"", 2372, 1);
#nullable restore
#line 104 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
WriteAttributeValue("", 2337, Model.Empresas.Representacionlegal, 2337, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\t\t\t\t\t<h6> DNI del apoderado: </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"10\"");
                BeginWriteAttribute("value", " value=\"", 2516, "\"", 2556, 1);
#nullable restore
#line 110 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
WriteAttributeValue("", 2524, Model.Empresas.nifrepresentante, 2524, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Correo Electrónico: </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"11\"");
                BeginWriteAttribute("value", " value=\"", 2702, "\"", 2739, 1);
#nullable restore
#line 117 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
WriteAttributeValue("", 2710, Model.Empresas.emailgestoria, 2710, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
				</div>

				<br><br>
				<div class=""pregunta"">
					<h3><strong><u> Datos de la Persona Responsable RGPD </u></strong></h3><h3>
					</h3>
				</div>

				<br><br>
				<div class=""pregunta"">
					<h6> Nombre y apellidos: </h6>
					<input class=""form-control"" type=""text"" name=""13""");
                BeginWriteAttribute("value", " value=\"", 3028, "\"", 3066, 1);
#nullable restore
#line 129 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
WriteAttributeValue("", 3036, Model.Autonomo.TrabajadorNome, 3036, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\t\t\t\t\t<h6> DNI del apoderado: </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"14\"");
                BeginWriteAttribute("value", " value=\"", 3210, "\"", 3247, 1);
#nullable restore
#line 135 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
WriteAttributeValue("", 3218, Model.Autonomo.TrabajadorNif, 3218, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Correo Electrónico: </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"15\"");
                BeginWriteAttribute("value", " value=\"", 3394, "\"", 3402, 0);
                EndWriteAttribute();
                WriteLiteral(@">
				</div>

				<br><br>
				<div class=""pregunta"">
					<h3><strong><u> Presencia Online </u></strong></h3><h3>
					</h3>
				</div>

				<br><br>
				<div class=""pregunta"">

					<h6> URL de la WEB: </h6>
					<input class=""form-control"" type=""text"" name=""17""");
                BeginWriteAttribute("value", " value=\"", 3667, "\"", 3675, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> RRSS (Qué redes sociales tienes? Ex. Instagram, Facebook, Linkedin, Twitter...): </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"18\"");
                BeginWriteAttribute("value", " value=\"", 3882, "\"", 3890, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Número de WhatsApp (Sólo si es uso profesional): </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"19\"");
                BeginWriteAttribute("value", " value=\"", 4065, "\"", 4073, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Tiene e-commerce? (Tienda online). Escriba la URL: </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"20\"");
                BeginWriteAttribute("value", " value=\"", 4251, "\"", 4259, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Tiene APP? (Nombre de la app): </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"21\"");
                BeginWriteAttribute("value", " value=\"", 4417, "\"", 4425, 0);
                EndWriteAttribute();
                WriteLiteral(@">
				</div>

				<br><br>
				<div class=""pregunta"">
					<h3><strong><u> Empleados </u></strong></h3><h3>
					</h3>
				</div>

				<br><br>
				<div class=""pregunta"">

					<h6> Numero de empleados: </h6>
					<input class=""form-control"" type=""text"" name=""23""");
                BeginWriteAttribute("value", " value=\"", 4689, "\"", 4697, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\t\t\t\t\t<h6> DNI - Nombre completo - Correo Electrónico - Departamento o Función -  </h6>\n\t\t\t\t\t<h6>Data de alta en la empresa</h6><h6>17/01/2021</h6>\n");
#nullable restore
#line 204 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
                     foreach (var item in Model.trabajadores){

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"24\"");
                BeginWriteAttribute("value", " value=\"", 5001, "\"", 5075, 3);
#nullable restore
#line 205 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
WriteAttributeValue("", 5009, item.TrabajadorNif, 5009, 19, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
WriteAttributeValue("  ", 5028, item.TrabajadorNome, 5030, 20, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
WriteAttributeValue("    ", 5050, item.SeguridadSocial, 5054, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n");
#nullable restore
#line 206 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\lopd.cshtml"
					}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"				   
				</div>

				<br><br>
				<div class=""pregunta"">
					<h3><strong><u> Equipos y Dispositivos </u></strong></h3><h3>
					</h3>
				</div>

				<br><br>
				<div class=""pregunta"">

					<h6> Numero de ordenadores: </h6>
					<input class=""form-control"" type=""text"" name=""26""");
                BeginWriteAttribute("value", " value=\"", 5369, "\"", 5377, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Tienen contraseña los ordenadores? </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"27\"");
                BeginWriteAttribute("value", " value=\"", 5539, "\"", 5547, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Numero de teléfonos móviles: </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"28\"");
                BeginWriteAttribute("value", " value=\"", 5702, "\"", 5710, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Tienen contraseña los móviles? </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"29\"");
                BeginWriteAttribute("value", " value=\"", 5868, "\"", 5876, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Numero de tablets: </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"30\"");
                BeginWriteAttribute("value", " value=\"", 6021, "\"", 6029, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Tienen contraseña las tablets? </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"31\"");
                BeginWriteAttribute("value", " value=\"", 6187, "\"", 6195, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Numero de impresoras: </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"32\"");
                BeginWriteAttribute("value", " value=\"", 6343, "\"", 6351, 0);
                EndWriteAttribute();
                WriteLiteral(@">
				</div>

				<br><br>
				<div class=""pregunta"">
					<h3><strong><u> Medios de Pago </u></strong></h3><h3>
					</h3>
				</div>

				<br><br>
				<div class=""pregunta"">

					<h6> Dispone de datáfono / TPV físico o virtual? </h6>
					<input class=""form-control"" type=""text"" name=""34""");
                BeginWriteAttribute("value", " value=\"", 6643, "\"", 6651, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Numero de datáfonos / TPVS: </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"35\"");
                BeginWriteAttribute("value", " value=\"", 6805, "\"", 6813, 0);
                EndWriteAttribute();
                WriteLiteral(@">
				</div>

				<br><br>
				<div class=""pregunta"">
					<h3><strong><u> Encargados de Tratamiento </u></strong></h3><h3>
					</h3>
				</div>

				<br><br>
				<div class=""pregunta"">

					<h6> ¿Trabaja con una Gestoría Laboral y/o Contable Fiscal? </h6>
					<input class=""form-control"" type=""text"" name=""37""");
                BeginWriteAttribute("value", " value=\"", 7127, "\"", 7135, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Encargado (Gestoría): </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"38\"");
                BeginWriteAttribute("value", " value=\"", 7283, "\"", 7291, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Nombre y apellidos (Representante Gestoría): </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"39\"");
                BeginWriteAttribute("value", " value=\"", 7462, "\"", 7470, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> NIF(Representante Gestoría): </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"40\"");
                BeginWriteAttribute("value", " value=\"", 7625, "\"", 7633, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Donde trabaja. En su local, en mi local o por acceso remoto? </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"41\"");
                BeginWriteAttribute("value", " value=\"", 7821, "\"", 7829, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Dirección de la gestoría: </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"42\"");
                BeginWriteAttribute("value", " value=\"", 7981, "\"", 7989, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Trabaja con empresa de Mantenimiento Informático? </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"43\"");
                BeginWriteAttribute("value", " value=\"", 8166, "\"", 8174, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Encargado (Informático): </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"44\"");
                BeginWriteAttribute("value", " value=\"", 8325, "\"", 8333, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Nombre y apellido(Representante Informático): </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"45\"");
                BeginWriteAttribute("value", " value=\"", 8505, "\"", 8513, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Nif(Representante Informático): </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"46\"");
                BeginWriteAttribute("value", " value=\"", 8671, "\"", 8679, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Donde trabaja. En su local, en mi local o por acceso remoto? </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"47\"");
                BeginWriteAttribute("value", " value=\"", 8867, "\"", 8875, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Dirección de la empresa informática: </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"48\"");
                BeginWriteAttribute("value", " value=\"", 9038, "\"", 9046, 0);
                EndWriteAttribute();
                WriteLiteral(@">
				</div>

				<br><br>
				<div class=""pregunta"">
					<h3><strong><u> Ficheros de datos personales </u></strong></h3><h3>
					</h3>
				</div>

				<br><br>
				<div class=""pregunta"">

					<h6> Trata datos de  CLIENTES, como nombre, teléfono, dirección, D.N.I, o similares? </h6>
					<input class=""form-control"" type=""text"" name=""50""");
                BeginWriteAttribute("value", " value=\"", 9388, "\"", 9396, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Determine el porcentaje aproximado de clientes particulares ( </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"51\"");
                BeginWriteAttribute("value", " value=\"", 9584, "\"", 9592, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Cuales de estos documentos utiliza con sus clientes? (Tickets, Facturas, Recibos, Presupuestos, Contratos y Fichas): </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"52\"");
                BeginWriteAttribute("value", " value=\"", 9836, "\"", 9844, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Utiliza la base de datos de clientes para remitirles información comercial? </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"53\"");
                BeginWriteAttribute("value", " value=\"", 10047, "\"", 10055, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6>  ¿Tiene EMPLEADOS en cualquier régimen? </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"54\"");
                BeginWriteAttribute("value", " value=\"", 10221, "\"", 10229, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Dispone de  sistema de VIDEOVIGILANCIA con grabación de imágenes? </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"55\"");
                BeginWriteAttribute("value", " value=\"", 10422, "\"", 10430, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Qué sistema de VIDEOVIGILANCIA dispone?(Grabación de imagenes con alarma, cámaras disuasorias...) </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"56\"");
                BeginWriteAttribute("value", " value=\"", 10655, "\"", 10663, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Dispone de los CURRÍCULUMS de sus empleados? </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"57\"");
                BeginWriteAttribute("value", " value=\"", 10835, "\"", 10843, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Recaba datos de candidatos a empleado de modo habitual a través de CURRÍCULUMS? </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"58\"");
                BeginWriteAttribute("value", " value=\"", 11050, "\"", 11058, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Dispone de algún servidor? </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"60\"");
                BeginWriteAttribute("value", " value=\"", 11212, "\"", 11220, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Qué tipo de servidor utiliza? </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"61\"");
                BeginWriteAttribute("value", " value=\"", 11377, "\"", 11385, 0);
                EndWriteAttribute();
                WriteLiteral(@">
				</div>

				<br><br>
				<div class=""pregunta"">
					<h3><strong><u> Internet </u></strong></h3><h3>
					</h3>
				</div>

				<br><br>
				<div class=""pregunta"">

					<h6> ¿Tiene internet en su local? </h6>
					<input class=""form-control"" type=""text"" name=""63""");
                BeginWriteAttribute("value", " value=\"", 11656, "\"", 11664, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Detalle el tipo de Router (ADSL, Fibra Óptica…): </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"64\"");
                BeginWriteAttribute("value", " value=\"", 11839, "\"", 11847, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Tiene la wifi activa protegida con contraseña? </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"65\"");
                BeginWriteAttribute("value", " value=\"", 12021, "\"", 12029, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> ¿Da acceso a los clientes a su red WIFI? </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"66\"");
                BeginWriteAttribute("value", " value=\"", 12196, "\"", 12204, 0);
                EndWriteAttribute();
                WriteLiteral(@">
				</div>

				<br><br>
				<div class=""pregunta"">
					<h3><strong><u> Medidas Físicas de Seguridad </u></strong></h3><h3>
					</h3>
				</div>

				<br><br>
				<div class=""pregunta"">

					<h6> ¿Dónde archiva la documentación administrativa? (Armarios con/sin llave, cajoneras con/sin llave, sala aparte con/sin llave, domicilio particular, gestoria...) </h6>
					<input class=""form-control"" type=""text"" name=""68""");
                BeginWriteAttribute("value", " value=\"", 12626, "\"", 12634, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<br><br>\n\t\t\t\t<div class=\"pregunta\">\n\n\t\t\t\t\t<h6> Señale qué medidas dispone en su local ( Extintores, destructora de papel, alarma y persiana metálica): </h6>\n\t\t\t\t\t<input class=\"form-control\" type=\"text\" name=\"69\"");
                BeginWriteAttribute("value", " value=\"", 12864, "\"", 12872, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\t\t\t\t</div>\n\n\t\t\t\t<input type=\"hidden\" name=\"anscounter\" value=\"69\">\n\t\t\t\t<input type=\"hidden\" name=\"cif\" value=\"B61708178\">\n\t\t\t\t<br>\n\n\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t</div>\n\t</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Plataforma.ViewModels.ContratoEncomiendaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
