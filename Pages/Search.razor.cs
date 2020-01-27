using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WikiDataLib;

namespace BlazorGame.Pages
{
    public partial class Search : ComponentBase
    {
        string SearchName;

        private Collection<WikiPerson> People { get; set; }
              

        private async void SearchPeople()
        {            
            People = await WikiData.WikiPeopleSearch(SearchName);
        }
    }
}
