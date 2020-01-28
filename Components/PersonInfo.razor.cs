using Microsoft.AspNetCore.Components;
using WikiDataLib;

namespace BlazorGame.Components
{
    public partial class PersonInfo : ComponentBase
    {
        [Parameter]
        public WikiPerson Person { get; set; }
    }
}
