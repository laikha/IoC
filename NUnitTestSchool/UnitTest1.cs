using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTestSchool
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void IsPersonProfessor()
        {
            IoC.I4IoC<School.Professor> iProfessor = new IoC.BasicClassInjection<School.Professor>();

            string expected = "Professor";
            string returned = iProfessor.WhoAmI();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void IsPersonStudent()
        {
            IoC.I4IoC<School.Student> iStudent = new IoC.BasicClassInjection<School.Student>();

            string expected = "Student";
            string returned = iStudent.WhoAmI();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void IsPerson()
        {
            IoC.I4IoC<School.Person> iPerson = new IoC.BasicClassInjection<School.Person>();

            string expected = "Person";
            string returned = iPerson.WhoAmI();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void IsClass()
        {
            IoC.I4IoC<School.Class1> iClass = new IoC.BasicClassInjection<School.Class1>();

            string expected = "Class1";
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

            School.Class1 @class = new School.Class1
            {
                Description = "Game Developer",
                Id = 50,
                MinGradeForPass = 8f,
                Name = "GD5",
                Professor = professor
            };

            IoC.I4IoC<School.Class1> iClass = new IoC.BasicClassInjection<School.Class1>(@class);

            string expected = "50 - GD5 (6 - Will) - Game Developer";
            string returned = iClass.GetInstantiatedClass().ToString();

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

            IoC.I4IoC<School.Professor> iProfessor = new IoC.BasicClassInjection<School.Professor>(professor);


            string expected = "10 - Rick";
            string returned = iProfessor.GetInstantiatedClass().ToString();

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

            IoC.I4IoC<School.Student> iStudent = new IoC.BasicClassInjection<School.Student>(student);


            string expected = "11 - Jack";
            string returned = iStudent.GetInstantiatedClass().ToString();

            Assert.IsTrue(expected == returned, "Expected: {0} Returned: {1}", expected, returned);
        }

        [Test]
        public void VerifyGradeStudent()
        {
            List<School.Class1> classes = new List<School.Class1>
            {
                new School.Class1
                {
                    Id = 1,
                    Description = "Class of History",
                    Name = "Hist1",
                    MinGradeForPass = 7f
                },
                new School.Class1
                {
                    Id = 2,
                    Description = "Class of Biology",
                    Name = "Bio1",
                    MinGradeForPass = 6f
                }
            };
            
            School.Student student = new School.Student
            {
                Id = 1,
                Age = 15,
                Name = "Rick"
            };

            List<School.Student_Class> student_Classes = new List<School.Student_Class>
            {
               new  School.Student_Class(student, classes[0])
                {
                    Grade = 8.5f
                },

                new School.Student_Class(student, classes[1])
                {
                    Grade = 6.5f
                }
            };

            student.Classes = student_Classes;

            IoC.I4IoC<School.Student> iStudent = new IoC.BasicClassInjection<School.Student>(student);


            bool returned = iStudent.GetInstantiatedClass().IsAprooved();

            Assert.IsTrue(returned);
        }

    }
}