using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    internal class Grade
    {
        public string StudentName { get; private set; }
        public string SubjectName { get; private set; }
        public int GradeValue { get; private set; }

        public Grade(string studentName, string subjectName, int gradeValue)
        {
            StudentName = studentName;
            SubjectName = subjectName;
            GradeValue = gradeValue;    
        }

        public Grade() 
        {
        
        }

        public void SkrivUtInfo()
        {
            List<Grade> grades = new List<Grade>();
            Grade grade1 = new Grade("Jonas", "English Phonetics", 6);
            Grade grade2 = new Grade("Per", "Spanish Grammar", 6);
            

            grades.Add(grade1);
            grades.Add(grade2);
            
            Console.WriteLine("Karakter: ");

             foreach (Grade grade in grades)
            {
                Console.WriteLine($"Studentnavn: {grade.StudentName}, Fagnavn: {grade.SubjectName}, Karakterverdi: {grade.GradeValue} ");
            }
        }
    }
}
