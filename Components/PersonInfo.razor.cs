using Microsoft.AspNetCore.Components;
using System.Net.Http;

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
            const string userId = "anonymous";
            var rating = new { PersonID = 1, UserID = userId, Rate = value };
            const string link = "https://people3api.azurewebsites.net/api/Ratings/";

            await Http.PostJsonAsync(link, rating);

        }
    }
}
