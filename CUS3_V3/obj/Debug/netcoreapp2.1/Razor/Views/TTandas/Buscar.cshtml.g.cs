#pragma checksum "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d99e30d2653552e169a6b75ff2ef9cddf1d2a82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TTandas_Buscar), @"mvc.1.0.view", @"/Views/TTandas/Buscar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TTandas/Buscar.cshtml", typeof(AspNetCore.Views_TTandas_Buscar))]
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
#line 1 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\_ViewImports.cshtml"
using CUS3_V3;

#line default
#line hidden
#line 2 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\_ViewImports.cshtml"
using CUS3_V3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d99e30d2653552e169a6b75ff2ef9cddf1d2a82", @"/Views/TTandas/Buscar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fceee47d528cd41cc38927592da629fb6bfa57a", @"/Views/_ViewImports.cshtml")]
    public class Views_TTandas_Buscar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CUS3_V3.Models.TTanda>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuscarT", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-info glyphicon glyphicon-check"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml"
  
    ViewData["Title"] = "Buscar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 291, true);
            WriteLiteral(@"
<h2>CALIFICAR</h2>
<div class=""row"">

    <div class=""panel panel-primary"">
        <div class=""panel-heading"">
            <div>
                <h4 class=""panel-title"">Eleccion de Tanda</h4>
            </div>
        </div>

        <div class=""panel panel-body form-group"">
");
            EndContext();
#line 19 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml"
             using (Html.BeginForm("Buscar1", "TTandas", FormMethod.Get))
            {
                

#line default
#line hidden
            BeginContext(564, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(580, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "206d0722111942b7993e62fab59816ff", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 22 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(646, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(650, 65, true);
            WriteLiteral("                <div class=\"row col-xs-12 col-md-12 col-lg-12\">\r\n");
            EndContext();
            BeginContext(766, 172, true);
            WriteLiteral("                    <div class=\"form-group  col-xs-12 col-md-12 col-lg-6\">\r\n                        <label class=\"control-label\">Nº Tanda:</label>\r\n                        ");
            EndContext();
            BeginContext(939, 18, false);
#line 28 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml"
                   Write(Html.TextBox("id"));

#line default
#line hidden
            EndContext();
            BeginContext(957, 368, true);
            WriteLiteral(@"

                        <span class=""text-danger""></span>
                    </div>
                    <div class=""form-group  col-xs-12 col-md-12 col-lg-6"">
                        <hr />
                        <input value=""Buscar1"" class=""btn btn-block btn-success"" />
                        <hr />
                    </div>
                </div>
");
            EndContext();
#line 38 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml"
                           
            }

#line default
#line hidden
            BeginContext(1369, 591, true);
            WriteLiteral(@"        </div>
    </div>
</div>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Tanda
            </th>
            <th>
                Modalidad
            </th>
            <th>
                Categoria
            </th>
            <th>
                Categoria
            </th>
            <th>
                Tipo Tanda
            </th>
            <th>
                Estado
            </th>
            <th>
                Fecha
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 72 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1992, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2041, 45, false);
#line 75 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml"
           Write(Html.DisplayFor(modelItem => item.PkItCodTan));

#line default
#line hidden
            EndContext();
            BeginContext(2086, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2142, 48, false);
#line 78 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml"
           Write(Html.DisplayFor(modelItem => item.VtDescripcion));

#line default
#line hidden
            EndContext();
            BeginContext(2190, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2246, 49, false);
#line 81 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml"
           Write(Html.DisplayFor(modelItem => item.VtDescripcion1));

#line default
#line hidden
            EndContext();
            BeginContext(2295, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2351, 44, false);
#line 84 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItGanador));

#line default
#line hidden
            EndContext();
            BeginContext(2395, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2451, 46, false);
#line 87 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml"
           Write(Html.DisplayFor(modelItem => item.VtTipoTanda));

#line default
#line hidden
            EndContext();
            BeginContext(2497, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2553, 43, false);
#line 90 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItEstado));

#line default
#line hidden
            EndContext();
            BeginContext(2596, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2652, 46, false);
#line 93 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml"
           Write(Html.DisplayFor(modelItem => item.DtFechaHora));

#line default
#line hidden
            EndContext();
            BeginContext(2698, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
            BeginContext(2992, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3008, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4237a306f554cc9a8c60bc3357b9701", async() => {
                BeginContext(3121, 9, true);
                WriteLiteral("Calificar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 99 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml"
                                          WriteLiteral(item.PkItCodTan);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3134, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 102 "C:\Users\Alexandra\Source\CUS3_V3\CUS3_V3\Views\TTandas\Buscar.cshtml"
}

#line default
#line hidden
            BeginContext(3173, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CUS3_V3.Models.TTanda>> Html { get; private set; }
    }
}
#pragma warning restore 1591
