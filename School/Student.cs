using System.Collections.Generic;
using System.Linq;

namespace School
{
    /// <summary>
    /// Class for student
    /// </summary>
    /// @author Ricardo Silva
    public class Student : Person, IStudent
    {
        //His classes
        public List<StudentClass> Classes { get; set; }

        public bool IsAprooved()
        {
            //Count grades that not pass
            var x = from c in Classes
                    where c.Grade < c.MyClassRoom.MinGradeForPass
                    select c;

            //if it has none is fail
            return !x.Any();
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Age}";
        }
    }
}
