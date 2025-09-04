using ConsoleApp1.Questions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Questions.Classes
{
    public class Practical : IExamable
    {
        private DateTime examStartTime;
        private TimeSpan allowedTime;
        private int FinalMark;
        public int ExamTime { get; set; }
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public BaseQuestion[] questions;
        public Practical(int examTime, int questionCount , int Answerscount , string Name , int ID)
        {
            SubjectID = ID;
            SubjectName = Name;
            ExamTime = examTime;
            questions = new BaseQuestion[questionCount];
            for(int i = 0; i< questions.Length; i++)
            {
                questions[i] = new BaseQuestion()
                {
                    AnswersList = new Answers[Answerscount]
                };
                for(int j = 0; j < Answerscount; j++)
                {
                    questions[i].AnswersList[j] = new Answers();
                }
            }
        }

        public virtual void ImplementExam()
        {
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i].SetQuestionHeaderAndSetMark(i + 1);

                Console.WriteLine("Chocies of Question.");

                if (questions[i].AnswersList is not null)
                {
                    questions[i].SetMulitpleChoicesQuestion();
                }
                Console.Clear();
            }
        }
        public void ShowExam()
        {
            examStartTime = DateTime.Now;
            allowedTime = TimeSpan.FromMinutes(ExamTime);

            for (int i = 0; i < questions.Length; i++)
            {
                if (DateTime.Now - examStartTime > allowedTime)
                {
                    Console.WriteLine("Exam time is over. The exam has ended.");
                    break;
                }

                Console.WriteLine($"\tQuestion Number {i + 1}");
                Console.WriteLine($"{questions[i].QuestionHeader} [Contains {questions[i].Mark} Marks]");
                for (int j = 0; j < questions[i].AnswersList.Length; j++)
                {
                    Console.WriteLine($"{questions[i].AnswersList[j].AnswerId} : {questions[i].AnswersList[j].AnswerText}");
                }
                Console.Write("Enter Your Answer : ");
                int userAnswer;
                do
                {
                    if (DateTime.Now - examStartTime > allowedTime)
                    {
                        Console.WriteLine("Exam time is over. The exam has ended.");
                        return;
                    }
                } while (!int.TryParse(Console.ReadLine(), out userAnswer) || userAnswer < 1 || userAnswer > questions[i].AnswersList.Length);

                if (questions[i].AnswersList[userAnswer - 1].isCorrect)
                {
                    FinalMark += questions[i].Mark;
                }
            }
        }
        public void ShowExamResult()
        {
            Console.WriteLine($"The Time you spend it {DateTime.Now - examStartTime}");
            Console.WriteLine("The corrected answers are : ");
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"Quesiton Number {i + 1} : ");
                for (int j = 0; j < questions[i].AnswersList.Length; j++)
                {
                    if (questions[i].AnswersList[j].isCorrect)
                    {
                        Console.WriteLine($"{questions[i].AnswersList[j].AnswerText}");
                        break;
                    }
                }
            }
            Console.WriteLine($"The Total Mark Is {questions.Sum(q => q.Mark)} And Your Final Mark is : {FinalMark}");
            if (FinalMark >= (questions.Sum(q => q.Mark) / 2)){
                Console.WriteLine("Congratulatios , you passed the exam");
            }
            else
            {
                Console.WriteLine("Sorry , you didn't pass the exam");
            }
        }

        public override string ToString()
        {
            return $"Exam ID : {SubjectID} , Exam Name : {SubjectName} and the time to take it {ExamTime}\n";

        }
    }
}
