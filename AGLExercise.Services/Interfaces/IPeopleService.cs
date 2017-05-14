using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AGLExercise.Services.Models;

namespace AGLExercise.Services.Interfaces
{
    public interface IPeopleService
    {
        Task<IEnumerable<Person>> GetPersonList();



    }
}
