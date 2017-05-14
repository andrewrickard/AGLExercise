using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AGLExercise.Services.Interfaces;
using AGLExercise.Services.Models;

namespace AGLExercise.ConsoleUI
{
    public class Application : IApplication
    {
        private IPeopleService _peopleService;
        private IGroupingService _groupService;

        public Application (IPeopleService peopleService, IGroupingService groupService)
        {
            _peopleService = peopleService;
            _groupService = groupService;
        }


        public async Task Run()
        {

            IEnumerable<Person> people = null;
            try
            {
                people = await _peopleService.GetPersonList();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception occurred :  { ex.Message}");
                return;
            }

            var result = _groupService.GetPetListByType(people, "Cat");

            foreach(var row in result)
            {
                Console.WriteLine(row.Key);
                foreach(var pet in row.Pets)
                {
                    Console.WriteLine(pet.Name);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Enter any key to exit");
        }

    }
}
