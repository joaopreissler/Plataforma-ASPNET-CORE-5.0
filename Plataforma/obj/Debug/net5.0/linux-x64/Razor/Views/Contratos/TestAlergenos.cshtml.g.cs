#pragma checksum "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestAlergenos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9441d4c14de1d238407d80a62817dc0e9593f5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contratos_TestAlergenos), @"mvc.1.0.view", @"/Views/Contratos/TestAlergenos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9441d4c14de1d238407d80a62817dc0e9593f5f", @"/Views/Contratos/TestAlergenos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"419e03b9f5afb17e76ff6540606c73c87f585a34", @"/Views/_ViewImports.cshtml")]
    public class Views_Contratos_TestAlergenos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plataforma.ViewModels.SolicitudCursoViewModel>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9441d4c14de1d238407d80a62817dc0e9593f5f3506", async() => {
                WriteLiteral("\n\n    <meta charset=\"UTF-8\">\n    \n    <link href=\"css/estilo.css\" rel=\"stylesheet\" type=\"text/css\" />\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9441d4c14de1d238407d80a62817dc0e9593f5f4583", async() => {
                WriteLiteral("\n");
#nullable restore
#line 12 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestAlergenos.cshtml"
    foreach (var item in Model.Trabajadores)
   {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <table width=""1000"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"" style=""page-break-after: always"">
        <tr>
            <td align=""center"">
                <span class=""texto""><strong>EXAMEN TIPO  TEST PARA EL CURSO: &ldquo;Alergias e Intolerancias Alimentarias&rdquo; ");
#nullable restore
#line 17 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestAlergenos.cshtml"
                                                                                                                            Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong></span><strong>  </strong><br />
                <strong>                                              </strong>
                <table width=""1000"" border=""1"" cellpadding=""2"" cellspacing=""2"" class=""texto"">
                    <tr>
                        <td width=""115"" align=""center"" valign=""top"" bgcolor=""#CCCCCC""><strong>PARTICIPANTE </strong></td>
                        <td width=""461"" align=""center"" valign=""top"" bgcolor=""#0000ff"">
                            <strong>
                                <font color=""#FFFFFF"">
                                    ");
#nullable restore
#line 25 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestAlergenos.cshtml"
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
                        <td width=""115"" align=""center"" valign=""top"" bgcolor=""#CCCCCC""><strong>NIF      /   NIE</strong></td>
                        <td width=""461"" align=""center"" valign=""top"" bgcolor=""#0000ff"">
                            <font color=""#FFFFFF"">
                                ");
#nullable restore
#line 34 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestAlergenos.cshtml"
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
#line 42 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestAlergenos.cshtml"
                           Write(Model.Empresa.Nombre_Comercial);

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
                            <strong>1</strong>. ¿Qué significa que una persona tiene una  alergia alimentaria? <br />
                            a) Es una reacción no tóxica <br />
                            b) Es sinónimo de sensibilidad  alimentaria <br />
                            c) Es una respuesta  inmunológica del organismo cuando se ingieren determinados tipos de alimentos <br />
                            d) Ninguna de las  anteriores  
                            <br />
                            <br />
                            2. ¿Qué cereales  contienen gluten? <br />
                            a) Trigo, arroz y espelta <br />
                         ");
                WriteLiteral(@"   b) Trigo, espelta y centeno <br />
                            c) Arroz, ma&iacute;z y qu&iacute;noa <br />
                            d) Trigo, qu&iacute;noa y centeno
                            <br />
                            <br />
                            3. ¿Dónde se  puede encontrar soja? <br />
                            a) Aceite de oliva <br />
                            b) Salsa de soja <br />
                            c) Tofu <br />
                            d) b) y c) son correctas
                            <br />
                            <br />
                            4. ¿Qué  substitutivos de la prote&iacute;na de la vaca puedo utilizar? <br />
                            a) Mantequilla <br />
                            b) Nata <br />
                            c) Yogurt <br />
                            d) Margarina vegetal
                            <br />
                            <br />
                            5. ¿Qué  sustancias producen alergia o intoler");
                WriteLiteral(@"ancia alimentaria? <br />
                            a) Apio <br />
                            b) Mostaza <br />
                            c) Sésamo <br />
                            d) Todas son correctas
                            <br />
                            <br />
                            6. ¿Qué  productos contiene sulfitos? <br />
                            a) Gambas <br />
                            b) Vino <br />
                            c) Legumbres <br />
                            d) Todas son correctas
                            <br />
                            <br />
                            7. El  manipulador de alimentos antes de cocinar tiene que tener en cuenta: <br />
                            a) Mirar con atención las etiquetas de los alimentos a utilizar por si  hay alg&uacute;n alérgeno oculto <br />
                            b) No utilizar productos envasados que no tengan etiquetas <br />
                            c) Vaciar el contenido del envase origin");
                WriteLiteral(@"al a otros envases de cocina <br />
                            d) A) i B) son correctas<br />
                            <br />
                        </td>
                    </tr>
                </table>
                <p class=""texto"">EMPRESA ORGANIZADORA <img width=""200"" height=""92"" src=""https://localhost:44335/PRL/EBR-.jpg"" />      </p>
                <p class=""texto"">&nbsp;</p>
                <p class=""texto"">
                    <br />
                    <br />
                    <br />
                </p>
                <p class=""texto"">&nbsp;</p>
                <table width=""1000"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""texto"">
                    <tr>
                        <td>
                            8. Unas buenas pr&aacute;cticas de manipulación son <br />
                            a) Tener un lugar exclusivo para guardar los productos implicados en  alergias e <br />
                            intolerancias alimentarias <br />
                            b) Prepar");
                WriteLiteral(@"ar los alimentos en espacios separados <br />
                            c) Cocinar primero la comida para el alérgico <br />
                            d) Todas son correctas <br />
                            <br />
                            9. ¿Qué guantes  debo utilizar en la cocina? <br />
                            a) Cualquier guante sirve <br />
                            b) Vinilo <br />
                            c) L&aacute;tex <br />
                            d) B) i C) son correctos<br />
                            <br />
                            10. ¿Qué  información es obligatoria en una etiqueta? <br />
                            a) Lista de ingredientes <br />
                            b) Sustancias que causan alergias <br />
                            c) Información nutricional <br />
                            d) Todas son correctas
                            <br />
                            <br />
                            11. Información  obligatoria para alimentos ");
                WriteLiteral(@"NO Envasados <br />
                            a) Lista de ingredientes <br />
                            b) Cantidad neta <br />
                            c) Facilitar las instrucciones de uso <br />
                            d) Disponer del listado de alérgenos
                            <br />
                            <br />
                            12. ¿Cu&aacute;ndo entra  en vigor la nueva reglamentación?<br />
                            a) A partir de diciembre de 2014 <br />
                            b) A partir de diciembre de 2014 excepto la información nutricional  que se aplicar&aacute; en diciembre 2016 <br />
                            c) A partir de diciembre de 2014 excepto la información nutricional  que se aplicar&aacute; en diciembre 2015 <br />
                            d) A partir de diciembre de 2015
                        </td>
                    </tr>
                </table>


                <p>&nbsp;</p>
                <p>&nbsp;</p>
                <p>
        ");
                WriteLiteral(@"            <br />
                    <br />
                </p>
                <table border=""1"" cellpadding=""0"" cellspacing=""0"" class=""texto"">
                    <tr>
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
 ");
                WriteLiteral(@"                       <td width=""61"" align=""center"">a</td>
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
                        <td width=""44"" valign=""top""></td>
                    </tr>
                    <tr>
                        <td width=""61"" align=""center"">b</td>
                        <td width=""44"" valign=""top""></td>
                        <td width=""44"" valign=""top""></td>
                        <td width=""44"" v");
                WriteLiteral(@"align=""top""></td>
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
                        <td width=""61"" align=""center"">c</td>
                        <td width=""44"" valign=""top"">&nbsp;</td>
                        <td width=""44"" valign=""top""></td>
                        <td width=""44"" valign=""top""></td>
                        <td width=""44"" valign=""top""></td>
                        <td width=""44"" valign=""top""></td>
                        <td width=""44"" valign=""top""></td>
                  ");
                WriteLiteral(@"      <td width=""44"" valign=""top""></td>
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
                        <td width=""44"" valign=""top""></td>
  ");
                WriteLiteral(@"                      <td width=""44"" valign=""top""></td>
                        <td width=""44"" valign=""top""></td>
                    </tr>
                </table>

                <p>
                    <br />
                    <br />
                    <br />
                    <br />
                </p>
                <p>&nbsp;</p>
                <p>
                    <br />
                    <br />

                </p>
                <p>
                    <br />
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
     ");
                WriteLiteral(@"                           </tr>
                                <tr>
                                    <td align=""center"">FRANCESC VILARÓ SALADEFONT</td>
                                    <td align=""center""> Técnico en Higiene Alimentaria</td>
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
                                    <td align=""center"" bgcolor=""#0000ff"">
                                        <strong>
                                            <font color=""#FFFFFF"">
                ");
                WriteLiteral(@"                                <?=$fila[""nombre""];?>
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
#line 302 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\TestAlergenos.cshtml"
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
