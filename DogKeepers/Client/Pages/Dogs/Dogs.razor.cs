using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using DogKeepers.Shared.ApiResponses;
using DogKeepers.Shared.DTOs;
using DogKeepers.Shared.Metadata;
using DogKeepers.Shared.QueryFilters;
using Microsoft.AspNetCore.Components;

namespace DogKeepers.Client.Pages.Dogs
{
    public partial class Dogs
    {
        [Inject] public HttpClient httpClient { get; set; }


        private int TotalDogs = 0;

        private List<DogDto> Dogslist = null;

        private bool IsLoadingDogsList = true;
        private PaginationMetadata PaginationData;
        private List<SizeDto> Sizes = new List<SizeDto>();

        private List<RaceDto> Races = new List<RaceDto>();

        private DogsQueryFilter Filters = new DogsQueryFilter();

        protected override async Task OnInitializedAsync()
        {
            await LoadDogs();
            await LoadSizes();
            await LoadRaces();
        }

        private async Task LoadDogs(bool search = false){

            Dogslist = null;

            IsLoadingDogsList = true;

            Filters.PageNumberForce = PaginationData == null || search
                ?   1
                :   Filters.PageNumber;

            var filterString = $"?pageNumber={Filters.PageNumber}&pageSize=8&Name={Filters.Name}&SizeId={Filters.SizeId}&RaceId={Filters.RaceId}";

            var response = await httpClient.GetFromJsonAsync<ApiResponse<List<DogDto>>>($"/api/dog/GetList{filterString}");

            Dogslist = response.Data;
            PaginationData = response.Pagination;
            TotalDogs = response.Pagination.TotalCount;

            IsLoadingDogsList = false;
        }

        private async Task LoadSizes(){
            Sizes =
                await httpClient.GetFromJsonAsync<List<SizeDto>>("/api/size");
        }

        private async Task LoadRaces(){
            Races =
                await httpClient.GetFromJsonAsync<List<RaceDto>>("/api/race");
        }

        private async Task OnSelectedPage(int pageNumberClicked){

            Filters.PageNumberForce = pageNumberClicked;

            await LoadDogs();

        }

        private async Task OnSearch(){
            await LoadDogs(true);
        }

    }
}