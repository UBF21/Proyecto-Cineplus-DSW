#pragma checksum "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7d2236708714a6091b4d2c10d1aaa93d8190ac2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PeliculaGraphic_datos), @"mvc.1.0.view", @"/Views/PeliculaGraphic/datos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7d2236708714a6091b4d2c10d1aaa93d8190ac2", @"/Views/PeliculaGraphic/datos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6bfc7d95b8abc286b8bc3c57159846576b38980", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PeliculaGraphic_datos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cineplus_DSW_Proyecto.Models.Pelicula>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "datos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PeliculaGraphic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
  
    ViewData["Title"] = "datos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-12 mb-3"">

        <h1 class=""text-center"" style=""font-size:3rem;""> <span class=""badge badge-primary"">Cuadro de datos de Películas</span></h1>
    </div>

    <div class=""col-6 mt-2"">

        <h2> <span class=""font-weight-bold"">Datos del Cuadro Estadístico</span></h2>

        <p class=""mt-4"">
            <span>
                Este cuadro logra poder ver un panorama de la cantidad de
                películas dentro de la empresa de cine que existen en la <strong>B.D</strong> actualmente
                registrados.
                Al observar el cuadro se podran ver las películas repartidas
                en la estadistica dependiendo del tipo de película y asi podemos
                hacer una medición de los tipos de peliculas con mayor cantidad, permitiendo
                entender si existe una equidad tipos de peliculas o no.
            </span>
        </p>
    </div>

    <div class=""col-6"">
        <canvas id=""myChart"" width=""60"" he");
            WriteLiteral("ight=\"30\"></canvas>\r\n    </div>\r\n\r\n    <div class=\"col-12 mt-2 mb-2\">\r\n\r\n        <div class=\"col-12 mt-2 mb-2\">\r\n\r\n            <h3 class=\"text-center\"> <span class=\"badge badge-dark\" style=\"font-size:3rem;\">Listado de Películas</span></h3>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7d2236708714a6091b4d2c10d1aaa93d8190ac27077", async() => {
                WriteLiteral(@"

                <div class=""row justify-content-center"">
                    <div class=""col-lg-5"">
                        <div class=""input-group"">
                            <span class=""input-group-btn"">
                                <button class=""btn btn-outline-info"">Consultar!</button>
                            </span>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7d2236708714a6091b4d2c10d1aaa93d8190ac27714", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 48 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.peliculas;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div><!-- /input-group -->\r\n                    </div><!-- /.col-lg-6 -->\r\n                </div><!-- /.row -->\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <br />\r\n        </div>\r\n\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 61 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
                   Write(Html.DisplayNameFor(model => model.codPelicula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 64 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
                   Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 67 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
                   Write(Html.DisplayNameFor(model => model.descripcionTipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 70 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
                   Write(Html.DisplayNameFor(model => model.fechaEstreno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 73 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
                   Write(Html.DisplayNameFor(model => model.fechaFinal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 76 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
                   Write(Html.DisplayNameFor(model => model.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 81 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 85 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.codPelicula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 88 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 91 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.descripcionTipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 94 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
                       Write(item.fechaEstreno.ToString(string.Format("yyyy/MM/dd")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 97 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
                       Write(item.fechaFinal.ToString(string.Format("yyyy/MM/dd")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 100 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 103 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n\r\n        jQuery.ajax({\r\n            url: \'");
#nullable restore
#line 119 "C:\Users\FELIPE\source\repos\Cineplus_DSW_Proyecto\Cineplus_DSW_Proyecto\Views\PeliculaGraphic\datos.cshtml"
             Write(Url.Action("peliculaDatos","PeliculaGraphic"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
            type: ""Get"",
            dataType: ""json"",
            contentType: ""application/json; charset=utf-8"",
            success: function(data) {
                console.log(data);

                var arregloCantidad = [];
                var arregloTipo = [];
                for (let i = 0; i < data.length; i++) {
                    arregloCantidad.push(data[i].cantidad)
                    arregloTipo.push(data[i].tipo)
                }
                console.log(arregloCantidad);
                console.log(arregloTipo);



                const ctx = document.getElementById('myChart').getContext('2d');
                const myChart = new Chart(ctx, {
                    type: 'pie',
                    data: {
                        labels: arregloTipo,
                        datasets: [{
                            label: '# of Votes',
                            data: arregloCantidad,
                            backgroundColor: [
                              ");
                WriteLiteral(@"  'rgba(255, 99, 132, 0.3)',
                                'rgba(54, 162, 235, 0.3)',
                                'rgba(74, 142, 215, 0.3)',
                                'rgba(67, 155, 115, 0.3)'
                            ],
                            borderColor: [
                                'rgba(255, 99, 132, 1)',
                                'rgba(54, 162, 235, 1)',
                                'rgba(74, 142, 215, 1)',
                                'rgba(67, 155, 115, 1)'
                            ],
                            borderWidth: 1
                        }]
                    },
                    options: {
                        plugins: {

                            title: {
                                display: true,
                                text: ""Estadística de Peliculas"",
                                font: { size: ""25""}
                            }

                        },
                        scales: {
        ");
                WriteLiteral(@"                    y: {
                                beginAtZero: true
                            }
                        }
                    }
                });

            },
            error: function(error) {
                console.log(error)
            }
        });
    </script>
");
            }
            );
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
