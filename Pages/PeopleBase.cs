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

            People = await Http.GetJsonAsync<Person[]>("https://people3api.azurewebsites.net/api/People");
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }

            //public int Rate { get; set; }
        }
    }
}
