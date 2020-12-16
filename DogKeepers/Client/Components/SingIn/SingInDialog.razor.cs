using System.Threading.Tasks;
using DogKeepers.Shared.QueryFilters;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace DogKeepers.Client.Components.SingIn
{
    public partial class SingInDialog
    {
        [Inject] private DialogService dialogService { get; set; }
        private bool isLoading = false;
        private SingInQueryFilter user = new SingInQueryFilter();

        private async Task SingIn(){
            await Task.Delay(300);
            System.Console.WriteLine(user.Email);
            System.Console.WriteLine(user.Password);
        }
    }
}