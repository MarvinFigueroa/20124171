#pragma checksum "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\Pages\Cares\Cares.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7077d56bca5868d8a095aa89a34b295cf622c99"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DogKeepers.Client.Pages.Cares
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\_Imports.razor"
using DogKeepers.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\_Imports.razor"
using DogKeepers.Client.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\_Imports.razor"
using DogKeepers.Client.Components.Loading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\_Imports.razor"
using DogKeepers.Client.Components.SectionPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cares")]
    public partial class Cares : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "c:\Users\DELL\Desktop\prueba\fix\20124171\DogKeepers\Client\Pages\Cares\Cares.razor"
            
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
