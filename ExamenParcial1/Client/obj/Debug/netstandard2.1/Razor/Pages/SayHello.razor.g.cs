#pragma checksum "C:\Users\DELL\Desktop\ProgramacionWeb\ExamenParcial1\Client\Pages\SayHello.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29e46fabb4e4acb3d357c476611185e9be0151ea"
// <auto-generated/>
#pragma warning disable 1591
namespace ExamenParcial1.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/SayHello")]
    public partial class SayHello : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"text-center mt-5\">Hello! :)\r\n</h2>\r\n");
            __builder.AddMarkupContent(1, "<h4 class=\"text-center text-muted\">\r\n    Let´s say hello to all\r\n</h4>\r\n");
            __builder.AddMarkupContent(2, @"<div class=""row mb-5"">
    <div class=""col-12"">
        <nav class=""navbar nabvar-light bg-light p-3"">
            <div class=""input-group input-group-lg"">
                <input type=""text"" class=""form-control form control-lg"" Placeholder=""Type a name"">
                <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                    <button type=""button"" class=""btn btn-secondary"">Lets say hi</button>
                    <button type=""button"" class=""btn btn-primary"">Go next</button>
                </div>
            </div>
        </nav>
        <div class=""text-center"">
                <div class=""alert alert-warning"" role=""alert"">
                    Nobody to say hello:(
            </div>
        </div>
    </div>
</div>
");
            __builder.AddMarkupContent(3, "<div class=\"row\">\r\n    <div class=\"col\">\r\n\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591