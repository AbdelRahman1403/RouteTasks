using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            /*
             * 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
    Example (1)
    Input: 12 
    Output: Yes
    Example (2)
    Input: 9 
    Output: No
             */
            //Console.Write("Enter a Number : ");
            //int num;
            //int.TryParse(Console.ReadLine(), out num);
            //Console.WriteLine(((num % 3 == 0) && (num % 4 == 0)) ? "Yes" : "No");
            #endregion
            #region Question2
            /*
             * 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
    Example (1)
    Input: -5
    Output: negative
    Example (2)
    Input: 10
    Output: positive
             */
            //Console.Write("Enter a Number : ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine((x >= 0) ? "Positive" : "Negative");
            #endregion
            #region Question3
            /*
             3- Write a program that takes 3 integers from the user then prints the max element and the min element.
    Example (1)
    Input:7,8,5
    Output:
    max element = 8
    min element = 5
    Example (2)
    Input: 3 6 9
    Outputs:
    Max element = 9
    Min element = 3
             */
            //int x, y, z;
            //x = Convert.ToInt32(Console.ReadLine());
            //y = Convert.ToInt32(Console.ReadLine());
            //z = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Maximum Element is : {Math.Max(x , Math.Max(y,z))}");
            #endregion
            #region Question4
            //4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
            #endregion
            #region Question5
            /*
             5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
    Example (1)
    Input: O
    Output: vowel
    Example (2)
    Input: b
    Output: Consonant
             */
            char ch = char.Parse(Console.ReadLine().ToLower());
            if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            #endregion
        }
    }
}
