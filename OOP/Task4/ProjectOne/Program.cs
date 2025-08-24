using System.Transactions;

namespace ProjectOne
{
    internal class Program
    {
        private static int GetVal(char c)
        {
            int x;
            do
            {
                Console.Write($"Enter Coordinate {c} : ");
            }while(!int.TryParse(Console.ReadLine(), out x));
            return x;
        }
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(10, 20, 30);
            Console.WriteLine(p1);

            Point3D p2 = new Point3D(0);
            Point3D p3 = new Point3D(0);
            Console.WriteLine("Enter P2 coordinates");
            p2.X = GetVal('X');
            p2.Y = GetVal('Y');
            p2.Z = GetVal('Z');
            Console.WriteLine("Enter P2 coordinates");
            p3.X = GetVal('X');
            p3.Y = GetVal('Y');
            p3.Z = GetVal('Z');
            if (p2 == p3)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
        }
    }
}
