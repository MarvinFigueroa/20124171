#pragma checksum "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\Pages\Cares\Cares.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7077d56bca5868d8a095aa89a34b295cf622c99"
// <auto-generated/>
#pragma warning disable 1591
namespace DogKeepers.Client.Pages.Cares
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\_Imports.razor"
using DogKeepers.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\_Imports.razor"
using DogKeepers.Client.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\_Imports.razor"
using DogKeepers.Client.Components.Loading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\_Imports.razor"
using DogKeepers.Client.Components.SectionPage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cares")]
    public partial class Cares : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container\">\r\n    <div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <ol class=\"carousel-indicators\">\r\n            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"0\" class=\"active\"></li>\r\n            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"1\"></li>\r\n            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"2\"></li>\r\n            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"3\"></li>\r\n            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"4\"></li>\r\n            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"5\"></li>\r\n            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"6\"></li>\r\n            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"7\"></li>\r\n            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"8\"></li>\r\n            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"9\"></li>\r\n\r\n        </ol>\r\n        <div class=\"carousel-inner\">\r\n            <div class=\"carousel-item  active\">\r\n                <img class=\"d-block w-100\" src=\"Images/D1.jpg\" alt=\"0\">\r\n                <div class=\"carousel-caption d-none d-md-block\">\r\n                    <h5>CUIDADOS GENERALES</h5>\r\n                    <p>Collar ligero de lona sín ganchos e ir cambiando como va creciendo con plaquita de\r\n                        identificación: nombre, dirección y teléfono, y/o chip-tatuaje.</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <img class=\"d-block w-100\" src=\"Images/D1.jpg\" alt=\"1\">\r\n                <div class=\"carousel-caption d-none d-md-block\">\r\n                    <h5>CUIDADOS GENERALES</h5>\r\n                    <p>Desparasitar recién llegado y cada 6 meses aprox.</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <img class=\"d-block w-100\" src=\"Images/D1.jpg\" alt=\"2\">\r\n                <div class=\"carousel-caption d-none d-md-block\">\r\n                    <h5>CUIDADOS GENERALES</h5>\r\n                    <p>Tener agua limpia disponible siempre (24 horas al día).</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <img class=\"d-block w-100\" src=\"Images/D1.jpg\" alt=\"3\">\r\n                <div class=\"carousel-caption d-none d-md-block\">\r\n                    <h5>CUIDADOS GENERALES</h5>\r\n                    <p>Bañar como máximo 1 vez cada 2 semanas, en promedio.</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <img class=\"d-block w-100\" src=\"Images/D1.jpg\" alt=\"4\">\r\n                <div class=\"carousel-caption d-none d-md-block\">\r\n                    <h5>CUIDADOS GENERALES</h5>\r\n                    <p>Vacunarlo y no pasearlo en áreas públicas hasta terminar con todas. Después del año, la séxtuple cada siguiente.</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <img class=\"d-block w-100\" src=\"Images/D1.jpg\" alt=\"5\">\r\n                <div class=\"carousel-caption d-none d-md-block\">\r\n                    <h5>CUIDADOS GENERALES</h5>\r\n                    <p>La esterilización es fundamental por seguridad y responsabilidad. Recordar no hacerlo hasta pasar 15 días después de su última vacuna. Después de los 6 meses de edad.</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <img class=\"d-block w-100\" src=\"Images/D1.jpg\" alt=\"6\">\r\n                <div class=\"carousel-caption d-none d-md-block\">\r\n                    <h5>CUIDADOS GENERALES</h5>\r\n                    <p>¡No golpes!, aprenden asociando ideas y diciendo “¡No!” o “¡Bien!” (cambio tono de voz y actitud) Recompensas y cariños, como premios (pedacitos de salchicha, tocinetas, palmadas, etc.).</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <img class=\"d-block w-100\" src=\"Images/D1.jpg\" alt=\"7\">\r\n                <div class=\"carousel-caption d-none d-md-block\">\r\n                    <h5>CUIDADOS GENERALES</h5>\r\n                    <p>Comer cuatro veces al día o más.</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <img class=\"d-block w-100\" src=\"Images/D1.jpg\" alt=\"8\">\r\n                <div class=\"carousel-caption d-none d-md-block\">\r\n                    <h5>CUIDADOS GENERALES</h5>\r\n                    <p>Destinar juguetes lugar especial: limpiar, cambiar y guardar, carnaza, pelotas rellenables “Kongs”, trapos, cuerdas, mordederas etc.</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <img class=\"d-block w-100\" src=\"Images/D1.jpg\" alt=\"9\">\r\n                <div class=\"carousel-caption d-none d-md-block\">\r\n                    <h5>CUIDADOS GENERALES</h5>\r\n                    <p>Salir a pasear con correa y placa de identificación por lo menos 2 veces al día, por salud, limpieza y reconocimiento de su territorio (chip, tatuaje).</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <a id=\"carouselExampleIndicators-prev\" class=\"carousel-control-prev\" role=\"button\" data-slide=\"prev\">\r\n            <span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\r\n            <span class=\"sr-only\">Previous</span>\r\n        </a>\r\n        <a id=\"carouselExampleIndicators-next\" class=\"carousel-control-next\" role=\"button\" data-slide=\"next\">\r\n            <span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n            <span class=\"sr-only\">Next</span>\r\n        </a>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\Pages\Cares\Cares.razor"
            
    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await
                JsRuntime.InvokeAsync<object>("initializeCarousel"); firstRender = false;
        }
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
