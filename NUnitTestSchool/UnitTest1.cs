using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTestSchool
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Method intentionally left empty.
        }

        [Test]
        public void IsPersonProfessor()
        {
            IoC.I4IoC<School.Person> iProfessor = new IoC.BasicClassInversion<School.Professor>();

            string expected = "Professor";
            string returned = iProfessor.WhoAmI();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void IsPersonStudent()
        {
            IoC.I4IoC<School.Person> iStudent = new IoC.BasicClassInversion<School.Student>();

            string expected = "Student";
            string returned = iStudent.WhoAmI();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void IsPerson()
        {
            IoC.I4IoC<School.Person> iPerson = new IoC.BasicClassInversion<School.Person>();

            string expected = "Person";
            string returned = iPerson.WhoAmI();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void IsClass()
        {
            IoC.I4IoC<School.ClassRoom> iClass = new IoC.BasicClassInversion<School.ClassRoom>();

            string expected = "ClassRoom";
            string returned = iClass.WhoAmI();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void VerifyClass()
        {
            School.Professor professor = new School.Professor
            {
                Id = 6,
                Name = "Will"
            };

            School.ClassRoom classRoom = new School.ClassRoom
            {
                Description = "Game Developer",
                Id = 50,
                MinGradeForPass = 8f,
                Name = "GD5",
                Professor = professor
            };

            IoC.I4IoC<School.ClassRoom> iClass = new IoC.BasicClassInversion<School.ClassRoom>(classRoom);


            string expected = "50 - GD5 (6 - Will) - Game Developer";
            string returned = iClass.ToString();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void VerifyProfessor()
        {
            School.Professor professor = new School.Professor {
                Id = 10,
                Name = "Rick",
                Age = 43
            };

            IoC.I4IoC<School.Person> iProfessor = new IoC.BasicClassInversion<School.Professor>(professor);


            string expected = "10 - Rick";
            string returned = iProfessor.IoCClass().ToString();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void VerifyStudent()
        {
            School.Student student = new School.Student
            {
                Id = 11,
                Name = "Jack",
                Age = 60
            };

            IoC.I4IoC<School.Person> iStudent = new IoC.BasicClassInversion<School.Student>(student);

            string expected = "11 - Jack - 60";
            string returned = iStudent.ToString();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void VerifyPerson()
        {
            School.Person person = new School.Person
            {
                Id = 11,
                Name = "Jack",
                Age = 60
            };

            IoC.I4IoC<School.Person> iStudent = new IoC.BasicClassInversion<School.Person>(person) ;

            string expected = "11 - Jack";
            string returned = iStudent.IoCClass().ToString();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void VerifyGradeStudent()
        {
            List<School.ClassRoom> classes = new List<School.ClassRoom>
            {
                new School.ClassRoom
                {
                    Id = 1,
                    Description = "Class of History",
                    Name = "Hist1",
                    MinGradeForPass = 7f
                },
                new School.ClassRoom
                {
                    Id = 2,
                    Description = "Class of Biology",
                    Name = "Bio1",
                    MinGradeForPass = 6f
                },
                new School.ClassRoom
                {
                    Id = 3,
                    Description = "Class of Math",
                    Name = "Mth1",
                    MinGradeForPass = 8f
                }
            };
            
            School.Student student = new School.Student
            {
                Id = 1,
                Age = 15,
                Name = "Rick"
            };

            List<School.StudentClass> student_Classes = new List<School.StudentClass>
            {
               new  School.StudentClass()
                {
                    StudentProp = student, 
                    ClassRoomProp = classes[0],
                    Grade = 8.5f
                },

                new School.StudentClass()
                {
                    StudentProp = student,
                    ClassRoomProp = classes[1],
                    Grade = 6.5f
                }
                ,
                new School.StudentClass()
                {
                    StudentProp = student,
                    ClassRoomProp = classes[2],
                    Grade = 10f
                }
            };

            student.Classes = student_Classes;

            //IoC.I4IoC<School.Student> iStudent = new IoC.BasicClassInversion<School.Student>(student);

            //Need a review

            bool returned = student.IsAprooved();  //iStudent.GetInstantiatedClass().IsAprooved();

            Assert.IsTrue(returned);
        }

    }
}