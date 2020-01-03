using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    /// <summary>
    /// Class for class
    /// </summary>
    /// @author Ricardo Silva
    #nullable enable
    public class Class1
    {
        private float minGradeForPass = 7f;
        public Professor? Professor { get; set; }

        public int? Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        //Get the minimum grade for this class,
        //if it was not seted up than the value is 7f
        public float MinGradeForPass
        {
            get
            {
                return minGradeForPass;
            }
            set
            {
                minGradeForPass = value;
            }
        }

        public override string ToString()
        {
            return $"{Id} - {Name} ({Professor?.ToString()}) - {Description}";
        }
    }
}
