namespace School
{
    /// <summary>
    /// Class that a student is subscribed
    /// </summary>
    /// @author Ricardo Silva
    public class StudentClass : IoC.BasicClassInversion<StudentClass>
    {
        public StudentClass()
        {
            
        }

        private Student student;
        private ClassRoom classRoom;

        public Student MyStudent
        {
            get
            {
                if (student == null)
                {
                    throw new System.ArgumentNullException(nameof(student), "Student was not instantiated");
                }

                return student;
            }
            set
            {
                student = value;
            }
        }

        public ClassRoom MyClassRoom {
            get
            {
                if (classRoom == null)
                {
                    throw new System.ArgumentNullException(nameof(classRoom), "ClassRoom was not instantiated");
                    return classRoom;
                }

                return classRoom;
            }
            set
            {
                classRoom = value;
            }
        }

        public float Grade { get;set; }
    }
}
