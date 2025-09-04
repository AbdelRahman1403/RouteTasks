using ConsoleApp1.Questions.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Questions.Classes
{
    public class BaseQuestion : IQuestionable
    {
        public string? QuestionHeader { get; set; }
        public int Mark { get; set; }
        public Answers[]? AnswersList { get; set; }
        public void SetQuestionHeaderAndSetMark(int i)
        {
            bool IsVaild;
            do
            {
                Console.WriteLine($"please Enter The Question Header Number {i}");
                QuestionHeader = Console.ReadLine();

                IsVaild = string.IsNullOrWhiteSpace(QuestionHeader) || string.IsNullOrEmpty(QuestionHeader);
                if (IsVaild)
                {
                    Console.WriteLine("The Question Header is not vaild , please try again");
                }
            } while (IsVaild);

            do
            {
                Console.WriteLine("Enter The Question Mark , Please");
                IsVaild = int.TryParse(Console.ReadLine(), out int mark) && mark > 0;

                if (!IsVaild)
                {
                    Console.WriteLine("The Question Mark is not vaild , please try again");
                }
                else
                {
                    Mark = mark;
                }
            } while (!IsVaild);
        }
        public void SetMulitpleChoicesQuestion()
        {
            bool isvalid = false;
            for (int j = 0; j < AnswersList.Length;)
            {
                isvalid = false;
                do
                {
                    Console.WriteLine($"Enter Choice Number {j + 1}");
                    AnswersList[j].AnswerText = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(AnswersList[j].AnswerText))
                    {
                        Console.WriteLine("Please Re-Write the Choice.");
                    }
                    else
                    {
                        isvalid = true;
                    }
                } while (!isvalid);
                AnswersList[j].AnswerId = j + 1;
                j++;
            }
            Console.Write("What is the Corrected Answer : ");
            do
            {
                if (int.TryParse(Console.ReadLine(), out int correctedAnswer) && correctedAnswer >= 1 && correctedAnswer <= AnswersList.Length)
                {
                    AnswersList[correctedAnswer - 1].isCorrect = true;
                    isvalid = true;
                }
                else
                {
                    Console.WriteLine("Please Re-Write the Corrected Answer.");
                }
            } while (!isvalid);
        }
        public void SetTrueFalseQuestion()
        {
            AnswersList[0].AnswerText = "True";
            AnswersList[0].AnswerId = 1;

            AnswersList[1].AnswerText = "False";
            AnswersList[1].AnswerId = 2;
            Console.WriteLine("Please set 1 for Ture choice or 2 for False choice");
            bool isvalid = false;
            do
            {
                if(int.TryParse(Console.ReadLine() , out int CorrectedAnswer) && (CorrectedAnswer == 1 || CorrectedAnswer == 2))
                {
                    if(CorrectedAnswer == 1)
                    {
                        AnswersList[0].isCorrect = true;
                        AnswersList[1].isCorrect = false;
                        isvalid = true;
                    }
                    else if (CorrectedAnswer == 2)
                    {
                        AnswersList[0].isCorrect = false;
                        AnswersList[1].isCorrect = true;
                        isvalid = true;
                    }
                }
                else
                {
                    Console.WriteLine("Please , Re-Write the Answer");
                }
            }
            while (!isvalid);
        }
    }
}