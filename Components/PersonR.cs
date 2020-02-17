using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WikiDataLib;

namespace BlazorGame.Components
{
    public class PersonR
    {
        public PersonR(WikiPerson person, double? rating)
        {
            Person = person;
            Rating = rating;
        }
        public WikiPerson Person { get; set; }
        public double? Rating { get; set; }
    }
}
