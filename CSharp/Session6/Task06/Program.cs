namespace Task06
{
    internal class Program
    {
        static int Swap(int x , int y)
        {
            int temp = x;
            x = y;
            y = temp;
            return temp;
        }
        static int Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            return temp;
        }
        static int sumArray(int[] arr)
        {
            int sum = 0;
            if(arr?.Length > 0)
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        static int sumArray(ref int[] arr)
        {
            int sum = 0;
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        static void SumMult(int x , int y , out int sum , out int mul)
        {
            mul = x * y;
            sum = x + y;
        }
        static int NumOfSum(int x)
        {
            int sum = 0;
            int i = 1;
            while (sum < x)
            {
                sum += i;
                i++;
            }
            return i - 1; 
        }
        static bool IsPrime(int x)
        {
            if (x < 2) return false;
            else
            {
                for(int i = 2; i < Math.Sqrt(x) + 1; i++)
                {
                    if (x % i == 0) return false;
                }
            }
            return true;
        }
        static void MinMaxArray(out int max , out int min , params int[] arr)
        {
            max = int.MinValue;
            min = int.MaxValue;
            if (arr?.Length > 0)
            {
                for(int i = 0; i < arr.Length; i += 1)
                {
                    min = Math.Min(min, arr[i]);
                    max = Math.Max(max, arr[i]);
                }
            }
        }
        static void Factorial(int x)
        {
            if (x < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
                return;
            }
            long result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"The factorial of {x} is : {result}");
        }
        static void Main(string[] args)
        {
            #region Question 1 (Value)
            //// Passing by value means copy of the value from parameter is passed to the method.
            //// Passnig by Reference means passing the actual reference of the variable in memory to the method.
            //int x = 10;
            //int y = 20;
            //Console.WriteLine($"X : {x}");
            //Console.WriteLine($"Y : {y}");
            //Console.WriteLine("After swapping 1");
            //Swap(x, y);
            //Console.WriteLine($"X : {x}");
            //Console.WriteLine($"Y : {y}");
            //Console.WriteLine("After swapping 2");
            //Swap(ref x, ref y);
            //Console.WriteLine($"X : {x}");
            //Console.WriteLine($"Y : {y}");
            #endregion
            #region Question 2 (Reference)
            //Passing by reference type acts as value means copy the reference type from argument to function parameter.
            //Passing by reference type acts as reference means passing the actual reference of the variable in memory to the method.
            //int[] arr= { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"The reuslt of array sum with by value = {sumArray(arr)}");//create anotehr array value in stack and point the array in heap.
            //Console.WriteLine($"The reuslt of array sum with by referece = {sumArray(ref arr)}");//uses the acutal array (arr) to calculate the sum


            #endregion
            #region Question 3 
            //int x, y;
            //do
            //{
            //    Console.Write("Enter Number 1 : ");
            //}while(!int.TryParse(Console.ReadLine(), out x) && x <= 0);// ????
            //do
            //{
            //    Console.Write("Enter Number 2 : ");
            //} while (!int.TryParse(Console.ReadLine(), out y) && y <= 0); //????
            //int sum, mul;
            //SumMult(x, y, out sum, out mul);
            //Console.WriteLine($"Sum of {x} and {y} is : {sum}");
            //Console.WriteLine($"Multiplication of {x} and {y} is : {mul}");
            #endregion
            #region Question 4
            //int val;
            //do
            //{
            //    Console.Write("Enter a positive integer: ");
            //} while (!int.TryParse(Console.ReadLine(), out val) || val <= 0);
            //Console.WriteLine($"The Sum Of Digits of {val} is : {NumOfSum(val)}");
            #endregion
            #region Question 5
            //int prime;
            //do
            //{
            //    Console.Write("Enter a postitive number : ");
            //} while (!int.TryParse(Console.ReadLine(), out prime) || prime <= 0);
            //bool isPrime = IsPrime(prime);
            //if (isPrime)
            //{
            //    Console.WriteLine($"{prime} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{prime} is not a prime number.");
            //}
            #endregion
            #region Question 6
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int max, min;
            //MinMaxArray(out max, out min, arr);
            //Console.WriteLine($"The maximum number is : {max}");
            //Console.WriteLine($"The minimum number is : {min}");
            #endregion
            #region Question 7
            int x;
            do
            {
                Console.Write("Enter a non-negative integer: ");
            } while (!int.TryParse(Console.ReadLine(), out x) || x < 0);
            Factorial(x);
            #endregion
        }
    }
}