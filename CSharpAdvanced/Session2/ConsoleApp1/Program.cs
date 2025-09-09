using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        //class IntComparer : IComparer<int>
        //{
        //    public int Compare(int x, int y)
        //    {
        //        return y.CompareTo(x);
        //    }
        //}

        private static ArrayList ReverseArray(ArrayList arr)
        {
            int left = 0;
            int right = arr.Count - 1;
            while(left < right)
            {
                (arr[left] , arr[right]) = (arr[right] , arr[left]);
                left++;
                right--;
            }
            return arr;
        }

        private static List<int>? RemoveDublicates(List<int> arr)
        {
            if(arr is null || arr.Count == 0) return null;

            arr.Sort();
            List<int> ret = new List<int>();
            ret.Add(arr[0]);

            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    ret.Add(arr[i]);
                }
            }

            return ret;
        }

        private static List<int>? RemoveAllOddNumbers(List<int> arr) 
        {
            if (arr is null || arr.Count == 0) return null;

            List<int> ints = new List<int>();

            arr.ForEach(i =>
            {
                if(i % 2 == 1) ints.Add(i);
            });
            return ints;
        }

        static void Main(string[] args)
        {
            #region Question 1
            /*
             You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements

             */
            //ArrayList res = ReverseArray(new ArrayList() { 1, 2, "Ahmed", "Nada", 5.3, 19 });

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question 2
            /*
             You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.             
             */
            //List<int> numbers = new List<int> { 5, 2, 8, 1, 3  , 10 , 12};

            //List<int> res = new List<int>();

            //numbers.ForEach(n =>
            //{
            //    if(n % 2 == 0)
            //        res.Add(n);
            //});
            //res.ForEach(n => Console.WriteLine(n));
            //List<int> numbers = new List<int> { 5, 2, 8, 1, 3, 10, 12 };
            //List<int> res = new List<int>();

            //res = numbers.FindAll((n) => n % 2 == 1);

            //res.ForEach(n => Console.WriteLine(n));
            #endregion
            #region Question 3

            //FixedSizeList<int> list = new FixedSizeList<int>(3);
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //int res;
            //list.Get(2 , out res);
            #endregion
            #region Question 4

            //int ArrayNum;
            //int QueryNum;
            //Console.Write("Enter the number of query : ");
            //do
            //{ 
            //}while(!int.TryParse(Console.ReadLine(), out QueryNum) || QueryNum <= 0);
            //Console.Write("Enter the number of elements : ");
            //do
            //{
            //} while (!int.TryParse(Console.ReadLine(), out ArrayNum) || ArrayNum <= 0);

            //List<int> nums = new List<int>();
            //List<int> querys = new List<int>();
            //Console.WriteLine("Enter the elements : ");
            //for (int i = 0; i < ArrayNum; i++)
            //{
            //    int num;
            //    do
            //    {
            //        Console.Write($"Element {i + 1} : ");
            //    } while (!int.TryParse(Console.ReadLine(), out num));
            //    nums.Add(num);
            //}
            //Console.WriteLine("Enter the querys : ");
            //for (int i = 0; i < QueryNum; i++)
            //{
            //    int num;
            //    do
            //    {
            //        Console.Write($"Query {i + 1} : ");
            //    } while (!int.TryParse(Console.ReadLine(), out num));
            //    querys.Add(num);
            //}

            //querys.ForEach(q =>
            //{
            //    int count = 0;
            //    foreach(var n in nums)
            //    {
            //        if(q < n) count+=1;
            //    }
            //    Console.WriteLine(count);
            //});

            #endregion
            #region Question 5
            //int size;
            //do
            //{
            //    Console.WriteLine("Enter size of the array : ");
            //} while (!int.TryParse(Console.ReadLine() , out size) && size <= 0);

            //if (size == 1)
            //{
            //    Console.WriteLine("Yes , It's a palindrome array");
            //}
            //else
            //{
            //    List<int> list = new List<int>();
            //    Console.WriteLine("Enter elemnts of array : ");
            //    for(int i = 0; i < size; i++)
            //    {
            //        int x;
            //        do
            //        {
            //            Console.Write("Enter Element : ");
            //        } while (!int.TryParse(Console.ReadLine(), out x) && x < 0);
            //        list.Add(x);
            //    }
            //    int j = list.Count - 1;
            //    bool chick = false;
            //    for(int i = 0; i < list.Count / 2; i++ , j--)
            //    {
            //        if (list[i] == list[j])
            //        {
            //            chick = true;
            //        }
            //        else
            //        {
            //            chick = false;
            //            break;
            //        }
            //    }
            //    string res = chick == true ? "It is a palindrome array" : "NOT Palindrome array";

            //    Console.WriteLine(res);
            //}

            #endregion
            #region Question 6

            //int size;
            //do
            //{
            //    Console.WriteLine("Enter size of the array : ");
            //} while (!int.TryParse(Console.ReadLine(), out size) && size <= 0);

            //List<int> list = new List<int>();
            //Console.WriteLine("Enter elemnts of array : ");
            //for (int i = 0; i < size; i++)
            //{
            //    int x;
            //    do
            //    {
            //        Console.Write("Enter Element : ");
            //    } while (!int.TryParse(Console.ReadLine(), out x) && x < 0);
            //    list.Add(x);
            //}
            //RemoveDublicates(list);
            #endregion
            #region Question 7

            List<int> arr = new List<int>();
            

            #endregion
        }
    }
}
