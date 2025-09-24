using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using static ConsoleApp1.ListGenerator;
using static System.Net.WebRequestMethods;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ Elemetns 
            ////1.Get first Product out of Stock  
            //var res01 = ProductList.Where(p => p.UnitsInStock == 0).FirstOrDefault()/*.Select(p => p.ProductID)*/;
            ////Console.WriteLine(res01);

            ////2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var res02 = ProductList.Where(p => p.UnitPrice > 1000).FirstOrDefault();
            //// Console.WriteLine(res02);

            ////3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res03 = Arr.Where(n => n > 5).ElementAtOrDefault(1);
            ////Console.WriteLine(res03);
            #endregion
            #region Aggregate Operators
            //1. Uses Count to get the number of odd numbers in the array
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res01 = numbers.Count(p => p % 2 == 1);
            ////Console.WriteLine(res01);

            ////2. Return a list of customers and how many orders each has.

            //var res02 = CustomerList.Select(p => new { Customerid = p.CustomerID, CustomerOrders = p.Orders.Count() });

            ////foreach (var item in res02)
            ////{
            ////    Console.WriteLine(item.Customerid + " " + item.CustomerOrders);
            ////}

            ////3 Return a list of categories and how many products each has

            //var res03 = from c in ProductList
            //            group c by c.Category into Cat
            //            select new
            //            {
            //                CategoryName = Cat.Key,
            //                ProductCount = Cat.Count(),
            //                ProductNameList = Cat.Select(c => c.ProductName).ToList()
            //            };
            //var res03_2 = ProductList.GroupBy(p => p.Category)
            //                   .Select(g => new
            //                   {
            //                       CategoryName = g.Key,
            //                       ProductCount = g.Count(),
            //                       ProductNameList = g.Select(p => p.ProductName).ToList()
            //                   });

            ////foreach (var item in res03)
            ////{
            ////    Console.WriteLine($"{item.CategoryName} has {item.ProductCount} products:");
            ////    foreach (var productName in item.ProductNameList)
            ////    {
            ////        Console.WriteLine($"  - {productName}");
            ////    }
            ////}


            ////4. Get the total of the numbers in an array.
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res04 = arr.Sum();
            ////Console.WriteLine(res04);

            //#region Dictinary engslish
            //string file = @"dictionary_english.txt";

            //string[] strs = Array.Empty<string>();

            //if (File.Exists(file))
            //{
            //    strs = File.ReadAllLines(file);
            //}

            ////5.Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //int Total = strs.Count();
            ////Console.WriteLine($"Total numbers of characters is {Total}");

            ////6.Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string ans01 = strs.MinBy(c => c.Length) ?? "Empty";
            ////Console.WriteLine($"The minumem string is : {ans01}");

            ////7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string ans02 = strs.OrderByDescending(c => c.Length).FirstOrDefault() ?? "Empty";
            ////Console.WriteLine($"The longest string is {ans02} and it length is {ans02.Length}");

            ////8. Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //double ans03 = strs.Average(c => c.Length);
            ////Console.WriteLine(ans03);


            //#endregion

            ////9.Get the total units in stock for each product category.

            //var res05 = ProductList.GroupBy(c => c.Category)
            //                       .Select(g => new
            //                       {
            //                           CategoryName = g.Key,
            //                           TotalStocks = g.Sum(p => p.UnitsInStock)
            //                       });

            //var res05_2 = from p in ProductList
            //              group p by p.Category into cat
            //              select new
            //              {
            //                    CategoryName = cat.Key,
            //                    TotalStocks = cat.Sum(p => p.UnitsInStock)
            //              };
            ////foreach (var item in res05)
            ////{
            ////    Console.WriteLine($"Category Name : {item.CategoryName} : {item.TotalStocks}");
            ////}
            ////Console.WriteLine("==========");
            ////res05_2.ToList().ForEach(item => Console.WriteLine($"Category Name : {item.CategoryName} : {item.TotalStocks}"));

            ////10.Get the cheapest price among each category's products

            //var res06 = from p in ProductList
            //        group p by p.Category into cat
            //        select new
            //        {
            //            CategoryName= cat.Key,
            //            Price = cat.MinBy(p => p.UnitPrice)
            //        };
            ////res06.ToList().ForEach(item => Console.WriteLine($"Category Name : {item.CategoryName} : {item.Price?.UnitPrice}"));

            ////11.Get the products with the cheapest price in each category (Use Let)
            //var res07 = (from p in ProductList
            //            let MinPrice = ProductList.Where(pr => pr.Category.Equals(p.Category)).Min(pr => pr.UnitPrice)
            //            where p.UnitPrice == MinPrice
            //            select p).ToList();

            ////res07.ToList().ForEach(item => Console.WriteLine($"Product Name : {item.ProductName} : {item.UnitPrice}"));

            ////12.Get the most expensive price among each category's products. 

            //var res08 = (from p in ProductList
            //            let MaxPrice = ProductList.Where(pr => pr.ProductID.Equals(p.ProductID)).Max(pr => pr.UnitPrice)
            //            where p.UnitPrice == MaxPrice
            //            select p).ToList();
            ////res08.ToList().ForEach(item => Console.WriteLine($"Product Name : {item.ProductName} : {item.UnitPrice}"));

            ////13. Get the products with the most expensive price in each category.
            //var res09 = (from p in ProductList
            //             group p by p.Category into cat
            //             select new
            //             {
            //                 CategoryName = cat.Key,
            //                 MaxPrice = cat.Max(p => p.UnitPrice)
            //             });


            ////res09.ToList().ForEach(item => Console.WriteLine($"Product Name : {item.CategoryName} : {item.MaxPrice}"));


            ////14. Get the average price of each category's products.
            //var res10 = (from p in ProductList
            //             group p by p.Category into cat
            //             select new
            //             {
            //                 CategoryName = cat.Key,
            //                 AvgPrice = cat.Average(p => p.UnitPrice)
            //             });
            //res10.ToList().ForEach(item => Console.WriteLine($"Product Name : {item.CategoryName} : {item.AvgPrice}"));
            #endregion
            #region Ordering Operators
            
            //1. Sort a list of products by name

           // var res01 = ProductList.OrderBy(p=> p.ProductName).ToList();
           // //res01.ForEach(item => Console.WriteLine($"Product Name : {item.ProductName}"));

           // //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
           // string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
           // var res02 = Arr.OrderBy(p => p , StringComparer.OrdinalIgnoreCase).ToList();
           // //res02.ForEach(item => Console.WriteLine($"Word : {item}"));

           // //3. Sort a list of products by units in stock from highest to lowest.
           // var res03 = ProductList.OrderByDescending(p => p.UnitsInStock).ToList();
           // //res03.ForEach(item => Console.WriteLine($"Product Name : {item.ProductName} : {item.UnitsInStock}"));

           // //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
           // string[] Arr02 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
           // var res04 = Arr02.OrderBy(p => p.Length).ToList();
           //// res04.ForEach(item => Console.WriteLine($"Word : {item}"));
           // var res04_2 = Arr02.OrderBy(p => p , new CompaerNumbersString()).ToList();
           // //res04_2.ForEach(item => Console.WriteLine($"Word : {item}"));

           // //5.Sort first by-word length and then by a case-insensitive sort of the words in an array.
            
           // var res05 = Arr.OrderBy(p=>p.Length).ThenBy(p=>p,StringComparer.OrdinalIgnoreCase).ToList();
           // //res05.ForEach(item => Console.WriteLine($"Word : {item}"));

           // //6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
           // var res06 = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice).ToList();
           // //res06.ForEach(item => Console.WriteLine($"Product Name : {item.ProductName} : {item.Category} : {item.UnitPrice}"));

            #endregion
            #region Transformation Operators
            //1. Return a sequence of just the names of a list of products.

            var res01 = ProductList.Select(p => p.ProductName).ToList();
            //res01.ForEach(item => Console.WriteLine($"Product Name : {item}"));

            //2.Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var res02 = words.Select(p => new { Upper = p.ToUpper() , Lower = p.ToLower()}).ToList();
            //res02.ForEach(item => Console.WriteLine($"Upper Case : {item.Upper} , Lower Case : {item.Lower}"));

            //3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            var res03 = ProductList.Select(p => new { p.ProductName, p.Category, Price = p.UnitPrice }).ToList();
            //res03.ForEach(item => Console.WriteLine($"Product Name : {item.ProductName} , Category : {item.Category} , Price : {item.Price}"));

            //4. Determine if the value of int in an array matches their position in the array.
            int[] Arr01 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var res04 = Arr01.Select((num , index) => new { Num = num , idx = index , IsMatch = (num == index) }).ToList();
            res04.ForEach(item => Console.WriteLine($"Number : {item.Num} , Index : {item.idx} , IsMatch : {item.IsMatch}"));


            //6.Select all orders where the order total is less than 500.00.
            var res06 = CustomerList.SelectMany(c => c.Orders.Where(o => o.Total < 500)).ToList();
            res06.ForEach(c => Console.WriteLine(c));
            #endregion 

            var res = Enumerable.Repeat(1,10).ToList();
            res.ForEach(c => Console.WriteLine(c));

        }
        class CompaerNumbersString : IComparer<string>
        {
            enum Nums
            {
                zero,
                one,
                two,
                three,
                four,
                five,
                six,
                seven,
                eight,
                nine
            }
            public int Compare(string? x, string? y)
            {
                Nums val1, val2;
                Enum.TryParse<Nums>(x, out val1);
                Enum.TryParse<Nums>(y, out val2);

                return val1.CompareTo(val2);
            }
        }
    }
}
