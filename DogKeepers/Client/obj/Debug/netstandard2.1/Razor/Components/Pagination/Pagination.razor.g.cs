#pragma checksum "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\Components\Pagination\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41b46625d5209977649641412b67c71db6f12ba9"
// <auto-generated/>
#pragma warning disable 1591
namespace DogKeepers.Client.Components.Pagination
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
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "Page navigation example");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pagination");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 3 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\Components\Pagination\Pagination.razor"
         foreach (var link in Links)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\Components\Pagination\Pagination.razor"
                          () => OnSelectPage(link)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "page-item" + " " + (
#nullable restore
#line 5 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\Components\Pagination\Pagination.razor"
                                                                       link.IsEnabled ? null : "disabled"

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 5 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\Components\Pagination\Pagination.razor"
                                                                                                             link.IsActive ? "active" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "style", "cursor: : pointer;");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "class", "page-link");
            __builder.AddAttribute(14, "href", "javascript: void(0);");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.AddContent(16, 
#nullable restore
#line 7 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\Components\Pagination\Pagination.razor"
                     link.Text

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 10 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\Components\Pagination\Pagination.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
