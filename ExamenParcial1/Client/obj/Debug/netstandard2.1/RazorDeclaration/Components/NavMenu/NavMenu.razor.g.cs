#pragma checksum "C:\Users\DELL\Desktop\ProgramacionWeb\ExamenParcial1\Client\Components\NavMenu\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86b38806f05b256a32eda102565092041f582085"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ExamenParcial1.Client.Components.NavMenu
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DELL\Desktop\ProgramacionWeb\ExamenParcial1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\ProgramacionWeb\ExamenParcial1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DELL\Desktop\ProgramacionWeb\ExamenParcial1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\Desktop\ProgramacionWeb\ExamenParcial1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DELL\Desktop\ProgramacionWeb\ExamenParcial1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DELL\Desktop\ProgramacionWeb\ExamenParcial1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DELL\Desktop\ProgramacionWeb\ExamenParcial1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DELL\Desktop\ProgramacionWeb\ExamenParcial1\Client\_Imports.razor"
using ExamenParcial1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DELL\Desktop\ProgramacionWeb\ExamenParcial1\Client\_Imports.razor"
using ExamenParcial1.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\DELL\Desktop\ProgramacionWeb\ExamenParcial1\Client\Components\NavMenu\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
