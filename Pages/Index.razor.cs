using BlazorGame.Components;
using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WikiDataLib;
using System.Net.Http;
using System.Collections.Generic;

namespace BlazorGame.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        private HttpClient Http { get; set; }
        string SearchName;

        private Collection<WikiPerson> People { get; set; }
        private Collection<PersonR> PeopleR { get; set; }


        private async Task SearchPeople()
        {            
            People = await WikiData.WikiPeopleSearch(SearchName);

            foreach (var pers in People)
            {
                var rating = await Http.GetJsonAsync<double>("https://people3api.azurewebsites.net/api/Ratings" + pers.Id);

                PeopleR.Add(new PersonR(pers, rating));
            }
        }
    }
}
