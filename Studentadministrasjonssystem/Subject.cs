using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    internal class Subject
    {
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int AmountOfPoints { get; set; }

        public Subject(string subjectCode, string subjectName, int amountOfPoints)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            AmountOfPoints = amountOfPoints;
        }

        public Subject()
        {

        }

        public void SkrivUtInfo()
        {
            List<Subject> subjects = new List<Subject>();
            Subject subject1 = new Subject("ENG330", "English Phonetics", 15);
            Subject subject2 = new Subject("SPAN250", "Spanish Grammar", 20);

            subjects.Add(subject1);
            subjects.Add(subject2);

            Console.WriteLine("Fag: ");

            foreach (Subject subject in subjects)
            {
                Console.WriteLine($"Fagkode: {subject.SubjectCode}, Fagnavn: {subject.SubjectName}, Studiepoeng: {subject.AmountOfPoints}");
            }
        }
    }
}

