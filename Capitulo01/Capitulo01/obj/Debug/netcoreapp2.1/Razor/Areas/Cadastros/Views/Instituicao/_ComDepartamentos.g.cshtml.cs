#pragma checksum "D:\AspNetCoreMVC\Capitulo01\Capitulo01\Areas\Cadastros\Views\Instituicao\_ComDepartamentos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e88593af6b57fe23e5e6b96b8fefa3f5365e8d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cadastros_Views_Instituicao__ComDepartamentos), @"mvc.1.0.view", @"/Areas/Cadastros/Views/Instituicao/_ComDepartamentos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Cadastros/Views/Instituicao/_ComDepartamentos.cshtml", typeof(AspNetCore.Areas_Cadastros_Views_Instituicao__ComDepartamentos))]
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
#line 1 "D:\AspNetCoreMVC\Capitulo01\Capitulo01\Areas\Cadastros\Views\_ViewImports.cshtml"
using Capitulo01;

#line default
#line hidden
#line 2 "D:\AspNetCoreMVC\Capitulo01\Capitulo01\Areas\Cadastros\Views\_ViewImports.cshtml"
using Capitulo01.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e88593af6b57fe23e5e6b96b8fefa3f5365e8d9", @"/Areas/Cadastros/Views/Instituicao/_ComDepartamentos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbbd315d6a61bbb8e2bff28440d44c4ec4b141e0", @"/Areas/Cadastros/Views/_ViewImports.cshtml")]
    public class Areas_Cadastros_Views_Instituicao__ComDepartamentos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Modelo.Cadastros.Departamento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 361, true);
            WriteLiteral(@"
<div class=""panel panel-primary"">
    <div class=""card-header text-white bg-warning text-center"">
        Relação de DEPARTAMENTOS registrados para a instituição
    </div>

    <div class=""panel-body"">
        <table class=""table table-striped table-hover"">
            <thead>
                <tr>
                    <th>
                        ");
            EndContext();
            BeginContext(413, 40, false);
#line 13 "D:\AspNetCoreMVC\Capitulo01\Capitulo01\Areas\Cadastros\Views\Instituicao\_ComDepartamentos.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(453, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 18 "D:\AspNetCoreMVC\Capitulo01\Capitulo01\Areas\Cadastros\Views\Instituicao\_ComDepartamentos.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(613, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(698, 39, false);
#line 22 "D:\AspNetCoreMVC\Capitulo01\Capitulo01\Areas\Cadastros\Views\Instituicao\_ComDepartamentos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(737, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 25 "D:\AspNetCoreMVC\Capitulo01\Capitulo01\Areas\Cadastros\Views\Instituicao\_ComDepartamentos.cshtml"
                }

#line default
#line hidden
            BeginContext(816, 127, true);
            WriteLiteral("                </tboby>\r\n        </table>\r\n    </div>\r\n    <div class=\"panel-footer panel-info\">\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Modelo.Cadastros.Departamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591