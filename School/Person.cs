﻿namespace School
{
    /// <summary>
    /// This class is just for show how it works.
    /// It is a person to use in people
    /// </summary>
    /// @author Ricardo Silva
    public class Person : IoC.BasicClassInversion<Person>
    {
        public int? Id { get; set; }
#nullable enable
        public string? Name { get; set; }
        public int? Age { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Name}";
        }

    }
}
