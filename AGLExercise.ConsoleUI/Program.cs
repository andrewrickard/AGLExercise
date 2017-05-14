using System;
using Autofac;

namespace AGLExercise.ConsoleUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            var container = BootStrapper.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            Console.ReadLine();
        }
    }
}
