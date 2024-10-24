using System;
using System.Collections.Generic;
using System.Linq;

namespace OCP.Task1

{
    public class Student
    {
        public string Name { get; set; }

        public List<Evaluation> Results { get; set; }

        public bool IsEngineeringStudent { get; set; }

        public Student(string name, List<Evaluation> results, bool isEngineeringStudent)
        {
            Name = name;
            IsEngineeringStudent = isEngineeringStudent;
            Results = results;
        }

        public double Evaluate()
        {
            if (IsEngineeringStudent)
            {
                Results.ForEach(x => x.SubjectGrade = x.Exam * 0.50 + x.Homeworks * 0.20 + x.Project * 0.30);
                return Math.Round(Results.Average(x => x.SubjectGrade), 1);
            }
            else
            {
                //Arts Student
                Results.ForEach(x => x.SubjectGrade = x.Project * ((x.Homeworks > 10) ? 0.60 : 0.40) + x.Exam);
                return Math.Round(Results.Average(x => x.SubjectGrade), 1);
            }
        }
    }
}
