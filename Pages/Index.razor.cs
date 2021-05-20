using BlazorGame.Components;
using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WikiDataLib;
using System.Net.Http;
using System;

namespace BlazorGame.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        private HttpClient Http { get; set; }
        string _searchName;

        private Collection<WikiPerson> People { get; set; }
        private Collection<PersonR> PeopleR { get; set; } = new Collection<PersonR>();


        private async Task SearchPeople()
        {            
            People = await WikiData.WikiPeopleSearch(_searchName);
            const string linkbase = "https://peoplerating.azurewebsites.net/api/rating/";

            foreach (var pers in People)
            {                
                var link = linkbase + pers.Id.ToString();                
                Console.WriteLine("link  " + link);
                double? rating = await Http.GetJsonAsync<double>(link);
                Console.WriteLine("rating  " + rating);

                PeopleR.Add(new PersonR(pers, rating));
            }
        }
    }
}
