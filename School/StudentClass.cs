using IoC;

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

        private IStudent student;
        private I4IoC<ClassRoom> classRoom;

        public IStudent MyStudent
        {
            get
            {
                if (student == null)
                {

                    NotInitialized();

                }

                return student;
            }
            set
            {
                student = value;
            }
        }

        public I4IoC<ClassRoom> MyClassRoom {
            get
            {
                if (classRoom == null)
                {

                    NotInitialized();

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
