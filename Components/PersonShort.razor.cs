using Microsoft.AspNetCore.Components;
using WikiDataLib;

namespace BlazorGame.Components
{
    public partial class PersonShort : ComponentBase
    {
        [Parameter]
        public WikiPerson Person { get; set; }
    }
}
