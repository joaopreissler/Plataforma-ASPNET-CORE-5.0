#pragma checksum "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22d2bc6836f8dbcc61b9ee45967cd45a837b1c19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empresas_Delete), @"mvc.1.0.view", @"/Views/Empresas/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d2bc6836f8dbcc61b9ee45967cd45a837b1c19", @"/Views/Empresas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"419e03b9f5afb17e76ff6540606c73c87f585a34", @"/Views/_ViewImports.cshtml")]
    public class Views_Empresas_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plataforma.Models.Empresa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Empresa</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre_Empresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre_Empresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre_Comercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre_Comercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nif));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nif));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Provincia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Provincia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Localidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Localidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DireccionComercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DireccionComercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CPComercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CPComercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProvinciaComercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProvinciaComercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LocalidadComercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LocalidadComercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CuentaCotizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CuentaCotizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.sector));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.sector));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.convenio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.convenio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.actividadprincial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.actividadprincial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CNAE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CNAE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Representacionlegal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Representacionlegal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.nuevacreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.nuevacreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.creditodisponible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.creditodisponible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Banco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Banco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cuenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cuenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.creacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 156 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.creacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 159 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.venta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 162 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.venta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 165 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombrereprensentante));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 168 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombrereprensentante));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 171 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Generorepresentante));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 174 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Generorepresentante));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 177 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.nifrepresentante));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 180 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.nifrepresentante));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 183 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fechafirma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 186 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fechafirma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 189 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.nombregestoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 192 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.nombregestoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 195 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.contatogestoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 198 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.contatogestoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 201 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.emailgestoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 204 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.emailgestoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 207 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.telefonogestoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 210 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.telefonogestoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 213 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 216 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22d2bc6836f8dbcc61b9ee45967cd45a837b1c1927737", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22d2bc6836f8dbcc61b9ee45967cd45a837b1c1928004", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 221 "C:\Users\João Victor\Desktop\Plataforma\Plataforma\Plataforma\Views\Empresas\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22d2bc6836f8dbcc61b9ee45967cd45a837b1c1929803", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
