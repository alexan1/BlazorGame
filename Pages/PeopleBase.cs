﻿using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.ObjectModel;

namespace BlazorGame.Pages
{
    public class PeopleBase : ComponentBase
    {

        [Inject]
        private HttpClient Http { get; set; }
        public Collection<Person> People { get; set; }

        protected override async Task OnInitializedAsync()
        {     

            People = await Http.GetJsonAsync<Collection<Person>>("https://people3api.azurewebsites.net/api/People");
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }

            //public int Rate { get; set; }
        }
    }
}
