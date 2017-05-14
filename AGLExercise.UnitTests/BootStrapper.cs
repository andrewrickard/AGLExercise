using AGLExercise.Services;
using AGLExercise.Services.Interfaces;
using Autofac;


namespace AGLExercise.UnitTests
{
    public static class BootStrapper
    {

        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MockPeopleService>().As<IPeopleService>();
            builder.RegisterType<GroupingService>().As<IGroupingService>();
            return builder.Build();
        }







    }
}
