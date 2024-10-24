using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OCP.Task1
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void EvaluateEngineeringStudentTest()
        {
            var expected = 7.3;

            var student = new Student("Jane Doe", new List<Evaluation>() {
                    new Evaluation(){ Subject = "Algebra", Exam = 6, Homeworks = 8, Project = 7},
                    new Evaluation(){ Subject = "Physics", Exam = 8, Homeworks = 4, Project = 5},
                    new Evaluation(){ Subject = "Chemistry", Exam = 10, Homeworks = 6, Project = 9}
                }, true
            );
            Assert.AreEqual(student.Evaluate(), expected);

        }

        [TestMethod]
        public void EvaluateArtsStudentTest()
        {
            var expected = 8.8;
            var student = new Student("John Doe", new List<Evaluation>() {
                    new Evaluation(){ Subject = "Paint", Project = 9, Homeworks = 6, Exam = 6},
                    new Evaluation(){ Subject = "Poetry", Project = 7, Homeworks = 8, Exam = 4},
                    new Evaluation(){ Subject = "Dance", Project = 5, Homeworks = 10, Exam = 8},
                }, false
            );
            Assert.AreEqual(student.Evaluate(), expected);
        }

    }
}
