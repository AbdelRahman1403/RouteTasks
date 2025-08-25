namespace ProjectThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration duration = new Duration(2, 30, 45);
            Console.WriteLine(duration.ToString());

            Duration duration1 = new Duration(1, 20, 30);
            Console.WriteLine(duration1.ToString());
            Duration duration2 = new Duration(3600);
            Console.WriteLine(duration2.ToString());
            Duration duration3 = duration + duration1;
            Console.WriteLine(duration3.ToString());
            Duration duration4 = duration - duration1;
            Console.WriteLine(duration4.ToString());
            Console.WriteLine(duration > duration1);
            Console.WriteLine(duration < duration1);
            Console.WriteLine(duration > duration2);
            Console.WriteLine(duration < duration2);
            Console.WriteLine(duration < duration3);
            Console.WriteLine(duration < duration4);

        }
    }
}
