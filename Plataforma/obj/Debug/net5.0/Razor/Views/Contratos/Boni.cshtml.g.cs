#pragma checksum "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\Boni.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c2726d40a6ce4b5793709fb12dd64ce23ae3b0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contratos_Boni), @"mvc.1.0.view", @"/Views/Contratos/Boni.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c2726d40a6ce4b5793709fb12dd64ce23ae3b0b", @"/Views/Contratos/Boni.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"419e03b9f5afb17e76ff6540606c73c87f585a34", @"/Views/_ViewImports.cshtml")]
    public class Views_Contratos_Boni : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plataforma.Models.Empresa>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c2726d40a6ce4b5793709fb12dd64ce23ae3b0b3441", async() => {
                WriteLiteral("\n    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\n    <title>Instruccións per a la Bonificació</title>\n    <link href=\"css/estilo2.css\" rel=\"stylesheet\" type=\"text/css\" />\n   \n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c2726d40a6ce4b5793709fb12dd64ce23ae3b0b4619", async() => {
                WriteLiteral("\n   \n    <table width=\"1000\" border=\"0\" align=\"center\" class=\"texto2\">\n        <tr>\n            <td>\n                <p>\n                    Apreciado  Sr/Sra ");
#nullable restore
#line 17 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\Boni.cshtml"
                                 Write(Model.Nombrereprensentante);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </p>
                <table width=""1000"" border=""0"">
                    <tr>
                        <td bgcolor=""#FFFF00""><strong>ROGAMOS REENVIEN EL SIGUIENTE E-MAIL CON LA  MÁXIMA URGENCIA A SU GESTOR POR TAL DE QUE TRAMITEN LA BONIFICACIÓN.</strong></td>
                    </tr>
                </table>
                <p>Les  adjunto los datos necesarios para proceder a la bonificación del mismo mediante  la aplicación en el pago de los Seguros Sociales, así como otros detalles para  facilitarles, en la medida de lo posible, la cumplimentación de éstos. </p>
                <p>Las empresas podrán aplicarse las bonificaciones por formación continua a  partir del boletín de cotización correspondiente al mes en que haya finalizado  el grupo o grupos de formación y, en todo caso, con anterioridad a la fecha en  que finaliza el plazo de presentación del boletín de cotización  correspondiente al mes de diciembre del mismo ejercicio económico, y sin que  sea necesario detallar en los document");
                WriteLiteral(@"os de cotización el mes de finalización  ni las fechas de impartición de la formación. En todo caso, repetimos,<strong> no descontarse el importe a bonificar en los seguros sociales del mes abajo  indicado, pueden hacerlo en cualquier mes a partir de éste y, como plazo  máximo, deberán aplicarse las bonificaciones antes de la finalización del plazo  de presentación de las liquidaciones correspondientes al mes de diciembre de  este año.</strong></p>
                <p>
                    Cuando los grupos de formación comprendan trabajadores incluidos en diferentes  Códigos de Cuenta de Cotización de la misma empresa, las bonificaciones por la  totalidad del grupo o grupos de formación podrán aplicarse en los boletines de  cotización de cualquier Código de Cuenta de Cotización. <br />
                </p>
                <hr />
                <p>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  EMPRESA:&nbsp;");
#nullable restore
#line 31 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\Boni.cshtml"
                                                                                                 Write(Model.Nombre_Empresa);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\n                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Importe a bonificar:<strong>&nbsp;<span class=\"textoboni\">(</span></strong><span class=\"textoboni\"><strong>");
#nullable restore
#line 32 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\Boni.cshtml"
                                                                                                                                                                                                  Write(Model.creditodisponible);

#line default
#line hidden
#nullable disable
                WriteLiteral("€</strong>&nbsp;<strong>)</strong></span><br />\n                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Mes a bonificar:&nbsp;<strong>a partir de</strong>&nbsp;<span class=\"textoboni\"><strong>\n                    \n");
#nullable restore
#line 35 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\Boni.cshtml"
                      TimeSpan ts = new TimeSpan(35, 00, 00, 00, 00);
                        DateTime newdate = @Model.Fechafirma.Add(ts);
                        var mes = newdate.ToString("MM");
                        switch (mes)
                        {
                            case "01":
                                mes = "Enero";
                                break;
                            case "02":
                                mes = "Febrero";
                                break;
                            case "03":
                                mes = "Marzo";
                                break;
                            case "04":
                                mes = "Abril";
                                break;
                            case "05":
                                mes = "Mayo";
                                break;
                            case "06":
                                mes = "Junio";
                                break;
                            case "07":
                                mes = "Julio";
                                break;
                            case "08":
                                mes = "Agosto";
                                break;
                            case "09":
                                mes = "Septiembre";
                                break;
                            case "10":
                                mes = "Octubre";
                                break;
                            case "11":
                                mes = "Noviembre";
                                break;
                            case "12":
                                mes = "Diciembre";
                                break;
                        }
                        var mes2 = Model.Fechafirma.ToString("MM");
                        switch (mes2)
                        {
                            case "01":
                                mes2 = "Enero";
                                break;
                            case "02":
                                mes2 = "Febrero";
                                break;
                            case "03":
                                mes2 = "Marzo";
                                break;
                            case "04":
                                mes2 = "Abril";
                                break;
                            case "05":
                                mes2 = "Mayo";
                                break;
                            case "06":
                                mes2 = "Junio";
                                break;
                            case "07":
                                mes2 = "Julio";
                                break;
                            case "08":
                                mes2 = "Agosto";
                                break;
                            case "09":
                                mes2 = "Septiembre";
                                break;
                            case "10":
                                mes2 = "Octubre";
                                break;
                            case "11":
                                mes2 = "Noviembre";
                                break;
                            case "12":
                                mes2 = "Diciembre";
                                break;
                        }

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\Boni.cshtml"
                    Write(mes2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></span><strong>&nbsp;(*)</strong>&nbsp;(seguros sociales pagaderos en&nbsp;<strong class=\"textoboni\">");
#nullable restore
#line 118 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Contratos\Boni.cshtml"
                                                                                                                                       Write(mes);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong>).&nbsp;&nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                    <strong>(*) SI  SE HAN BONIFICADO ANTES DE ESTE MES, ROGAMOS SE PONGAN EN CONTACTO CON NOSOTROS  PUES, EN ESE CASO,  HABRÁN PRACTICADO UNA BONIFICACIÓN INDEBIDA.</strong> <br />
                    A continuación, se detalla la forma de aplicar estas bonificaciones, según el  medio de presentación:&nbsp;<u>Sistema&nbsp;</u><acronym>RED</acronym>&nbsp;o&nbsp;<u>papel  (TC2 normalizado)</u>. <br />
                    <br />
                    <u>SISTEMA RED</u> <br />
                    Los usuarios del sistema  RED comunicarán las bonificaciones por formación profesional continua en el  fichero FAN, en un segmento totalizador (EDTCA80). Este segmento totalizador no  está asociado a datos de trabajador. El importe de esta bonificación se  acumulará en el segmento EDTCA60 de &quot;suma de bonificaciones, subvenciones  y compensaciones&quot;.<br />
                    <br />
                 ");
                WriteLiteral(@"   Las empresas que transmitan a través del Sistema RED la relación nominal de  trabajadores y efectúen el ingreso de cuotas mediante documento de la serie TC1  (es decir, aquellas que no utilizan los sistemas de pago de cargo en cuenta o  pago electrónico, o cuya liquidación no resulte acreedora), deberán aplicar el  importe de la bonificación en la casilla 601 del TC1 de la liquidación normal  del mes que se trate. <br />
                    &nbsp;Cumplimentación del fichero FAN: <br />
                    <br />
                    Se crea una nueva clave de bonificación a nivel de datos  totalizadores: CA80 &quot;Bonificación&nbsp;<acronym>SPEE</acronym>&nbsp;formación  continua&quot;. <br />
                    <br />
                    &nbsp;&nbsp;Esta bonificación totalizará en el segmento EDTCA60  &quot;Suma de bonificaciones, subvenciones y compensaciones&quot;.<br />
                    CA60 = Sumatorio de EDLCD07 + EDLCD09 + EDLCD10 + EDLCD11 + EDLCD12 + EDLCD13 +  EDLCD16 + EDLCD18 + EDLCD19 + ED");
                WriteLiteral(@"TCA80.&nbsp; <br />
                    &nbsp;<br />
                    La clave CA80 sólo se admitirá en las liquidaciones L00. <br />
                    Por este sistema, la empresa se descontará, automáticamente, del  importe a pagar dicha bonificación, pagando por tanto menor cuantía en  seguridad social de ese mes. <br />
                    <br />
                    <u>TC2  NORMALIZADO.</u><br />
                    Si la cumplimentación se realiza por el sistema Normalizado, las  empresas deberán presentar un TC1 complementario que no llevará asociado ningún  documento TC2. Este documento estará codificado de la siguiente forma: a la  derecha, entre el cuadro para firmar la Administración y el cuadro para firmar  por la empresa, hay 3 cuadros con las iniciales CL&nbsp; C&nbsp; C, pues bien,  en ellas se debe poner 4&nbsp; 9&nbsp; 5, que significa: (CL) &ldquo;4:  complementaria&rdquo; y la clave de control (CC) &ldquo;95: Bonificaciones por Formación  Continua. La casilla 601 deberá contener el impo");
                WriteLiteral(@"rte de las Bonificaciones por  Formación Continua. Y en la casilla 800 el importe A PERCIBIR (que será el  mismo importe de la bonificación). En este TC1 complementario no deben aparecer  más datos económicos ni de ningún otro tipo. <br />
                    El importe de esta liquidación resultará siempre a percibir  debiéndose presentar en la Dirección Provincial de la Tesorería General de la  Seguridad Social o Administración correspondiente, dentro del plazo  reglamentario de presentación. <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                    <strong>NOTA: La  aplicación de la Bonificación en la cotización exigirá que la empresa se  encuentre al corriente de pago en sus obligaciones con Hacienda y de cotización  a la Seguridad Social, así como haber abonado el importe de la Formación a  EUROBRAZIL INVESTMENTS S.L.U.</strong>
                </p>
                <p>Sin más, confiando haberles servido de ayuda, aprovecho la ocasión  para en");
                WriteLiteral(@"viarles un cordial saludo. Asimismo, les indicamos que estamos a su  disposición para responder a cualquier reclamo o requerimiento que reciban por  parte de la Tesorería, INEM y/o Fundación Tripartita, por lo que rogamos nos  hagan conocedores de ello para actuar dentro del plazo que se ofrezca.  </p>
                <p>
                    Quedamos a su disposición para cualquier duda  o aclaración<br />
                    Saludos cordiales
                </p>
                <p> JORDI MUNTANÉ-PAVILLARD</p>
            </td>
        </tr>
    </table>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Plataforma.Models.Empresa> Html { get; private set; }
    }
}
#pragma warning restore 1591
