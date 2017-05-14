using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AGLExercise.Services.Interfaces;
using AGLExercise.Services.Models;

namespace AGLExercise.UnitTests
{
    public class MockPeopleService : IPeopleService
    {
        public async Task<IEnumerable<Person>> GetPersonList()
        {
            var list = new List<Person>()
            {
                new Person {Name="Bob",Gender="Male",Age=23,Pets=new List<Pet>()
                {
                    new Pet { Name="Garfield",Type="Cat"},
                    new Pet { Name="Fido",Type="Dog"}
                }},
                new Person {Name="Jennifer",Gender="Female",Age=18,Pets=new List<Pet>()
                {
                    new Pet { Name="Garfield",Type="Cat"}
                }},
                new Person {Name="Steve",Gender="Male",Age=45,Pets=null },
                new Person {Name="Fred",Gender="Male",Age=40,Pets=new List<Pet>()
                {
                    new Pet { Name="Tom",Type="Cat"},
                    new Pet { Name="Max",Type="Cat"},
                    new Pet { Name="Sam",Type="Dog"},
                    new Pet { Name="Jim",Type="Cat"}
                }},
                new Person {Name="Samantha",Gender="Female",Age=40,Pets=new List<Pet>()
                {
                    new Pet { Name="Tabby",Type="Cat"}
                }},
                new Person {Name="Alice",Gender="Female",Age=64,Pets=new List<Pet>()
                {
                    new Pet { Name="Simba",Type="Cat"},
                    new Pet { Name="Nemo",Type="Fish"}
                }}

            };

            await Task.Delay(1);


            return list;
        }
    }
}
