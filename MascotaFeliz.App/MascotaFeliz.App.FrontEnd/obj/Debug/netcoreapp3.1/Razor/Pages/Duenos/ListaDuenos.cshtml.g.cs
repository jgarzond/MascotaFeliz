#pragma checksum "C:\Mascotas\MascotaFeliz.App\Mascotafeliz.app.frontend\Pages\Duenos\ListaDuenos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8589578a59cff3ac261e0ed8b7305522a4cf93e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.FrontEnd.Pages.Duenos.Pages_Duenos_ListaDuenos), @"mvc.1.0.razor-page", @"/Pages/Duenos/ListaDuenos.cshtml")]
namespace MascotaFeliz.App.FrontEnd.Pages.Duenos
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
#line 1 "C:\Mascotas\MascotaFeliz.App\Mascotafeliz.app.frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8589578a59cff3ac261e0ed8b7305522a4cf93e9", @"/Pages/Duenos/ListaDuenos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e968b00c86c979a2fd0e0516e812d0f8c887b71b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Duenos_ListaDuenos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Lista de Dueños</h1>\r\n<h2>Aqui va la lista de los dueños</h2>\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>Nombres</td>\r\n        <td>Apellidos</td>\r\n        <td>Direccion</td>\r\n        <td>Telefono</td>\r\n        <td>Correo</td>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Mascotas\MascotaFeliz.App\Mascotafeliz.app.frontend\Pages\Duenos\ListaDuenos.cshtml"
     foreach (var dueno in Model.listaDuenos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\Mascotas\MascotaFeliz.App\Mascotafeliz.app.frontend\Pages\Duenos\ListaDuenos.cshtml"
           Write(dueno.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Mascotas\MascotaFeliz.App\Mascotafeliz.app.frontend\Pages\Duenos\ListaDuenos.cshtml"
           Write(dueno.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Mascotas\MascotaFeliz.App\Mascotafeliz.app.frontend\Pages\Duenos\ListaDuenos.cshtml"
           Write(dueno.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Mascotas\MascotaFeliz.App\Mascotafeliz.app.frontend\Pages\Duenos\ListaDuenos.cshtml"
           Write(dueno.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Mascotas\MascotaFeliz.App\Mascotafeliz.app.frontend\Pages\Duenos\ListaDuenos.cshtml"
           Write(dueno.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Mascotas\MascotaFeliz.App\Mascotafeliz.app.frontend\Pages\Duenos\ListaDuenos.cshtml"
           Write(dueno.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <!--<td><a class=\"btn btn-primary table-btn\" asp-page=\".\\DetallesDuenos\" asp-route-duenoID=\"");
#nullable restore
#line 24 "C:\Mascotas\MascotaFeliz.App\Mascotafeliz.app.frontend\Pages\Duenos\ListaDuenos.cshtml"
                                                                                                   Write(dueno.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    Detalle Dueño\r\n                </a></td>-->\r\n    </tr>\r\n");
#nullable restore
#line 28 "C:\Mascotas\MascotaFeliz.App\Mascotafeliz.app.frontend\Pages\Duenos\ListaDuenos.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.FrontEnd.Pages.ListaDuenosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.FrontEnd.Pages.ListaDuenosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.FrontEnd.Pages.ListaDuenosModel>)PageContext?.ViewData;
        public MascotaFeliz.App.FrontEnd.Pages.ListaDuenosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591