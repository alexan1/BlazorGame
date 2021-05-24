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

        public async System.Threading.Tasks.Task RateAsync(int persinId, int value)
        {
            const string userId = "anonymous";
            var rating = new { PersonID = persinId, UserID = userId, Rate = value };
            const string link = "https://peoplerating.azurewebsites.net/api/rating/";

            await Http.SendJsonAsync(HttpMethod.Put, link, rating);

        }
    }
}
