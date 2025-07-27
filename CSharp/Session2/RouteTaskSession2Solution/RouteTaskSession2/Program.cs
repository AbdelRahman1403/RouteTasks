namespace RouteTaskSession2
{
    internal class Program
    {
        public class Point //Struct ??
        {
            public int x;
            public int y;
            override public string ToString()
            {
                return $"Point: ({x}, {y})";
            }
        }
        static void Main(string[] args)
        {
            #region Quesion1
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Number is : {x}");
            #endregion

            #region Question2
            string y = Console.ReadLine();
            Console.WriteLine(int.Parse(y)); // Error , the program will crash because we insert non umeric value
            #endregion

            #region Question3
            float x = 3.3f;
            float y = 2.2f;
            Console.WriteLine($"The Result is : {x + y}");
            #endregion

            #region Question4
            Console.WriteLine("Hello World".Substring(4));
            #endregion

            #region Question5
            int x = 10;
            int y = 20;
            x = y;
            Console.WriteLine(x);
            Console.WriteLine(y);
            #endregion

            #region Question6
            Point p1 = new Point();
            Point p2 = new Point();
            p1 = p2;
            p1.x = 10;
            p1.y = 20;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            #endregion

            #region Question7
            string Fname = "AbdelRahman";
            string Lname = "Yassin";
            Console.WriteLine($"Your name is {Fname} {Lname}");
            #endregion
            #region Question8
            //The correct anser is number B
            #endregion

            #region Question9
            Console.WriteLine(13 / 2 + " " + 13 % 2); // 6 1
            #endregion

            #region Question10
            int num = 1, z = 5;
            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);// will be run and the value is 7 7
            else
                Console.WriteLine(--num + z-- + " " + --z); 

            #endregion
        }
    }
}
