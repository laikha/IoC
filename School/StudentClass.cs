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
            Student = s;
            Class = c;
        }

        public Student Student { get; set; }

        public ClassRoom Class { get; set; }

        public float Grade { get;set; }
    }
}
