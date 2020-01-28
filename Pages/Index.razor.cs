using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Collections.ObjectModel;

namespace BlazorGame.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        private HttpClient Http { get; set; }
        protected Collection<Person> People { get; set; }

        protected override async Task OnInitializedAsync()
        {

            People = await Http.GetJsonAsync<Collection<Person>>("https://people3api.azurewebsites.net/api/People");
        }

        protected class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }

            //public int Rate { get; set; }
        }
    }
}
