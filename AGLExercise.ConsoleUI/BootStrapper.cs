using AGLExercise.Services;
using AGLExercise.Services.Interfaces;
using Autofac;


namespace AGLExercise.ConsoleUI
{
    public static class BootStrapper
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<PeopleService>().As<IPeopleService>();
            builder.RegisterType<GroupingService>().As<IGroupingService>();
            return builder.Build();
        }
    }
}
