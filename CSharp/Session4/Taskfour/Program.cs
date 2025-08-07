using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Transactions;

namespace Taskfour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment 4
            bool corrinsert = false;
            int num;
            #region question 1
            //int num = 0;
            ///*6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.*/
            //do
            //{
            //    Console.Write("Enter a Number : ");
            //    corrinsert = int.TryParse(Console.ReadLine(), out num);  
            //} while (!corrinsert);
            //for(int i = 1; i <= num; i++)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion
            #region quesion 2
            /* Write a program that allows the user to insert an integer then 
print a multiplication table up to 12.
//*/
            //int num;
            //            do
            //            {
            //            Console.WriteLine("Enter the number : ");
            //            corrinsert = int.TryParse(Console.ReadLine(), out num);      
            //            }while(!corrinsert);
            //            int temp = 0;
            //            for (int i = 0; i < 12; i++)
            //            {
            //                temp = temp + num;
            //                Console.Write(temp + " ");
            //            }
            //            #endregion
            #endregion
            #region question 3
            //do
            //{
            //    Console.WriteLine("Enter a number : ");
            //    corrinsert = int.TryParse(Console.ReadLine(), out num);
            //} while (!corrinsert);
            //for (int i = 2; i <= num; i++)
            //{
            //    if(i % 2 == 0) Console.WriteLine(i);
            //}
            #endregion
            #region question 4
            //Write a program that takes two integers then prints the power.
            //int num1, num2;
            //do
            //{
            //    Console.WriteLine("Enter the number and power : ");
            //    num1 = int.TryParse(Console.ReadLine(), out num1) ? num1 : 0;
            //    num2 = int.TryParse(Console.ReadLine(), out num2) ? num2 : 0;
            //} while (num1==0&& num2==0);
            //Console.WriteLine("The result is : " + Math.Pow(num1 , num2));
            #endregion
            #region Question 5
            // Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int[] marks = new int[5];
            //int total = 0;
            //for(int i = 0; i < marks.GetLength(0); i++)
            //{
            //    marks[i] = int.TryParse(Console.ReadLine(), out int temp) ? temp : 0;
            //    total += marks[i];
            //}
            //Console.WriteLine("The total is : " + total);
            //Console.WriteLine("The avg is : " + total / 5);
            //Console.WriteLine("The prercentage is : " + total * .01);

            #endregion
            #region Question 6
            //Write a program to input the month number and print the number of days in that month.
            //int month;
            //do
            //{
            //    month = int.TryParse(Console.ReadLine(), out int temp) ? temp : 0;
            //} while (month == 0);
            //int DaysOfMonth = DateTime.DaysInMonth(DateTime.Now.Year, month);
            //Console.WriteLine($"The days of month {month} is {DaysOfMonth}");
            #endregion
            #region Question 7
            //int num1, num2;
            //Console.WriteLine("Enter two numbers yaaddd") ;
            //num1 = int.Parse(Console.ReadLine());
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter operator : ");
            //char op = char.Parse(Console.ReadLine());
            //int result = op switch
            //{
            //    '+' => num1 + num2,
            //    '-' => num1 - num2,
            //    '*' => num1 * num2,
            //    '/' => num1 / num2,
            //    '%' => num1 % num2,
            //    '^' => (int)Math.Pow(num1, num2),
            //    _ => 0
            //};
            //Console.WriteLine($"The result is : {result}");
            //#endregion
            #endregion
            #region Question 8
            ////Write a program to allow the user to enter a string and print the REVERSE of it.
            //string? str = new string(string.Empty);
            //Console.Write("Enter a string : ");
            //str = Console.ReadLine() ?? "Error";
            //StringBuilder sb = new StringBuilder();
            //int cnt = str.Length - 1;
            //while (cnt >= 0)
            //{
            //    sb.Append(str[cnt--]);
            //}
            //Console.WriteLine($"The result is : {sb.ToString()}");
            #endregion
            #region Question 9
            //// Write a program to allow the user to enter int and print the REVERSED of it.
            //do
            //{
            //    Console.Write("Enter a Number : ");
            //    corrinsert = int.TryParse(Console.ReadLine(), out num);
            //} while (!corrinsert);
            //StringBuilder str = new StringBuilder();
            //int x = 0;
            //while(num != 0)
            //{
            //    x = num % 10;
            //    str.Append(x);
            //    num = num / 10;
            //}
            //Console.WriteLine($"The Number after reserved is : {str.ToString()}");
            #endregion
            #region Question 10
            //int num1, num2;
            //do
            //{
            //    Console.WriteLine("Enter Two Numbers : ");
            //     num1 = int.TryParse(Console.ReadLine(), out num1) ?num1  : 0;
            //     num2 = int.TryParse(Console.ReadLine(), out num2) ?num2  : 0;
            //}while (num1 == 0 && num2 == 0);
            //if (num1 == 1) num1++;
            //if(num2 <=0) Console.WriteLine("It's not prime");
            //else
            //{
            //    for(int i = num1; i <= num2; i++)
            //    {
            //        bool isPrime = true;
            //        for(int j = 2; j < i; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }
            //        if (isPrime) Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Question 11
            //Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //int x1, y1, x2, y2, x3, y3;
            //do
            //{
            //    Console.WriteLine("Enter the first point (x1, y1): ");
            //    x1 = int.TryParse(Console.ReadLine(), out x1) ? x1 : 0;
            //    y1 = int.TryParse(Console.ReadLine(), out y1) ? y1 : 0;

            //    Console.WriteLine("Enter the first point (x2, y2): ");
            //    x2 = int.TryParse(Console.ReadLine(), out x2) ? x2 : 0;
            //    y2 = int.TryParse(Console.ReadLine(), out y2) ? y2 : 0;

            //    Console.WriteLine("Enter the first point (x3, y3): ");
            //    x3 = int.TryParse(Console.ReadLine(), out x3) ? x3 : 0;
            //    y3 = int.TryParse(Console.ReadLine(), out y3) ? y3 : 0;
            //} while ((x1 == 0 && y1 == 0)|| (x2 == 0 && y2 == 0)|| (x3 == 0 && y3 == 0));
            //if((x2 - x1) * (y2 - y1) == (x3 - x1) * (y3 - y1))
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}
            #endregion
            #region Question 12
            int duration = 0;
            do
            {
                Console.Write("Enter the duration : ");
                duration = int.TryParse(Console.ReadLine(), out duration) ? duration : 0;
            } while (duration == 0);

            string result = duration switch
            {
                > 5 => "must leave the company",
                > 4 and <= 5 => "should train to enhance their speed",
                > 3 and <= 4 => "instructed to increase their speed",
                >= 2 or <= 3 => "Consider highly efficient",
            };
            Console.WriteLine($"Worker who takes {duration} hours {result}.");
            #endregion
            #endregion
        }
    }
}
