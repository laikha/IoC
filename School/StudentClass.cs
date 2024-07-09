using IoC;

namespace School
{
    /// <summary>
    /// Class that a student is subscribed
    /// </summary>
    /// @author Ricardo Silva
    public class StudentClass : IoC.BasicClassInversion<StudentClass>
    {

        private IStudent student;
        private I4IoC<Room> classRoom;

        public StudentClass()
        {

        }

        public IStudent MyStudent
        {
            get
            {
                if (student == null)
                {

                    NotInitialized(typeof(Student));

                }

                return student;
            }
            set
            {
                student = value;
            }
        }

        public I4IoC<Room> MyClassRoom {
            get
            {
                if (classRoom == null)
                {

                    NotInitialized(typeof(Room));

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
