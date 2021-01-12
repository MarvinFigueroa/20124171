using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace ExamenParcial2.Client.Pages
{
    public partial class BreakingBad
    {
        [Inject] private HttpClient httpClient { get; set; }

        List<Quote> Datos = new List<Quote>();
        public bool IsLoading { get; set; } = true;

        private async Task GetQuote(){
            IsLoading = true;
            currentCount ++;
            await Task.Delay(1000);
            Datos = await httpClient.GetFromJsonAsync<List<Quote>>("https://breakingbadapi.com/api/quotes/"+currentCount);
            IsLoading = false;
        }

        private async Task GetPrevious(){
            IsLoading = true;
            currentCount --;
            await Task.Delay(1000);
            Datos = await httpClient.GetFromJsonAsync<List<Quote>>("https://breakingbadapi.com/api/quotes/"+currentCount);
            IsLoading = false;
        }

        protected override async Task OnInitializedAsync(){
            Datos = await httpClient.GetFromJsonAsync<List<Quote>>("https://breakingbadapi.com/api/quotes/1");
            IsLoading = false;
        }

        public class Quote {
            public int quote_id { get; set; } = 0;
            public string quote { get; set; } = "";
            public string author { get; set; } = "";
            public string series { get; set; } = "";
        }
    }
}