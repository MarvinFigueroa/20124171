#pragma checksum "C:\Users\DELL\Desktop\prueba\20124171\DogKeepers\Client\Pages\Dog\Dog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe612993c14fdb130797f7a4003d58e7079529c4"
// <auto-generated/>
#pragma warning disable 1591
namespace DogKeepers.Client.Pages.Dog
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Dog/{DogId:int}")]
    public partial class Dog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<DogKeepers.Client.Components.SectionPage.SectionPage>(0);
            __builder.AddAttribute(1, "PageName", "dog-page");
            __builder.AddAttribute(2, "Title", "Conoce a mi perrito");
            __builder.AddAttribute(3, "Hint", "No dejes pasar la oportunidad de hacer feliz a mi perrito");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.AddMarkupContent(6, "<div class=\"row banner\">\r\n        <div class=\"banner-image\" style=\"background-image: url(\'data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiA/Pjxzdmcgdmlld0JveD0iMCAwIDUxMiA1MTIiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHRpdGxlLz48ZyBpZD0iR29sZGVuX3JldHJpZXZlciI+PHBhdGggZD0iTTMwNi43Njc0LDIzNi4wOTE2Yy03LjIsMC01LjgxNCw3LjczLTcuMzY5MSwxMi4zOTI3YTE4Ljk3NjEsMTguOTc2MSwwLDAsMS0zNi41NDQyLTEuOTUyOCwxMS4wNzk0LDExLjA3OTQsMCwwLDAsMS44NzI3LTEuODYzM2wxNC40OTA2LTE4LjUzYzUuNTQ0MS03LjA5MjYuMzItMTcuNzc1LTguNjY1Ni0xNy43NzVIMjQxLjU2OWExMC45OTgyLDEwLjk5ODIsMCwwLDAtOC42NjQxLDE3Ljc3NWwxNC40OTIyLDE4LjUzdi4wMDE2YTExLjEwOTEsMTEuMTA5MSwwLDAsMCwxLjc4NTQsMS44MDdjLTMuNjE1OSwxNi44NDQ2LTI2Ljk1NjYsMjAuMTc4MS0zNS4yMSw1LjFhMTguOTYsMTguOTYsMCwwLDEtMS45MDYyLTUuMTYxM2MtLjQxODMtMS45NjgzLS4xMi00LjEyMjctLjc3ODctNi4wMmE2LjQ2LDYuNDYsMCwwLDAtOS4yNjQzLTMuNDNjLTYuNzc1MSwzLjk2NDQtMS43OTE3LDE2LjQ3ODcsMS4xNTM3LDIxLjUxNjhhMzIuMDgsMzIuMDgsMCwwLDAsMjEuMDU0NSwxNS4xNDEydjMzLjM2NWEzMS43Nzg5LDMxLjc3ODksMCwwLDAsNjMuNTU3OCwwdi0zMy4zNjVhMzIuMDcxOCwzMi4wNzE4LDAsMCwwLDIxLjA1NDUtMTUuMTQxMkMzMTEuODg0NSwyNTMuMjgxMSwzMTcuOTA2NSwyMzYuMDkxNiwzMDYuNzY3NCwyMzYuMDkxNlptLTUwLjc1NjIsODkuODc1YTE5LjAwMDYsMTkuMDAwNiwwLDAsMS0xOC45OC0xOC45NzgxVjI3My42MjM3YTMxLjgwNDIsMzEuODA0MiwwLDAsMCwxOC45OC0xMi4wODYyLDMxLjgwMiwzMS44MDIsMCwwLDAsMTguOTc4MSwxMi4wODZ2MzMuMzY1QTE5LDE5LDAsMCwxLDI1Ni4wMTEyLDMyNS45NjY2WiIvPjxwYXRoIGQ9Ik00MjUuMjg5MywxMDEuNjY4MiwzNjAuMjY3NCw2Ny4zNWEyNS4wMjEyLDI1LjAyMTIsMCwwLDAtMjcuNjQ4NCwyLjYwNDYsMjUuNjUsMjUuNjUsMCwwLDAtNS43Nzc3LDYuNTU5LDcwLjk4NDcsNzAuOTg0NywwLDAsMC0yOS40NDU3LTYuNDI3N2gtODIuNzdBNzAuOTk4OSw3MC45OTg5LDAsMCwwLDE4NS4xOCw3Ni41MTI1YTI1LjY1MTQsMjUuNjUxNCwwLDAsMC01Ljc3NjktNi41NTg0QTI1LjAyNzQsMjUuMDI3NCwwLDAsMCwxNTEuNzU0OSw2Ny4zNUw4Ni42NjQzLDEwMS43MDQxQzY1Ljc5NjgsMTEzLjA0MDYsNjEuNjE0OCwxNDAuMTYzMyw2My4xMjMyLDE2MS43M2MuMjQ2NiwzLjUyNjUuMjExNyw3Ljc3NDUsMy43OSw5LjcwMjVhNi4zODcsNi4zODcsMCwwLDAsNS43NjU3LjE1NjJsNy40NzM0LTMuNTJjLTEuNTg1OSw5Ljc0MjItMS45ODI4LDIzLjMxODgsMy42ODEzLDM2LjU3NjZhNi40LDYuNCwwLDAsMCw4LjQ3MTgsMy4zNDA2bDYuNjctMi45NDg0YzMuMzgyOSwxMS45MzI4LDEyLjIzOTEsMzUuNjQ1MywzMy41Myw2MC4xNDA2YTYuMzk5LDYuMzk5LDAsMCwwLDExLjAxMS0yLjU0MjJsLjEyODMtLjQ3ODdjLS4zNTgsMTcuODAxNC0yMy4xMjIzLDI3LjQ3OTUtMjMuMzM5MywyNy41NzA5YTYuMzk3NCw2LjM5NzQsMCwwLDAtMy4zOTM3LDguNTg3NWMuMzczLjgxMzcsOC4zMzM0LDE3LjcyNTYsMjUuMzMyOCwyMi44MzY1LTMuMDEsMTUuMjA4OC01Ljg5NzEsNTIsMjYuODgsODEuNzJhNi40MDA5LDYuNDAwOSwwLDAsMCw4Ljk0NjktLjM0MDZsMjAuMzM3NS0yMS40ODc1YzUuNDgxMiwxNC42MDYzLDE5LjQ4MTIsNDAuODM0NCw1My45Mzc1LDY1LjQxNTYuMDkyMS4wNjU5LjE5OTQuMDg2Ni4yOTM3LjE0NjdhNi4zMTU0LDYuMzE1NCwwLDAsMCwxLjE5NjcuNTk3OWMuMTY4NS4wNjMxLjMzLjEzNDUuNTAxNC4xODI2YTYuNDAyNyw2LjQwMjcsMCwwLDAsMS42OTA2LjI1ODhoLjA3YTYuNDA1OSw2LjQwNTksMCwwLDAsMS42OTEtLjI1OWMuMTcwOS0uMDQ3OS4zMzE1LS4xMTkyLjQ5OTItLjE4MThhNi4zMDQ2LDYuMzA0NiwwLDAsMCwxLjE5ODktLjU5ODdjLjA5NDEtLjA2LjIwMTMtLjA4MDguMjkzMy0uMTQ2NSwzNC40NTYzLTI0LjU4MTIsNDguNDU2My01MC44MDkzLDUzLjkzOTEtNjUuNDE1NmwyMC4zMzc1LDIxLjQ4NzVhNi4zOTc5LDYuMzk3OSwwLDAsMCw4Ljk0NjkuMzQwNmMzMi43OTQxLTI5LjczNjEsMjkuODg2MS02Ni41NTE5LDI2Ljg3NDQtODEuNzQ0NywxNi45MzE2LTUuMTQ1NywyNC44NTk0LTIxLjk5OTQsMjUuMjMxOC0yMi44MTE1YTYuNDExNCw2LjQxMTQsMCwwLDAtMy4zOC04LjU4MjhjLS4yMzA4LS4wOTYxLTIyLjk4NjEtOS43NzExLTIzLjM1MDktMjcuNTY3MmwuMTI1OS40N2E2LjM5OSw2LjM5OSwwLDAsMCwxMS4wMTEsMi41NDIyYzIxLjI5MDYtMjQuNDk1MywzMC4xNDY4LTQ4LjIwNzgsMzMuNTMtNjAuMTM5MWw2LjY2ODcsMi45NDY5YTYuNDAxMSw2LjQwMTEsMCwwLDAsOC40NzM0LTMuMzQwNmM1LjY2NDEtMTMuMjU3OCw1LjI2NzItMjYuODM0NCwzLjY4MTMtMzYuNTc2Nmw3LjQ3MzQsMy41MmE2LjM5NjcsNi4zOTY3LDAsMCwwLDUuNzY1Ny0uMTU2MmMzLjI4MTQtMS43NjgzLDMuNDMzNS01LjI3ODgsMy42OTkzLTguNTEzOWExMDYuMzAzOCwxMDYuMzAzOCwwLDAsMCwuMjg3NC0xMi4yMDg4Yy0uMzgyNC0xMS41ODA5LTIuNTI3OC0yMy41Nzk0LTguMzg0OC0zMy43MjE0QTQwLjA0NDQsNDAuMDQ0NCwwLDAsMCw0MjUuMjg5MywxMDEuNjY4MlpNMTM0LjQxNzQsMjQ3LjE0Yy0yMC40MDMxLTI3LjUwNDctMjQuNjM3NS01MS44MjE5LTI0LjY4LTUyLjA4MTNhNi40MDM4LDYuNDAzOCwwLDAsMC0zLjI2NC00LjYwNjIsNi40ODQ1LDYuNDg0NSwwLDAsMC01LjY0MDYtLjIzbC03LjMxODgsMy4yMzQ0Yy00LjQ4NTktMTcuMzY4OCwyLjA3ODEtMzQuNDIxOSwyLjE0ODQtMzQuNTk4NWE2LjQsNi40LDAsMCwwLTguNjcxOC04LjE2MjVsLTExLjMwNDcsNS4zMjY2Yy0uMjU0Ny0xMi40OTM4LDEuNjItMzQuNjY4OCwxNy4wMi00My4wMzU5TDE1Ny43Myw3OC42NjgyYTEyLjU1MzEsMTIuNTUzMSwwLDAsMSwxNy45ODQ0LDE0LjM1VjkzLjAyWm0yNDUuODMsNTEuMDY0Yy0zLjQ1NzgsNC42NzY2LTkuNzA0NywxMC44OTU0LTE4Ljc2NTYsMTEuNTUzMmE2LjM4ODMsNi4zODgzLDAsMCwwLTUuMjQyLDkuMjY4OWMxLjc0NjEsNi4wNjUzLDEwLjE2NDMsNDAuOTM0Mi0xNy4zNTQ5LDY5Ljk4NDJsLTIzLjUxNzItMjQuODQ2OWE2LjQwMDksNi40MDA5LDAsMCwwLTEwLjk3LDMuNDAzMWMtLjA1NDcuMzQzNC01Ljc4MjYsMzMuNzYxLTQ4LjMzNCw2NS43NDI0LTQyLjIxNzItMzEuNzU2LTQ4LjI4LTY1LjQyMzQtNDguMzMzMi02NS43NDI0YTYuNDAwOCw2LjQwMDgsMCwwLDAtMTAuOTctMy40MDMxTDE3My4yNDI0LDM4OS4wMWMtMjkuNTU0Ny0zMS4xOTg0LTE3LjY1NjItNjkuMTI2Ni0xNy4wOTA2LTcwLjg1OTQuMDE1OC0uMDQ3OC4wMTc2LS4wOTY1LjAzMjItLjE0NDVhNi40MDU0LDYuNDA1NCwwLDAsMCwuMTU2NS0uNzAxMmMuMDM1MS0uMTg5LjA3NzktLjM3NjIuMDk1OS0uNTY0OC4wMDQzLS4wNDY3LjAyLS4wODk1LjAyMzItLjEzNjQuMDEwOC0uMTQ4Ni0uMDEyNy0uMjktLjAxMjEtLjQzNzNhNi40MDI3LDYuNDAyNywwLDAsMC0uMDItLjcwMTljLS4wMjE3LS4yMDQ1LS4wNjY0LS40LS4xMDY5LS41OTg0LS4wNDE5LS4yMDQ5LS4wOC0uNDA4Ni0uMTQxMi0uNjA3N2E2LjI4MzgsNi4yODM4LDAsMCwwLS4yMy0uNTkyOWMtLjA3NzMtLjE4MzQtLjE1MDktLjM2NjEtLjI0NDktLjU0MTQtLjA5ODYtLjE4MzQtLjIxNC0uMzUzMi0uMzI5NS0uNTI1NC0uMTEzOC0uMTcwOS0uMjI1LS4zNDEyLS4zNTUyLS41MDA4LS4xMjY4LS4xNTQ5LS4yNjgyLS4yOTM4LS40MDg2LS40MzYzYTYuMjc0NCw2LjI3NDQsMCwwLDAtLjQ1ODItLjQzNzVjLS4xNi0uMTMyOS0uMzMzMS0uMjQ1OS0uNTA1Ny0uMzYyOS0uMTY4NC0uMTE0MS0uMzMyNi0uMjMwNS0uNTEzNy0uMzI4OWE2LjM4ODQsNi4zODg0LDAsMCwwLS42MzQ1LS4yODVjLS4xMzYtLjA1NTktLjI1ODEtLjEzMjItLjQtLjE4LS4wNDUxLS4wMTUtLjA5MS0uMDE2Ni0uMTM2MS0uMDMwNWExMy43ODQxLDEzLjc4NDEsMCwwLDAtMS4yODc1LS4yNTY4Yy0uMDQ2NS0uMDA0My0uMDg4OS0uMDItLjEzNTctLjAyMzYtOC45Ny0uNjUxNi0xNS4yNDY5LTYuODkwNy0xOC43Mzc1LTExLjU3LDkuMjEwOS01LjM5MDcsMjQuNjczNC0xNy4yOTM4LDI0LjY3MzQtMzYuNDQzOFYyMTQuMjY1MWwzMS42LTExNy45MzEzYTI1Ljg5NTcsMjUuODk1NywwLDAsMCwuODc5My03LjQ3OTEsNTguMTY2Miw1OC4xNjYyLDAsMCwxLDI1LjY2OTEtNS45NjkzaDgyLjc3YTU4LjE3MDksNTguMTcwOSwwLDAsMSwyNS42NjkzLDUuOTY4MiwyNS44NzE2LDI1Ljg3MTYsMCwwLDAsLjg3OTEsNy40Nzg3bDMxLjYwMTYsMTE3LjkzODN2NDcuNDcyNkMzNTUuNTQ1NiwyODAuOTE1MSwzNzEuMDQwOSwyOTIuODIyOSwzODAuMjQ3MSwyOTguMjA0MVptNTYuMDY4OC0xNDIuMTkwNi0xMS4yODYtNS4zMTcyYTYuNCw2LjQsMCwwLDAtOC42NzE4LDguMTYyNWMuMDc1LjE4OTEsNi42OTUzLDE3LjE0MjIsMi4xNTQ2LDM0LjZsLTcuMzIxOC0zLjIzNTlhNi40LDYuNCwwLDAsMC04LjkwNjMsNC44MzU5Yy0uMDQzNy4yNjg4LTQuMTQ4NCwyNC40NTYzLTI0LjY4LDUyLjA4NzVMMzM2LjMwNjUsOTMuMDJjLTIuNzgzNy0xMC4zOSw4LjQ0NDUtMTkuMzg2OSwxNy45ODU5LTE0LjM1MTZsNjQuOTU0NywzNC4yODI4QzQzNC42MywxMjEuMzA4OCw0MzYuNTQ0LDE0My41MDczLDQzNi4zMTU5LDE1Ni4wMTM1WiIvPjxwYXRoIGQ9Ik0yMTkuOTM1NiwxNzIuOTY2NnYtMTAuMTM5YTE0LjQsMTQuNCwwLDAsMC0yOC44LDB2MTAuMTM5YTE0LjQsMTQuNCwwLDAsMCwyOC44LDBaIi8+PHBhdGggZD0iTTMwNi41ODU2LDE0OC40Mjc2YTE0LjQxNjksMTQuNDE2OSwwLDAsMC0xNC40LDE0LjR2MTAuMTM5YTE0LjQsMTQuNCwwLDEsMCwyOC44LDB2LTEwLjEzOUExNC40MTcsMTQuNDE3LDAsMCwwLDMwNi41ODU2LDE0OC40Mjc2WiIvPjwvZz48L3N2Zz4=\'); background-color: #eaeaea;\">\r\n\r\n        </div>\r\n    </div>\r\n    ");
                __builder2.AddMarkupContent(7, "<div class=\"row mt-3\">\r\n        <section class=\"col-12 col-md-8 order-2 order-md-1\">\r\n            <div class=\"row\">\r\n                <ul class=\"col-12 list-group list-group-horizontal text-center\">\r\n                    <li class=\"list-group-item col\">\r\n                        <small>Edad</small>\r\n                        <span>5</span>\r\n                    </li>\r\n                    <li class=\"list-group-item col\">\r\n                        <small>Raza</small>\r\n                        <span>Doverman</span>\r\n                    </li>\r\n                    <li class=\"list-group-item col\">\r\n                        <small>Talla</small>\r\n                        <span>Grande</span>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"row p-3\">\r\n                <h5>\r\n                    Descripción\r\n                </h5>\r\n                <p class=\"text-justify\">\r\n                    \"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"\r\n                </p>\r\n            </div>\r\n            <div class=\"row p-3\">\r\n                <h5>\r\n                    Condiciones\r\n                </h5>\r\n                <p class=\"text-justify\">\r\n                    \"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"\r\n                </p>\r\n            </div>\r\n        </section>\r\n        <section class=\"col-12 col-md-4 order-1 order-md-2\">\r\n            <div class=\"card shadow mb-5\">\r\n                <div class=\"card-body p-3 text-center\">\r\n                    <button class=\"btn btn-info btn-lg\">\r\n                        Adoptar\r\n                    </button>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </div>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591