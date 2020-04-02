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

        private Student studentProp;
        private ClassRoom classRoomProp;

        public Student StudentProp
        {
            get
            {
                if (studentProp == null)
                {
                    throw new System.ArgumentNullException(nameof(studentProp), "Student was not instantiated");
                }

                return studentProp;
            }
            set
            {
                studentProp = value;
            }
        }

        public ClassRoom ClassRoomProp {
            get
            {
                if (classRoomProp == null)
                {
                    throw new System.ArgumentNullException(nameof(classRoomProp), "ClassRoom was not instantiated");
                    return classRoomProp;
                }

                return classRoomProp;
            }
            set
            {
                classRoomProp = value;
            }
        }

        public float Grade { get;set; }
    }
}
