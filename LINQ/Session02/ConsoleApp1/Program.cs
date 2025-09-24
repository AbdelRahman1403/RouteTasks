using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.ExceptionServices;
using System.Runtime.Intrinsics.X86;
using static ConsoleApp1.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            #region Elements Operators 
            ////1. Get first Product out of Stock 

            //var res = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            ////Console.WriteLine(res);
            ////2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            ////var res2 = ProductList.First(p => p.UnitPrice > 1000);
            ////Console.WriteLine(res2);

            ////3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ////var res3 = Arr.Where(n => n > 5).Skip(1).FirstOrDefault(); // 8
            //var res3 = Arr.Where(n => n > 5).ElementAtOrDefault(1); // 8
            ////Console.WriteLine(res3);

            #endregion
            #region Aggregate Operators

            //1. Uses Count to get the number of odd numbers in the array
            var res1 = Arr.Count(p => p % 2 == 1);
            //Console.WriteLine(res1);

            //2. Return a list of customers and how many orders each has.
            var res02 = CustomerList.Select(p => new
                                    {
                                        CustomerID = p.CustomerID,
                                        CustomerOrders = p.Orders.Count()
                                    }).ToList();
            //res02.ForEach(item => Console.WriteLine($"CustomerID : {item.CustomerID} , CustomerOrders : {item.CustomerOrders}"));

            //3.. Return a list of categories and how many products each has

            var res03 = ProductList.GroupBy(cat => cat.Category)
                                   .Select(prod => new
                                   {
                                       CategoryName = prod.Key,
                                       CateogryProducts = prod.Count()
                                   });
            // res03.ToList().ForEach(item => Console.WriteLine($"{item.CategoryName} : {item.CateogryProducts}"));

            //From 4 --> 14 are same questions in last assignment

            #endregion
            #region  Set Operators
            //1.Find the unique Category names from Product List

            var res04 = ProductList.Select(p => p.Category).Distinct();
            //res04.ToList().ForEach(item => Console.WriteLine(item));

            //2.Produce a Sequence containing the unique first letter from both product and customer names.
            var CustomerFilter = CustomerList.Select(p => p.CustomerName[0]);
            var ProductFilter = ProductList.Select(p => p.ProductName[0]);

            var res05 = CustomerFilter.Union(ProductFilter).ToList();

            //res05.ForEach(item => Console.WriteLine(item));
            
            //3. Create one sequence that contains the common first letter from both product and customer names.
            var CustomerFilter2 = CustomerList.Select(p => p.CustomerName[0]);
            var ProductFilter2 = ProductList.Select(p => p.ProductName[0]);

            var res06 = CustomerFilter2.Intersect(ProductFilter2).ToList();
           // res06.ForEach(item => Console.WriteLine(item));

            //4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            var CustomerFilter3 = CustomerList.Select(p => p.CustomerName[0]);
            var ProductFilter3 = ProductList.Select(p => p.ProductName[0]);

            var res07 = ProductFilter3.Except(CustomerFilter3).ToList();
            //res07.ForEach(item => Console.WriteLine(item));

            //5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            var CustomerFilter4 = CustomerList.Select(p => p.CustomerName[^3..]);
            var ProductFilter4 = ProductList.Select(p => p.ProductName[^3..]);
            var res08 = CustomerFilter4.Concat(ProductFilter4).ToList();
            //res08.ForEach(item => Console.WriteLine(item));       
            #endregion
            #region Quentifiers

            //1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            string[] file = File.ReadAllLines("dictionary_english.txt");

            var res09 = file.Where(p => p.Contains("ei")).ToList();

            //res09.ForEach(item => Console.WriteLine(item));

            //2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            var res10 = ProductList.GroupBy(cat => cat.Category)
                                   .Where(p => p.Any(q=> q.UnitsInStock == 0))
                                   .Select(ProductList => new
                                   {
                                       CategoryName = ProductList.Key,
                                       Products = ProductList
                                   });
            //res10.ToList().ForEach(item => Console.WriteLine(item));

            //3. Return a grouped a list of products only for categories that have all of their products in stock.
            #endregion
            #region Grouping Operators
            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //1. group by to partition a list of numbers by their remainder when divided by 5
            var res11 = numbers.GroupBy(n => n % 5)
                               .Select(x => new
                               {
                                   Reminder = x.Key,
                                   ReminderNumbers = x.ToList()
                               }).ToList();
            //foreach(var item in res11)
            //{
            //    Console.WriteLine($"Numbers with reminder {item.Reminder} when devided by 5");
            //    foreach(var n in item.ReminderNumbers)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}

            //2.Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input

            var res12 = file.GroupBy(w => w[0])
                            .Select(x => new
                            {
                                Character = x.Key,
                                Words = x.ToList()
                            });

            //3.Use Group By with a custom comparer that matches words that are consists of the same Characters Together


            string[] Arr1 = { "from", "salt", "earn", " last", "near", "form" };

            var FinalRes = Arr1.GroupBy(w => w , new CustomStringComparrer())
                               .Select(x => new
                                {
                                   wo = x.Key,
                                    Words = x.ToList()
                                });
            foreach(var x in FinalRes)
            {
                Console.WriteLine($"-------{x.wo}");
                foreach(var y in x.Words)
                {
                    Console.WriteLine(y);
                }
            }

            #endregion
        }
    }
    class CustomStringComparrer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return x.GetHashCode() == y.GetHashCode();
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return HashCode.Combine(obj);
        }
    }
}
