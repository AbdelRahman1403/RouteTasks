using System.Collections;
namespace ConsoleApp1
{
    internal class Program
    {
        public static void ReverseQueue<T>(ref Queue<T> arr) 
        {
            Stack<T> stk = new Stack<T>();

            foreach(T item in arr)
            {
                stk.Push(item);
            }

            for(int i = 0; i< arr.Count; i++)
            {
                arr.Dequeue();
                arr.Enqueue(stk.Peek());
                stk.Pop();
            }
        }
        
        static bool Chicked(char ch1 , char ch2)
        {
            return (ch1 == '{' && ch2 == '}') || (ch1 == '[' && ch2 == ']') || (ch1 == '(' && ch2 == ')');
        }
        public static bool Chickparentheses (string str)
        {
            Stack<char> stk = new Stack<char>();
            bool Chick = true;
            foreach (char c in str)
            {
                if(c == '{' || c == '[' || c== '(') 
                    stk.Push(c);

                else
                {
                    if (stk.Count == 0)
                    {
                        Chick = false;
                        break;
                    }
                    Chick = Chicked(stk.Peek(), c);
                    if(Chick == false)
                    {
                        break;
                    }
                    stk.Pop();
                }
            }

            return Chick;
        }

        static void Main(string[] args)
        {
            #region Question 1

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Enqueue(6);
            //queue.Enqueue(7);
            //queue.Enqueue(8);
            //queue.Enqueue(9);
            //queue.Enqueue(10);
            //foreach (var item in queue)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            //Console.WriteLine();
            //ReverseQueue<int>(ref queue);
            //Console.WriteLine();
            //foreach (var item in queue)
            //{
            //    Console.Write($"{item} ");
            //}

            #endregion
            #region Question 2

            string str = new string("[()]}{");

            if (Chickparentheses(str))
            {
                Console.WriteLine("Balanced");
            }
            else
            {
                Console.WriteLine("Not Balanced");
            }

            #endregion
        }
    }
}
