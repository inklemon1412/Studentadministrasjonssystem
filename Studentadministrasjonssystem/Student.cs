using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    internal class Student
    {
  
        
            public string StudentName { get; private set; }

            public int Age { get; private set; }
            public string StudyProgram { get; private set; }
            public int StudentID { get; private set; }
            public Student(string studentName, int age, string studyProgram, int studentId)
            {
                StudentName = studentName;
                Age = age;
                StudyProgram = studyProgram;
                StudentID = studentId;
            }
        

        public Student()
        {

        }

        public void SkrivUtInfo()
        {
          
                List<Student> students = new List<Student>();
                Student student1 = new Student("Jonas", 27, "Engelsk Bachelor", 48);
                Student student2 = new Student("Per", 20, "Spansk Master", 51);
                


            students.Add(student1);
            students.Add(student2);
         

            Console.WriteLine("Studenter:");

                foreach (Student student in students)
                {
                Console.WriteLine($"Navn: {student.StudentName}, Alder: {student.Age}, Studieprogram: {student.StudyProgram}, Student ID: {student.StudentID}");
                }
            }
        }
    }
