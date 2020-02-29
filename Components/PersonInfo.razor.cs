using BlazorGame.Pages;
using Microsoft.AspNetCore.Components;
using WikiDataLib;

namespace BlazorGame.Components
{
    public partial class PersonInfo : ComponentBase
    {
        [Parameter]
        public PersonR Person { get; set; }

        public void Rate(int value)
        {
            var userID = "anonymous";
            var rating = new Rating();// { PersonId = 1;  }
            var linkbase = "https://people3api.azurewebsites.net/api/Ratings/";
        }
    }
}
