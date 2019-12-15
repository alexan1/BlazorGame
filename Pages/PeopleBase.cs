using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Http.HttpClient;
//using static System.Net.WebRequestMethods;
using Microsoft.AspNetCore.Blazor;

namespace BlazorGame.Pages 
{
    public class PeopleBase : ComponentBase
    {
        private Person[] people;

        protected override async Task OnInitializedAsync()
        {
            //people = await Http.GetJsonAsync<Person[]>("sample-data/people.json");
        }

        public class Person
        {
            public string Name { get; set; }

            public int Rating { get; set; }
        }
    }
}
