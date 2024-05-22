using System.Security.Cryptography.X509Certificates;

namespace Studentadministrasjonssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var student = new Student();
            student.SkrivUtInfo();
            
            

            var subject = new Subject();
            subject.SkrivUtInfo();
           
            var grade = new Grade();
            grade.SkrivUtInfo();
        }
    }
}
