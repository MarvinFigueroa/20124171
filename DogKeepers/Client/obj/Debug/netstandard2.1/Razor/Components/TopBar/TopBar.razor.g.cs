#pragma checksum "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\Components\TopBar\TopBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06d7dfb4a49919d6d74857d5a7619bf5f627c02e"
// <auto-generated/>
#pragma warning disable 1591
namespace DogKeepers.Client.Components.TopBar
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
#nullable restore
#line 1 "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\Components\TopBar\TopBar.razor"
using DogKeepers.Client.Components.SingIn;

#line default
#line hidden
#nullable disable
    public partial class TopBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row px-4");
            __builder.AddAttribute(2, "style", "z-index: 1;");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "btn-group");
            __builder.AddAttribute(6, "role", "group");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenComponent<DogKeepers.Client.Components.SingIn.SingInButton>(8);
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<button type=\"button\" class=\"btn btn-secondary\">Registrarse</button>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591