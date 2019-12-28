using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using System.Net.Http;


namespace BlazorGame.Pages
{
    public class PeopleBase : ComponentBase
    {

        [Inject]
        private HttpClient Http { get; set; }
        public Person[] People { get; set; }

        protected override async Task OnInitializedAsync()
        {     

            People = await Http.GetJsonAsync<Person[]>("sample-data/people.json");
        }

        public class Person
        {
            public string Name { get; set; }

            public int Rating { get; set; }
        }
    }
}
