using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Questions.Interfaces
{
    public interface IQuestionable
    {
        public  string QuestionHeader { get; set; }
        public int Mark { get; set; }
        public void SetQuestionHeaderAndSetMark(int i);
        public void SetTrueFalseQuestion();
        public void SetMulitpleChoicesQuestion();
    }
}
