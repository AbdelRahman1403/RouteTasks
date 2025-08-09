namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment 5
            bool isValidInput = false;
            #region Question 1
            ////Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //int n;
            //do
            //{
            //    Console.Write("Enter the size of the identity matrix (n): ");
            //    isValidInput = int.TryParse(Console.ReadLine(), out n) && n > 0;
            //}while(!isValidInput);
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < n; j++)
            //    {
            //        Console.Write($"{j} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Question 2
            //Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int sum = 0;
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine($"The sum of the array elements is: {sum}");
            #endregion
            #region Question 3
            ////Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] array1 = { 7 , 1 , 3 , 5 };
            //int[] array2 = { 2, 4, 6, 8 , 11 , 15};
            //Array.Sort(array1);
            //Array.Sort(array1);
            //int[] array3 = new int[array1.Length + array2.Length];
            //Array.Copy(array1, array3, array1.Length);
            //Array.Copy(array2, 0, array3, array1.Length, array2.Length);
            //Array.Sort(array3);
            //for (int i =0 ; i < array3.Length; i++)
            //{
            //    Console.WriteLine(array3[i]);
            //}
            #endregion
            #region Question 4
            // Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] numbers = { 1, 2, 2, 3, 4, 4, 4, 5 };
            //int[] freq = new int[numbers.Length];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    freq[numbers[i]]++;
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (freq[numbers[i]] != 0)
            //    {
            //        Console.WriteLine($"Element {numbers[i]} occurs {freq[numbers[i]]} times.");
            //        freq[numbers[i]] = 0; // Reset frequency to avoid duplicate output
            //    }
            //}
            #endregion
            #region Question 5
            /// Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] numbers = { 1, 2, 3, 4, 5, -1, 10, -5 };
            //Array.Sort(numbers);
            //Console.WriteLine($"The Minimum Element is {numbers[0]}.\nThe Maximum elemnt is : {numbers[numbers.Length-1]}.");
            #endregion
            #region Question 6
            // Write a program in C# Sharp to find the second largest element in an array.
            int[] numbers = { 1, 2, 3, 4, 5, -1, 10, -5 };
            Array.Sort(numbers);
            Console.WriteLine($"The Second Largest Element is {numbers[numbers.Length - 2]}.");

            #endregion
            #region Question 7
            //int n;
            //do
            //{
            //    Console.Write("Enter the value of n : ");
            //} while (!int.TryParse(Console.ReadLine(), out n));
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    while (!int.TryParse(Console.ReadLine(), out arr[i]))
            //    {
            //        Console.Write("Invalid input. Please enter an integer: ");
            //    }
            //}
            //int Maxi = int.MinValue;
            //int cnt = 0;
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = i; j < n; j++)
            //    {
            //        ++cnt;
            //        if (arr[i] == arr[j])
            //        {
            //            Maxi = Math.Max(Maxi, cnt);
            //        }
            //    }
            //    Console.WriteLine($"The repeated number of {arr[i]} is : {Maxi}");
            //    Maxi = int.MinValue;
            //    cnt = 0;
            //}
            #endregion
            #region Question 8
            //string? input = new string(String.Empty);
            //Console.WriteLine("Emter a string : ");
            //input = Console.ReadLine();
            //string[]? words = input.Split(' ');
            //Array.Reverse(words);
            //Console.WriteLine(string.Join(" " , input));
            #endregion
            #region Question 9
            int[,]array1 = new int[3, 3];
            int[,]array2 = new int[3, 3];
            for(int i = 0; i < array1.GetLength(0); i++)
            {
                for(int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.Write($"Enter element [{i},{j}] for first array: ");
                    while (!int.TryParse(Console.ReadLine(), out array1[i, j]))
                    {
                        Console.Write("Invalid input. Please enter an integer: ");
                    }
                }
            }
            Buffer.BlockCopy(array1,0,array2,0,array1.Length * sizeof(int));//Deep copy , copy the memory block of array1 elements and copy it to array2
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for(int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.WriteLine($"The element in row {i} and column {j}  is : {array2[i, j]}");
                }
            }
            #endregion
            #endregion
        }
    }
}
