using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    /// <summary>
    /// This class is just for show how it works.
    /// It is a person to use in people
    /// </summary>
    /// @author Ricardo Silva
    public class Person
    {

        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public new virtual string ToString()
        {
            return $"{Id} - {Name}";
        }

    }
}
