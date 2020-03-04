namespace School
{
    /// <summary>
    /// Class that a student is subscribed
    /// </summary>
    /// @author Ricardo Silva
    public class StudentClass
    {
        public StudentClass(Student s, ClassRoom c)
        {
            StudentProp = s ?? throw new System.ArgumentNullException(nameof(s), "Student is required");
            ClassRoomProp = c ?? throw new System.ArgumentNullException(nameof(c), "ClassRoom is required");
        }

        public Student StudentProp { get; set; }

        public ClassRoom ClassRoomProp { get; set; }

        public float Grade { get;set; }
    }
}
