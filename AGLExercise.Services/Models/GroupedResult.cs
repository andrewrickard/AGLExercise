using System.Collections.Generic;


namespace AGLExercise.Services.Models
{
    public class GroupedResult
    {
        public string Key { get; set; }
        public IEnumerable<Pet> Pets { get; set; }

    }
}
