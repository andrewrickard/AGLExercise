using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using AGLExercise.Services.Models;
using AGLExercise.Services.Interfaces;

namespace AGLExercise.Services
{
    public class PeopleService : IPeopleService
    {
        public const string apiUrl = "http://agl-developer-test.azurewebsites.net/people.json";

        public async Task<IEnumerable<Person>> GetPersonList()
        {
            IEnumerable<Person> personList = null;

            using (HttpClient client = new HttpClient())
            {

                try
                {

                    client.BaseAddress = new Uri(apiUrl);
                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                    client.DefaultRequestHeaders.Accept.Add(contentType);
                    var response = await client.GetAsync(client.BaseAddress);
                    response.EnsureSuccessStatusCode();

                    var result = response.Content.ReadAsStringAsync().Result;
                    personList = JsonConvert.DeserializeObject<IEnumerable<Person>>(result);

                }
                catch(Exception e)
                {
                    //log message or similar;
                    throw e;

                }
            }


            return personList;

        }
    }
}
