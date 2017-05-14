using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AGLExercise.Services.Interfaces;
using AGLExercise.Services.Models;
using Autofac;

namespace AGLExercise.UnitTests
{
    [TestClass]
    public class BaseTest
    {
        protected IContainer container = null;
        protected IPeopleService peopleService;
        protected IGroupingService groupService;
        protected IEnumerable<Person> personList;

        [TestInitialize]
        public void Setup()
        {
            if (container == null)
            {
                container = BootStrapper.Configure();
            }

            if (peopleService == null || groupService == null)
            {
                peopleService = container.Resolve<IPeopleService>();
                groupService = container.Resolve<IGroupingService>();
            }

           

        }


    }
}
