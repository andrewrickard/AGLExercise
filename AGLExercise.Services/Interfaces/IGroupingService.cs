using System;
using System.Collections.Generic;
using AGLExercise.Services.Models;


namespace AGLExercise.Services.Interfaces
{
    public interface IGroupingService 
    {
        IEnumerable<GroupedResult> GetPetListByType(IEnumerable<Person> people, string type);
    }
}
