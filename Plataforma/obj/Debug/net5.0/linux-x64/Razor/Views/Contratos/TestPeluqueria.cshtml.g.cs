#pragma checksum "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestPeluqueria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bef884b5551daf4b2fe7a8d969dd44bb84c0c12f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contratos_TestPeluqueria), @"mvc.1.0.view", @"/Views/Contratos/TestPeluqueria.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef884b5551daf4b2fe7a8d969dd44bb84c0c12f", @"/Views/Contratos/TestPeluqueria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"419e03b9f5afb17e76ff6540606c73c87f585a34", @"/Views/_ViewImports.cshtml")]
    public class Views_Contratos_TestPeluqueria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plataforma.ViewModels.SolicitudCursoViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\n\n\n\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\n\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bef884b5551daf4b2fe7a8d969dd44bb84c0c12f3523", async() => {
                WriteLiteral("\n\n\n\n    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=ISO-8859-1\" />\n\n\n\n    <title>Documento sin título</title>\n\n\n\n    <link href=\"css/estilo.css\" rel=\"stylesheet\" type=\"text/css\" />\n\n\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n\n\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bef884b5551daf4b2fe7a8d969dd44bb84c0c12f4723", async() => {
                WriteLiteral("\n\n\n\n");
#nullable restore
#line 38 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestPeluqueria.cshtml"
    foreach (var item in Model.Trabajadores)
   {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <table width=""1000"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">



        <tr>



            <td align=""center"">
                <span class=""texto""><strong>EXAMEN TIPO  TEST PARA EL CURSO: &quot;Prevenci&oacute;n de riesgos laborales en la perruquer&iacute;a 2020""</span><br />



                <br>



                <table width=""1000"" border=""1"" cellpadding=""2"" cellspacing=""2"" class=""texto"">



                    <tr>



                        <td width=""115"" align=""center"" valign=""top"" bgcolor=""#CCCCCC""><strong>PARTICIPANTE </strong></td>



                        <td width=""461"" align=""center"" valign=""top"" bgcolor=""#0000ff"">
                            <strong>
                                <font color=""#FFFFFF"">



                                    ");
#nullable restore
#line 75 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestPeluqueria.cshtml"
                               Write(item.TrabajadorNome);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"



                                </font>
                            </strong>
                        </td>



                    </tr>



                    <tr>



                        <td width=""115"" align=""center"" valign=""top"" bgcolor=""#CCCCCC""><strong>NIF/NIE</strong></td>



                        <td width=""461"" align=""center"" valign=""top"" bgcolor=""#0000ff"">
                            <font color=""#FFFFFF"">



                                ");
#nullable restore
#line 102 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestPeluqueria.cshtml"
                           Write(item.TrabajadorNif);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"



                            </font>
                        </td>



                    </tr>



                    <tr>



                        <td width=""115"" align=""center"" valign=""top"" bgcolor=""#CCCCCC""><strong>EMPRESA</strong></td>



                        <td width=""461"" align=""center"" valign=""top"" bgcolor=""#0000ff"">
                            <font color=""#FFFFFF"">



                                ");
#nullable restore
#line 128 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestPeluqueria.cshtml"
                           Write(Model.Empresa.Nombre_Empresa);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"



                            </font>
                        </td>



                    </tr>



                </table>







                <p>&nbsp;</p>



                <p>&nbsp;</p>



                <table width=""1000"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"" class=""texto"">



                    <tr>



                        <td>
                            <strong></strong>1.	Una enfermedad profesional ...



                            <br>a)	Es un proceso r&aacute;pido de deterioro de la persona, debido a una exposici&oacute;n de una fuente contagiosa. <br />



                            b)    Es un proceso de recuperaci&oacute;n de la persona debido a una enfermedad como consecu&eacute;ncia del trabajo.<br />



                            c)    Es un proceso lento y progresivo de deterioro de la persona debido a una exposici&oacute;n de alguna fuente contagiosa.<br />



                            d) Todas las respuestas son ciertas. <br />



                     ");
                WriteLiteral(@"       <br />



                            2.	El sill&oacute;n del cliente en una peluquer&iacute;a ...



                            <br>a)	Debe ser r&iacute;jido y colocado a una altura de 50 cm. del suelo.<br />



                            b)	Debe ser adaptable a la altura del cliente. <br />



                            c)	Debe ser adaptable a la altura del trabajador para que trabaje con la espalda erguida. <br />



                            d)	Ninguna respuesta es cierta. <br />



                            <br />



                            3.	Una enfermedad profesional . . .



                            <br>a)	Utilizando guantes de l&aacute;tex. <br />



                            b)	Utilizando guantes adecuados. <br />



                            c)	No se deben utilizar guantes.<br />



                            d)	Se har&aacute; siempre en posici&oacute;n sentado. <br />



                            <br />



                            4.	Entre los principios de la acci&");
                WriteLiteral(@"oacute;n preventiva se encuentra ...



                            <br>a) Evitar los riesgos.<br />



                            b)	Adaptar el trabajo a la persona. <br />



                            c)	Tener en cuenta la evoluci&oacute;n de la t&eacute;cnica. <br />



                            d)	Todas son ciertas. <br />



                            <br />



                            5.	Las lesiones de la piel producidas por objetos cortantes o punzantes, se denominan ...



                            <br>a)	 Contusiones. <br />



                            b)	Golpes.     <br />



                            c)    Heridas.	<br />



                            d)  Fracturas <br />



                            <br />



                            6.	Si debemos utilizar el extintor de incendios, lo haremos ...<br />



                            b)  No debemos utilizar nunca el extintor.     <br />



                            c)  Orientando la manguera por encima de las llamas.     <b");
                WriteLiteral(@"r />



                            d)  Siempre contra el viento.. <br />



                            <br />



                            7.	Si debemos colocar un elemento pesado en las estanterias de la peluquer&iacute;a,  d&oacute;nde lo colocaremos?



                            <br>a)  Siempre en la parte m&aacute;s alta.     <br />



                            b)   Siempre en la parte m&aacute;s baja.     <br />



                            c)  No importa la altura, donde nos venga mejor.    <br />



                            d)  En la parte media a la altura de los brazos. <br />
                        </td>



                    </tr>



                </table>



                <p class=""texto"">EMPRESA ORGANIZADORA <img width=""200"" height=""92"" src=""https://localhost:44335/PRL/EBR-.jpg"" />      </p>



                <p class=""texto"">&nbsp;</p>



                <p class=""texto"">
                    <br />



                    <br />



                    <br />



               ");
                WriteLiteral(@" </p>



                <p class=""texto"">
                    <br />



                    <br />



                </p>



                <table width=""1000"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""texto"">



                    <tr>



                        <td>
                            8.    Los zapatos que debemos utilizar al trabajar de pie en un sal&oacute;n de belleza o peluquer&iacute;a, ser&aacute;n ...



                            <br>a)	Lo m&aacute;s planos posible. <br />



                            b)	Muy finos de suela y con tacón. <br />



                            c)	Con un tac&oacute;n no muy alto y antideslizantes. <br />



                            d)	Con un tac&oacute;n de 6 cm. y antideslizantes. <br />



                            <br />



                            9.    Qu&eacute; medidas de prevenci&oacute;n pueden aplicarse en los trabajos de limpieza de una peluquer&iacute;a?



                            <br>a)	 Usar el equipo de protecci&oacute;n");
                WriteLiteral(@" individual. <br />



                            b)	Vigilar el tiempo máximo de exposici&oacute;n a productos. <br />



                            c)	Prohibido fumar, beber o comer en zonas de riesgo biol&oacute;gico. <br />



                            d)	Todas las respuestas son ciertas. <br />



                            <br />



                            10.	Qu&eacute; tipos de estr&eacute;s t&eacute;rmicos existen?



                            <br>a)	Por esfuerzos f&iacute;sicos y esfuerzos mentales. <br />



                            b)	Por cargas de trabajo. <br />



                            c)	Por fr&iacute;o y por calor. <br />



                            d)	Todas las respuestas son ciertas. <br />



                            <br />



                            11. Qu&eacute; problemas principales puede causar una herida de unas tijeras de corte de pelo?



                            <br>a)	 Infecci&oacute;n y hemorrágia. <br />



                            b)	Hematoma");
                WriteLiteral(@"s. <br />



                            c)	Flictemas. <br />



                            d)	Hemorr&aacute;gias y quemaduras. <br />



                            <br />



                            12.   A qu&eacute; se llama riesgo laboral?



                            <br>a)	 A la posibilidad de que ocurra un accidente. <br />



                            b)	A la producci&oacute;n de un da&ntilde;o al medio-ambiente. <br />



                            c)    A la posibilidad de que un trabajador sufra un da&ntilde;o. <br />



                            d)	Al da&ntilde;o que ha sufrido un trabajador.
                        </td>



                    </tr>



                </table>











                <p>&nbsp;</p>



                <p>&nbsp;</p>



                <p>
                    <br />



                    <br />



                </p>



                <table border=""1"" cellpadding=""0"" cellspacing=""0"" class=""texto"" style=""margin-bottom: 80px"">



                    ");
                WriteLiteral(@"<tr>



                        <td width=""20"" align=""center"">TEST</td>



                        <td width=""20"" align=""center"">1</td>



                        <td width=""20"" align=""center"">2</td>



                        <td width=""20"" align=""center"">3</td>



                        <td width=""20"" align=""center"">4</td>



                        <td width=""20"" align=""center"">5</td>



                        <td width=""20"" align=""center"">6</td>



                        <td width=""20"" align=""center"">7</td>



                        <td width=""20"" align=""center"">8</td>



                        <td width=""20"" align=""center"">9</td>



                        <td width=""20"" align=""center"">10</td>



                        <td width=""20"" align=""center"">11</td>



                        <td width=""20"" align=""center"">12</td>



                    </tr>



                    <tr>



                        <td width=""61"" align=""center"">a</td>



                        <td width=""44"" valign=""top""></td>");
                WriteLiteral(@"



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                    </tr>



                    <tr>



                        <td width=""61"" align=""center"">b</td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign");
                WriteLiteral(@"=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                    </tr>



                    <tr>



                        <td width=""61"" align=""center"">c</td>



                        <td width=""44"" valign=""top"">&nbsp;</td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td");
                WriteLiteral(@" width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                    </tr>



                    <tr>



                        <td width=""61"" align=""center"">d</td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



               ");
                WriteLiteral(@"         <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                        <td width=""44"" valign=""top""></td>



                    </tr>



                </table>








                <table width=""1000"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""texto"" style=""page-break-after: always;"">



                    <tr>



                        <td width=""500"" align=""center"">
                            <table width=""480"" border=""0"" cellspacing=""0"" cellpadding=""0"">



                                <tr>



                                    <td width=""406""><hr /></td>



                                </tr>



                                <tr>



                                    <td align=""center"">Tutoria</td>



                                </tr>



                                <tr>



                                    <td align=""center"">FRANCESC VILARO SALADELAFONT</td>



                                </tr>



            ");
                WriteLiteral(@"                    <tr>



                                    <td align=""center"">Tecnico superior en prevencion de riesgos laborales</td>



                                </tr>



                            </table>
                        </td>



                        <td width=""500"" align=""center"" style=""padding-bottom: 40px"">
                            <table width=""450"" border=""0"" cellspacing=""0"" cellpadding=""0"">



                                <tr>



                                    <td><hr /></td>



                                </tr>



                                <tr>



                                    <td align=""center"">Firma del Alumno</td>



                                </tr>



                                <tr>



                                    <td align=""center"" bgcolor=""#0000ff"">
                                        <strong>
                                            <font color=""#FFFFFF"">



                                                <?=$fila[""nom");
                WriteLiteral(@"bre""];?>



                                            </font>
                                        </strong>
                                    </td>



                                </tr>



                                <tr>



                                    <td align=""center"">&nbsp;</td>



                                </tr>



                            </table>
                        </td>



                    </tr>



                    <tr>



                        <td align=""center"" valign=""middle"">
                            <br />



                            <img width=""200"" height=""92"" src=""https://localhost:44335/PRL/EBR-.jpg"" /> EMPRESA ORGANIZADORA
                        </td>



                        <td>&nbsp;</td>



                    </tr>



                </table>
            </td>



        </tr>



    </table>
");
#nullable restore
#line 1021 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestPeluqueria.cshtml"
   }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Plataforma.ViewModels.SolicitudCursoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
