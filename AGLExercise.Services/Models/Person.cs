﻿using System.Collections.Generic;


namespace AGLExercise.Services.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public IEnumerable<Pet> Pets { get; set;} 
    }
}
