#pragma checksum "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\Caratulas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b773a2f301bf954ec9fd4750cb7bb13e4d5779b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contratos_Caratulas), @"mvc.1.0.view", @"/Views/Contratos/Caratulas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b773a2f301bf954ec9fd4750cb7bb13e4d5779b", @"/Views/Contratos/Caratulas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"419e03b9f5afb17e76ff6540606c73c87f585a34", @"/Views/_ViewImports.cshtml")]
    public class Views_Contratos_Caratulas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plataforma.ViewModels.SolicitudCursoViewModel>
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
            WriteLiteral("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b773a2f301bf954ec9fd4750cb7bb13e4d5779b3490", async() => {
                WriteLiteral("\r\n    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n    \r\n    <style type=\"text/css\">\r\n        .nombre {\r\n            font-size: 28px;\r\n        }\r\n    </style>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b773a2f301bf954ec9fd4750cb7bb13e4d5779b4664", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\Caratulas.cshtml"
     foreach (var item in Model.Trabajadores)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <table width=""1000"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"" style=""page-break-after: always;"">
        <tr>
            <td align=""center"">
                <p>&nbsp;</p>
                <table width=""1000"" border=""1"" cellpadding=""0"" cellspacing=""0"" class=""nombre"">
                    <tr>
                        <td colspan=""2"" valign=""top"">
                            <p align=""center"">
                                CURSO DE&nbsp; :<br />
                                ");
#nullable restore
#line 26 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\Caratulas.cshtml"
                           Write(Model.Curso.CursoNome);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <br />
                                Modalidad :&nbsp; Teleformacion
                            </p>
                        </td>
                    </tr>

                </table>
                <br />
                <br />
                <table width=""1000"" border=""1"" cellpadding=""0"" cellspacing=""0"" class=""nombre"">
                    <tr>
                        <td width=""262"" align=""center"" valign=""top"" bgcolor=""#CCCCCC""><strong>EMPRESA: </strong></td>
                        <td width=""732"" align=""center"" valign=""top"" bgcolor=""#0000ff"">
                            <strong>
                                <font color=""#FFFFFF"">
                                   ");
#nullable restore
#line 42 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\Caratulas.cshtml"
                              Write(Model.Empresa.Nombre_Empresa);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </font>
                            </strong>
                        </td>
                    </tr>
                    <tr>
                        <td width=""262"" align=""center"" valign=""top"" bgcolor=""#CCCCCC"">
                            <strong>
");
#nullable restore
#line 50 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\Caratulas.cshtml"
                                  
                                   var tipo = "";
                                   if(item.Trabajadortipo == "Autonomo")
                                   {
                                       tipo = "AUTONOMO";
                                   }
                                   else
                                   {
                                       tipo = "TRABAJADOR";
                                   }
                               

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
#nullable restore
#line 61 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\Caratulas.cshtml"
                           Write(tipo);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </strong>
                        </td>
                        <td width=""732"" align=""center"" valign=""top"" bgcolor=""#0000ff"">
                            <strong>
                                <font color=""#FFFFFF"">
                                    ");
#nullable restore
#line 67 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\Caratulas.cshtml"
                               Write(item.TrabajadorNome);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </font>
                            </strong>
                        </td>
                    </tr>
                </table>
                <p>
                    <br />
                </p>
                <p><span class=""nombre"">TUTORIA DEL CURSO</span></p>
                <table width=""1000"" border=""1"" cellpadding=""0"" cellspacing=""0"" class=""nombre"">
                    <tr>
                        <td align=""center"" valign=""top"">
                            <p>
                                A CARGO DE:<br />
                                <br />
                                <strong>FRANCESC VILARÓ SALADELAFONT</strong>
                            </p>
                            <p>
                                <em>""TECNICO EN PREVENCIÓN DE RIESGOS LABORALES""<br />
</p>
                        </td>
                    </tr>
                </table>
                <p>
                    <br />
                </p>
                <p");
                WriteLiteral(@" class=""nombre""> DIRECCI&Oacute;N  COMERCIAL</p>
                <table width=""1000"" border=""1"" cellpadding=""0"" cellspacing=""0"" class=""nombre"">
                    <tr>
                        <td width=""652"" align=""center"" valign=""top"">
                            Jordi  Muntan&eacute;     Pavillard<br />
                            <img width=""58"" height=""15"" src=""http://plataforma-dev.us-east-2.elasticbeanstalk.com/PRL/1.jpg"" /><img width=""58"" height=""15"" src=""http://plataforma-dev.us-east-2.elasticbeanstalk.com/PRL/2.jpg"" /><img width=""50"" height=""15"" src=""http://plataforma-dev.us-east-2.elasticbeanstalk.com/PRL/3.jpg"" /><img width=""60"" height=""15"" src=""http://plataforma-dev.us-east-2.elasticbeanstalk.com/PRL/4.jpg"" /><img width=""58"" height=""15"" src=""http://plataforma-dev.us-east-2.elasticbeanstalk.com/PRL/5.jpg"" />
                        </td>
                    </tr>
                    <tr>
                        <td width=""652"" valign=""top"">
                            <p align=""center"">");
                WriteLiteral(@"
                                Granvia de les Corts Catalanes 584 1º 2ª    08011 BARCELONA<br />
                                Telefono   934 546 078              Movil   611 41 25 35<br />
                                jordi.muntane.pavillard.cat@gmail.com
                            </p>
                        </td>
                    </tr>
                </table>
                <br />
                <p class=""nombre"">
                    <br />
                    EMPRESA ORGANIZADORA
                </p>
                <table width=""1000"" border=""1"" cellpadding=""0"" cellspacing=""0"" class=""nombre"">
                    <tr>
                        <td width=""206"" align=""center"" valign=""middle""><p><img width=""170"" height=""78"" src=""http://plataforma-dev.us-east-2.elasticbeanstalk.com/PRL/EBR-.jpg"" /></p></td>
                        <td width=""788"" valign=""top"">
                            <p align=""center"">
                                EUROBRAZIL INVESTMENTS    S.L.<br />
    ");
                WriteLiteral(@"                            CIF B66335472<br />
                                Gran Via de les Corts Catalanes 584 1º 2ª -
                                08011 BARCELONA   Teléfono   934 546 078
                                <a href=""mailto:eurobrazilinvestments@gmail.com"">eurobrazilinvestments@gmail.com</a>
                            </p>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
");
#nullable restore
#line 134 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\Caratulas.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    \r\n    \r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
