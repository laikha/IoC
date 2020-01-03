using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    /// <summary>
    /// Class that a student is subscribed
    /// </summary>
    /// @author Ricardo Silva
    public class Student_Class
    {

        Student student;
        Class1 @class;

        public Student_Class(Student s, Class1 c)
        {
            student = s;
            @class = c;
        }

        public Student Student { get { return student; } set { student = value; } }

        public Class1 Class { get { return @class; } set { @class = value; } }

        public float Grade { get;set; }
    }
}
