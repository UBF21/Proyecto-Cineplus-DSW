#pragma checksum "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7d809fb4867ede08ea81616253e9d1173b14eaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__listadoPelicula), @"mvc.1.0.view", @"/Views/Shared/_listadoPelicula.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7d809fb4867ede08ea81616253e9d1173b14eaf", @"/Views/Shared/_listadoPelicula.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6bfc7d95b8abc286b8bc3c57159846576b38980", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__listadoPelicula : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cineplus_DSW_Proyecto.Models.Pelicula>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
  
    ViewData["Title"] = "_listadoPelicula";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table table-striped table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
           Write(Html.DisplayNameFor(model => model.codPelicula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
           Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
           Write(Html.DisplayNameFor(model => model.tipoPelicula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
           Write(Html.DisplayNameFor(model => model.fechaEstreno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
           Write(Html.DisplayNameFor(model => model.fechaFinal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
           Write(Html.DisplayNameFor(model => model.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>Acciones</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
 foreach (var item in Model) {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
           Write(Html.DisplayFor(modelItem => item.codPelicula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
           Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"text-center\"> \r\n                ");
#nullable restore
#line 43 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
           Write(Html.DisplayFor(modelItem => item.tipoPelicula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
           Write(item.fechaEstreno.ToString(string.Format("yyyy-MM-dd")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               ");
#nullable restore
#line 49 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
          Write(item.fechaFinal.ToString(string.Format("yyyy-MM-dd")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"text-center\">\r\n                ");
#nullable restore
#line 52 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
           Write(Html.DisplayFor(modelItem => item.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
           Write(Html.ActionLink("Editar", "editar", new { id=item.codPelicula},new {@class = "btn btn-outline-info font-weight-bold"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\Shared\_listadoPelicula.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cineplus_DSW_Proyecto.Models.Pelicula>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
