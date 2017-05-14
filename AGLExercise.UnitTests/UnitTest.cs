using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AGLExercise.Services.Models;


namespace AGLExercise.UnitTests
{
    [TestClass]
    public class UnitTest : BaseTest
    {

        [TestMethod]
        public  void Test_Grouping_Should_Have_EmptyResult()
        {
            //empty person list
            personList = new List<Person>();
            var result = groupService.GetPetListByType(personList, "Cat").ToList();

            Assert.AreEqual(result.Count,0,"Result should be empty list");
        }


        [TestMethod]
        public async Task Test_Grouping_Should_Allow_NullPetLists()
        {

            personList = await peopleService.GetPersonList();

            //null each persons Pet property
            foreach(var person in personList)
            {
                person.Pets = null;
            }

            var result = groupService.GetPetListByType(personList, "Cat").ToList();
            Assert.AreEqual(result.Count(), 0, "Result should be empty list");
        }



        [TestMethod]
        public  async Task Test_Grouping_Should_Have_EmptyPetList() 
        {

            personList = await peopleService.GetPersonList();
            var result = groupService.GetPetListByType(personList, "Hamster").ToList();
            var petCount = result[0].Pets.Count();

            Assert.AreEqual(petCount, 0, "Result should be empty Pet list");
        }

        [TestMethod]
        public async Task Test_Grouping_Should_Retrieve_OnePet_ByType()
        {

            personList = await peopleService.GetPersonList();
            var result = groupService.GetPetListByType(personList, "Fish").ToList();
            var petCount = result[1].Pets.Count();

            Assert.AreEqual(petCount, 1, "Result should be 1 Pet in Female list");
        }


        [TestMethod]
        public async Task Test_Grouping_Should_Retrieve_CorrectPetCount()
        {

            personList = await peopleService.GetPersonList();
            var result = groupService.GetPetListByType(personList, "Dog").ToList();
            var dogCount = (from d in result
                        from g in d.Pets
                        select g).Count();

            Assert.AreEqual(dogCount, 2, "Result should be 2 Dogs in total");
        }

        [TestMethod]
        public async Task Test_Grouping_Should_OrderBy_PetName()
        {

            personList = await peopleService.GetPersonList();
            var result = groupService.GetPetListByType(personList, "Cat").ToList();

            var firstMalePet = result[0].Pets.First();
            var lastMalePet = result[0].Pets.Last();

            var firstFemalePet = result[1].Pets.First();
            var lastFemalePet = result[1].Pets.Last();


            Assert.AreEqual(firstMalePet.Name, "Garfield", "First Pet in Male list should equal Garfield");
            Assert.AreEqual(lastMalePet.Name, "Tom", "Last Pet in Male list should equal Tom");
            Assert.AreEqual(firstFemalePet.Name, "Garfield", "First Pet in Female list should equal Garfield");
            Assert.AreEqual(lastFemalePet.Name, "Tabby", "Last Pet in Male list should equal Tabby");

        }


    }
}
