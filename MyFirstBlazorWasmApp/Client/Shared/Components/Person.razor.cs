using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace MyFirstBlazorWasmApp.Client.Shared.Components{

    public partial class Person{
        [Parameter] public List<string> Names { get; set; }
        [Parameter] public string GreetingMessage { get; set; }

        [Parameter] public RenderFragment LotPeople { get; set; }
        [Parameter] public RenderFragment Empty { get; set; }

        protected override void OnInitialized()
        {
            System.Console.WriteLine("OnInitialized");
        }

        protected override void OnParametersSet()
        {     
            System.Console.WriteLine("OnParametersSet");
        }

        protected override void OnAfterRender(bool firstRender)
        {
            System.Console.WriteLine($"OnAfterRender - Firts time: {firstRender}");
        }

        protected override bool ShouldRender()
        {
            System.Console.WriteLine("ShouldRender");
            return true;
        }
    }
}