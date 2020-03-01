using BlazorGame.Pages;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using WikiDataLib;

namespace BlazorGame.Components
{
    public partial class PersonInfo : ComponentBase
    {
        [Parameter]
        public PersonR Person { get; set; }

        [Inject]
        private HttpClient Http { get; set; }

        public async System.Threading.Tasks.Task RateAsync(int value)
        {
            var userID = "anonymous";
            var rating = new { PersonID = 1, UserID = userID, Rate = value };
            var link = "https://people3api.azurewebsites.net/api/Ratings/";

            await Http.PostJsonAsync(link, rating);

        }
    }
}
