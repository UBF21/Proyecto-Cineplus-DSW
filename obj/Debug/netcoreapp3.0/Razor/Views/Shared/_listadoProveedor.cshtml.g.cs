#pragma checksum "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoProveedor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18d2f42cab53f3d869cff12f29abb95c3dc52845"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__listadoProveedor), @"mvc.1.0.view", @"/Views/Shared/_listadoProveedor.cshtml")]
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
#line 1 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\_ViewImports.cshtml"
using Cineplus_DSW_Proyecto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\_ViewImports.cshtml"
using Cineplus_DSW_Proyecto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18d2f42cab53f3d869cff12f29abb95c3dc52845", @"/Views/Shared/_listadoProveedor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6bfc7d95b8abc286b8bc3c57159846576b38980", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__listadoProveedor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cineplus_DSW_Proyecto.Models.Proveedor>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<table class=\"table table-striped table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 8 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoProveedor.cshtml"
           Write(Html.DisplayNameFor(model => model.idProveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoProveedor.cshtml"
           Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoProveedor.cshtml"
           Write(Html.DisplayNameFor(model => model.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoProveedor.cshtml"
           Write(Html.DisplayNameFor(model => model.direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>Acciones</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoProveedor.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 27 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoProveedor.cshtml"
               Write(Html.DisplayFor(modelItem => item.idProveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoProveedor.cshtml"
               Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoProveedor.cshtml"
               Write(Html.DisplayFor(modelItem => item.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoProveedor.cshtml"
               Write(Html.DisplayFor(modelItem => item.direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoProveedor.cshtml"
               Write(Html.ActionLink("Editar", "editar", new {  id=item.idProveedor  },new {@class="btn btn-outline-info font-weight-bold"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     ");
#nullable restore
#line 40 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoProveedor.cshtml"
                Write(Html.ActionLink("Delete", "eliminar", new {  id=item.idProveedor  },new {@class="btn btn-outline-danger font-weight-bold"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoProveedor.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cineplus_DSW_Proyecto.Models.Proveedor>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
