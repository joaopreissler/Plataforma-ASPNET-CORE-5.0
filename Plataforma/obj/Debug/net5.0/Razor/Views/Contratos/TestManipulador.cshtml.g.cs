#pragma checksum "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestManipulador.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad5b527ef03ce9dadd281558d69c77befb8ebcc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contratos_TestManipulador), @"mvc.1.0.view", @"/Views/Contratos/TestManipulador.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad5b527ef03ce9dadd281558d69c77befb8ebcc5", @"/Views/Contratos/TestManipulador.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"419e03b9f5afb17e76ff6540606c73c87f585a34", @"/Views/_ViewImports.cshtml")]
    public class Views_Contratos_TestManipulador : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plataforma.ViewModels.SolicitudCursoViewModel>
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
            WriteLiteral("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad5b527ef03ce9dadd281558d69c77befb8ebcc53516", async() => {
                WriteLiteral("\n    <meta http-equiv=\"content-type\" content=\"text/html; charset=utf-8\" />\n    <title>TEST MANIPULADOR</title>\n    <link href=\"css/estilo.css\" rel=\"stylesheet\" type=\"text/css\" />\n");
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad5b527ef03ce9dadd281558d69c77befb8ebcc54671", async() => {
                WriteLiteral("\n");
#nullable restore
#line 11 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestManipulador.cshtml"
   foreach(var item in Model.Trabajadores) { 

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <table width=""1000"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"" style=""page-break-after: always;"">
        <tr>
            <td align=""center"">
                <p class=""texto"">
                    <strong>EXAMEN TIPO  TEST PARA EL CURSO: &ldquo;Manipulacion Higiene y Seguridad Alimentaria&rdquo; ");
#nullable restore
#line 16 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestManipulador.cshtml"
                                                                                                                   Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong>
                    <table width=""1000"" border=""1"" cellpadding=""2"" cellspacing=""2"" class=""texto"">
                        <tr>
                            <td width=""115"" align=""center"" valign=""top"" bgcolor=""#CCCCCC""><strong>PARTICIPANTE </strong></td>
                            <td width=""461"" align=""center"" valign=""top"" bgcolor=""#0000ff""><strong><font color=""#FFFFFF"">");
#nullable restore
#line 20 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestManipulador.cshtml"
                                                                                                                   Write(item.TrabajadorNome);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</font></strong></td>
                        </tr>
                        <tr>
                            <td width=""115"" align=""center"" valign=""top"" bgcolor=""#CCCCCC""><strong>NIF      /   NIE</strong></td>
                            <td width=""461"" align=""center"" valign=""top"" bgcolor=""#0000ff""><font color=""#FFFFFF"">");
#nullable restore
#line 24 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestManipulador.cshtml"
                                                                                                           Write(item.TrabajadorNif);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</font></td>
                        </tr>
                        <tr>
                            <td width=""115"" align=""center"" valign=""top"" bgcolor=""#CCCCCC""><strong>EMPRESA</strong></td>
                            <td width=""461"" align=""center"" valign=""top"" bgcolor=""#0000ff""><font color=""#FFFFFF"">");
#nullable restore
#line 28 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestManipulador.cshtml"
                                                                                                           Write(Model.Empresa.Nombre_Comercial);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</font></td>
                        </tr>
                    </table>
                </p>
                <p align=""center"">
                    &nbsp;
                    <table width=""1000"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"" class=""texto"">
                        <tr style=""page-break-after: always"">
                            <td>
                                1.- <strong>La mayor&iacute;a de microorganismos que provocan </strong><strong>enfermedades alimentarias</strong><strong>:</strong><br />
                                a) crecen a temperaturas cercanas a 37ºC<br />
                                b) pueden crecer entre 5ºC  y 45ºC<br />
                                c) por debajo de 4ºC<br />
                                d) a y b son correctas
                                <br />
                                <br />
                                2.- <strong>Los manipuladores tienen la  obligación de:</strong><br />
                                a) llevar ro");
                WriteLiteral(@"pa de calle<br />
                                b) recibir formación de higiene alimentaria<br />
                                c) ir muy maquillado al trabajo<br />
                                d) todas son correctas
                                <br />
                                <br />
                                3.- <strong>Se considera un alimento no seguro cuando:</strong><br />
                                a) sea comercializado<br />
                                b) sea nocivo para la salud<br />
                                c) sea apto para el consumo<br />
                                d) b y c son correctas
                                <strong>
                                    <br />
                                    <br />
                                    4.- Los alimentos se pueden alterar de manera:
                                </strong><br />
                                a) qu&iacute;mica<br />
                                b) f&iacute;sica<br />
   ");
                WriteLiteral(@"                             c) biológica<br />
                                d) todas son correctas
                                <br />
                                <br />
                                <strong>5.-</strong> <strong>Qué tipos  de alimentos pueden favorecer el crecimiento de</strong><strong> bacteriano:</strong><br />
                                a) alimento alto en prote&iacute;nas<br />
                                b) alimento con acidez neutra<br />
                                c) alimento con un alto contenido de humedad<br />
                                d) todas son correctas
                                <br />
                                <br />
                                <strong>6.- Los s&iacute;ntomas m&aacute;s  comunes de una enfermedad causada por contaminación alimentaria son:</strong><br />
                                a) n&aacute;useas<br />
                                b) vómitos<br />
                                c) diarreas<br />
     ");
                WriteLiteral(@"                           d) todas son correctas
                                <strong>
                                    <br />
                                    <br />
                                    7.- Unos h&aacute;bitos correctos  de higiene en el trabajo son:
                                </strong><br />
                                a) llevar pendientes<br />
                                b) masticar chicle<br />
                                c) fumar mientras se trabaja<br />
                                d) evitar llevar maquillaje
                                <strong>
                                    <br />
                                    <br />
                                    8.- Que paso NO es  correcto en la limpieza de manos:
                                </strong><br />
                                a) utilizar jabón bactericida<br />
                                b) utilizar agua fr&iacute;a<br />
                                c) lavarse las manos ha");
                WriteLiteral(@"sta los codos<br />
                                d) secarse las manos con toallas de un solo uso o aire.
                                <strong>
                                    <br />
                                    <br />
                                    9.- Para una buena conservación de los alimentos  es
                                </strong><strong>necesario:</strong><br />
                                a) evitar la contaminación de recipientes y utensilios<br />
                                b) crear condiciones desfavorables para el crecimiento bacteriano<br />
                                c) evitar que lleguen al alimento el menor n&uacute;mero de bacterias<br />
                                d) todas son correctas
                                <strong>
                                    <br />
                                </strong>
                            </td>
                        </tr>
                    </table>
                </p>
                <p>&nbsp;");
                WriteLiteral(@"</p>
                <p>
                    <br />
                    <br />
                </p>
                <table width=""1000"" border=""1"" cellspacing=""0"" cellpadding=""0"" style=""page-break-before: always;"">
                    <tr>
                        <td align=""center"" bgcolor=""#0000ff"" class=""texto""><strong><font color=""#FFFFFF""><?=$dados[""nombre""];?></font></strong></td>
                    </tr>
                </table>
                <br />
                <table width=""1000"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"" class=""texto"">
                    <tr>
                        <td>
                            <p>
                                <strong>10.-Algunos métodos para conservar alimentos son:</strong> <br />
                                a) salmuera<br />
                                b) enlatado<br />
                                c) envasado al vac&iacute;o<br />
                                d) todas son correctas <strong>
                              ");
                WriteLiteral(@"      <br />
                                    <br />
                                    11.-
                                </strong> <strong>Tener un  plan de limpieza y desinfección es importante </strong><strong>para:</strong><br />
                                a) evitar la contaminación cruzada<br />
                                b) eliminar los residuos<br />
                                c) para dejar los alimentos en el suelo<br />
                                d) a y b son correctas<br />
                                <br />
                                <strong>12.-</strong> <strong>Las  ventajas de tener un plan de APPCC son:</strong><br />
                                a) método preventivo<br />
                                b) se aplica a toda la cadena alimentaria<br />
                                c) es flexible porque se adapta a todo tipo de empresa alimentaria<br />
                                d) todas son correctas
                                <strong>
       ");
                WriteLiteral(@"                             <br />
                                    <br />
                                </strong><strong>
                                    <br />
                                </strong>
                            </p>
                            <p>&nbsp;</p>
                        </td>
                    </tr>
                </table>
                &nbsp;
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>
                    <strong>&nbsp;</strong><br />
                </p>
                <table border=""1"" align=""center"" cellpadding=""0"" cellspacing=""0"" class=""texto"">
                    <tr>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">1</td>
                        <td width=""32"" valign=""top"">2</td>
                        <td width=""32"" valign=""top"">3</td>
                        <td width=""32"" valign=""top"">4</td>");
                WriteLiteral(@"
                        <td width=""32"" valign=""top"">5</td>
                        <td width=""32"" valign=""top"">6</td>
                        <td width=""32"" valign=""top"">7</td>
                        <td width=""32"" valign=""top"">8</td>
                        <td width=""32"" valign=""top"">9</td>
                        <td width=""38"" valign=""top"">10</td>
                        <td width=""38"" valign=""top"">11</td>
                        <td width=""38"" valign=""top"">12</td>
                    </tr>
                    <tr>
                        <td width=""32"" valign=""top"">a</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&n");
                WriteLiteral(@"bsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""38"" valign=""top"">&nbsp;</td>
                        <td width=""38"" valign=""top"">&nbsp;</td>
                        <td width=""38"" valign=""top"">&nbsp;</td>
                    </tr>
                    <tr>
                        <td width=""32"" valign=""top"">b</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
        ");
                WriteLiteral(@"                <td width=""38"" valign=""top"">&nbsp;</td>
                        <td width=""38"" valign=""top"">&nbsp;</td>
                        <td width=""38"" valign=""top"">&nbsp;</td>
                    </tr>
                    <tr>
                        <td width=""32"" valign=""top"">c</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""38"" valign=""top"">&nbsp;</td>
                        <td width=""38"" valign=""top"">&nbsp;</td>
                        <t");
                WriteLiteral(@"d width=""38"" valign=""top"">&nbsp;</td>
                    </tr>
                    <tr>
                        <td width=""32"" valign=""top"">d</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""32"" valign=""top"">&nbsp;</td>
                        <td width=""38"" valign=""top"">&nbsp;</td>
                        <td width=""38"" valign=""top"">&nbsp;</td>
                        <td width=""38"" valign=""top"">&nbsp;</td>
                    </tr>
                </table>
                <p>
                    <br />
          ");
                WriteLiteral(@"          &nbsp;<span class=""texto"">
                        OBSERVACIONES
                    </span> &nbsp;
                </p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>
                    &nbsp;
                    &nbsp;
                </p>
                <table width=""1000"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""texto"">
                    <tr>
                        <td width=""500"" align=""center"">
                            <table width=""450"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                                <tr>
                                    <td width=""406""><hr /></td>
                                </tr>
                                <tr>
                                    <td align=""center"">Tutoria</td>
                                </tr>
                                <tr>
                                    <td align=""center"">FRANCESC VILARÓ SALADEFONT</td>
                                </tr");
                WriteLiteral(@">
                                <tr>
                                    <td align=""center"" Técnico=Técnico en=en Manipulación=Manipulación de=de Alimentos=Alimentos></td>
                                </tr>
                            </table>
                        </td>
                        <td width=""500"" align=""center"">
                            <table width=""450"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                                <tr>
                                    <td><hr /></td>
                                </tr>
                                <tr>
                                    <td align=""center"">Firma del Alumno</td>
                                </tr>
                                <tr>
                                    <td align=""center"" bgcolor=""#0000ff""><strong><font color=""#FFFFFF""><?=$fila[""nombre""];?></font></strong></td>
                                </tr>
                                <tr>
                                    <td align=""center"">&nbsp;");
                WriteLiteral(@"</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td align=""center"" valign=""middle"">
                            <br />
                            <img width=""200"" height=""92"" src=""https://eurobrazil-formacion.s3.us-east-2.amazonaws.com/storage/Imagens/EBR-.jpg"" /> EMPRESA ORGANIZADORA
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
");
#nullable restore
#line 302 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestManipulador.cshtml"
   }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n</html>");
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