using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Questions.Interfaces
{
    public interface IExamable
    {
        public int SubjectID { get; set; }
        
        public string SubjectName { get; set; }
        public int ExamTime { get; set; }
        public void ImplementExam();
        public void ShowExam();
        public void ShowExamResult();
    }
}
