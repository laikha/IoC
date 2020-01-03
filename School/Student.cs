using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace School
{
    /// <summary>
    /// Class for student
    /// </summary>
    /// @author Ricardo Silva
    public class Student : Person
    {
        //His classes
        public List<Student_Class> Classes { get; set; }

        public bool IsAprooved()
        {
            //Count grades that not pass
            var x = from c in Classes
                    where c.Grade < c.Class.MinGradeForPass
                    select c;

            //if it has one so fail
            return x.Count() == 0;
        }
    }
}
