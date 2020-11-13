using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using DogKeepers.Shared.DTOs;
using Microsoft.AspNetCore.Components;

namespace DogKeepers.Client.Pages.Index
{
    public partial class Index
    {
        [Inject] private HttpClient httpClient { get; set; }

        private List<DogDto> DogList { get; set; } = null;

        private bool IsLoadingDogSuggestions { get; set; } = true;

        protected override async Task OnInitializedAsync(){
            await Task.Delay(5000);
            await LoadSuggestions();
        }

        private async Task LoadSuggestions(){
            DogList = await httpClient.GetFromJsonAsync<List<DogDto>>("/api/dog/GetList?random=3");

            IsLoadingDogSuggestions = false;
        }

    }
    
}