using ConsoleApp1.Questions.Classes;
using ConsoleApp1.Questions.Interfaces;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Process(IExamable obj)
        {
            obj.ImplementExam();
            Console.WriteLine(obj);
            obj.ShowExam();
            Console.Clear();
            obj.ShowExamResult();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t--Exam System--\t\t");
            Console.WriteLine("What is type of exam do you make it");
            Console.WriteLine("1 : Practical Exam");
            Console.WriteLine("2 : Final Exam");
            int choice;
            do
            {
                Console.WriteLine("Enter Your Choice");

            } while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2));

            Console.Clear();
            IExamable exam;
            int Time;
            int QuestionsNumber;
            int AnswersNumber;
            int SubjectID;
            string SubjectName;
            Console.Write("Enter The Time of Exam : ");
            do
            {

            }while(!int.TryParse(Console.ReadLine(), out Time) || Time <= 0);
            Console.Write("Enter The Subject ID : ");
            do
            {
            } while (!int.TryParse(Console.ReadLine(), out SubjectID) || SubjectID <= 0);
            Console.Write("Enter The Subject Name : ");
            do
            {
                SubjectName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(SubjectName) || string.IsNullOrEmpty(SubjectName));
            Console.Write("Enter The Number of Questions : ");
            do
            {
            } while (!int.TryParse(Console.ReadLine(), out QuestionsNumber) || QuestionsNumber <= 0);
            Console.Write("Enter The Number of Answers for each Question : ");
            do
            {
            } while (!int.TryParse(Console.ReadLine(), out AnswersNumber) || AnswersNumber <= 0);
            Console.Clear();
            if (choice == 1)
            {
                exam = new Practical(Time, QuestionsNumber, AnswersNumber, SubjectName, SubjectID);
                Process(exam);
            }
            else if (choice == 2)
            {
                exam = new Final(Time, QuestionsNumber, AnswersNumber, SubjectName, SubjectID);
                Process(exam);
            }
        }
    }
}
