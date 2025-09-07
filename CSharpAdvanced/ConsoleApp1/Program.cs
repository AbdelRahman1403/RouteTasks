namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Question 1
            //BubbleSortOptimized<int>.BubbleSortOptimizedMethod(new int[]{ 64, 34, 25, 12, 22, 11, 90 });
            //Console.WriteLine();
            //BubbleSortOptimized<string>.BubbleSortOptimizedMethod(new string[]{ "Ahmed" , "Mona" , "AbdelRahman" , "Amr"});

            #endregion
            #region Question 2
            Range<int> intRange = new Range<int>(10, 20);
            Console.WriteLine($"Chick if number 30 in the range {intRange.IsInRange(15)}");
            Console.WriteLine($"Get the length between 10 and 20 {intRange.Length()}");

            Range<char> CharRange = new Range<char>('A', 'Z');
            Console.WriteLine($"Chick if char '/' in the range {CharRange.IsInRange('/')}");
            Console.WriteLine($"Get the length between 'A' and 'Z' {CharRange.Length()}");
            #endregion
        }
    }
}
