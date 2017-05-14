using System;
using System.Collections.Generic;
using System.Linq;
using AGLExercise.Services.Models;
using AGLExercise.Services.Interfaces;

namespace AGLExercise.Services
{
    public class GroupingService : IGroupingService
    {
        public IEnumerable<GroupedResult> GetPetListByType(IEnumerable<Person> people, string type)
        {
            var result = from p in people
                         where p.Pets != null
                         group p.Pets by p.Gender into g
                         select new GroupedResult { Key = g.Key, Pets = g.SelectMany(c => c).Where(c => c.Type == type).OrderBy(c=>c.Name).ToList() };

            return result.ToList();   
        }
    }
}
