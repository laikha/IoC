using NUnit.Framework;
using School;
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
        public void Test_ProfessorWhoAmI()
        {
            IoC.I4IoC<School.Person> iProfessor = new  IoC.BasicClassInversion<School.Professor>();

            string expected = "Professor";
            string returned = iProfessor.WhoAmI();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void Test_StudentWhoAmI()
        {
            IoC.I4IoC<School.Person> iStudent = new IoC.BasicClassInversion<School.Student>();

            string expected = "Student";
            string returned = iStudent.WhoAmI();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void Test_PersonWhoAmI()
        {
            IoC.I4IoC<School.Person> iPerson = new School.Person();

            string expected = "Person";
            string returned = iPerson.WhoAmI();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void Test_ClassWhoAmI()
        {
            IoC.I4IoC<School.ClassRoom> iClass = new School.ClassRoom();

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

            string expected = "50 - GD5 (6 - Will) - Game Developer";
            string returned = classRoom.ToString();

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

            string expected = "10 - Rick";
            string returned = professor.ToString();

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

            string expected = "11 - Jack - 60";
            string returned = student.ToString();

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

            string expected = "11 - Jack";
            string returned = person.ToString();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void Test_IsAprooved()
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
                    MyStudent = student, 
                    MyClassRoom = classes[0],
                    Grade = 8.5f
                },

                new School.StudentClass()
                {
                    MyStudent = student,
                    MyClassRoom = classes[1],
                    Grade = 6.5f
                }
                ,
                new School.StudentClass()
                {
                    MyStudent = student,
                    MyClassRoom = classes[2],
                    Grade = 10f
                }
            };

            student.Classes = student_Classes;

            bool returned = student.IsAprooved();
            
            Assert.IsTrue(returned);
        }

    }
}