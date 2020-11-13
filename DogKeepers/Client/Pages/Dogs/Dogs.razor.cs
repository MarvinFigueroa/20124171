using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using DogKeepers.Shared.DTOs;
using Microsoft.AspNetCore.Components;

namespace DogKeepers.Client.Pages.Dogs
{
    public partial class Dogs
    {
        [Inject] public HttpClient httpClient { get; set; }

        public List<DogDto> Dogslist { get; set; } = null;

        public bool IsLoadingDogsList { get; set; } = true;

        protected override async Task OnInitializedAsync()
        {
            await LoadDogs();
        }

        private async Task LoadDogs(){
            Dogslist = await httpClient.GetFromJsonAsync<List<DogDto>>("/api/dog/GetList");

            IsLoadingDogsList = false;
        }
    }
}