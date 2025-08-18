using TaskOOP2.Company;

namespace TaskOOP2
{
    internal class Program
    {
        enum WeekDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        enum seasons
        {
            Spring = 1,
            Summer,
            Autumn,
            Winter
        }
        [Flags]
        enum permission : byte
        {
            Read = 1,
            Write = 2,
            Execute = 4,
            Delete = 8
        }
        enum RGB
        {
            Red = 1,
            Green = 2,
            Blue = 3
        }
        static void Main(string[] args)
        {
            #region Question 1
            //WeekDays day; 
            //for(int i = 0; i < 7; i++)
            //{
            //    switch (i)
            //    {
            //        case 0:
            //            day = WeekDays.Sunday;
            //            Console.WriteLine(day);
            //            break;
            //        case 1:
            //            day = WeekDays.Monday;
            //            Console.WriteLine(day);
            //            break;
            //        case 2:
            //            day = WeekDays.Tuesday;
            //            Console.WriteLine(day);
            //            break;
            //        case 3:
            //            day = WeekDays.Wednesday;
            //            Console.WriteLine(day);
            //            break;
            //        case 4:
            //            day = WeekDays.Thursday;
            //            Console.WriteLine(day);
            //            break;
            //        case 5:
            //            day = WeekDays.Friday;
            //            Console.WriteLine(day);
            //            break;
            //        case 6:
            //            day = WeekDays.Saturday;
            //            Console.WriteLine(day);
            //            break;
            //    }
            //}
            #endregion
            #region Question 2
            //Person[] p = new Person[3]
            //{
            //    new Person("Alice", "30"),
            //    new Person("Bob", "25"),
            //    new Person("Charlie", "35")
            //};
            //Console.WriteLine(p[0]);
            //Console.WriteLine(p[1]);
            //Console.WriteLine(p[2]);
            #endregion
            #region Question 3
            //seasons season;

            //do
            //{
            //    Console.WriteLine("Enter the season : ");
            //} while (Enum.TryParse<seasons>(Console.ReadLine(), out season) && !((int)season >= 1 && (int)season <= 4));
            //if (season == seasons.Spring)
            //{
            //    Console.WriteLine($"The monthes of {season} are : March , April and May.");
            //}
            //else if (season == seasons.Summer)
            //{
            //    Console.WriteLine($"The monthes of {season} are : June , July and August.");
            //}
            //else if (season == seasons.Autumn)
            //{
            //    Console.WriteLine($"The monthes of {season} are : September , October and November.");
            //}
            //else if (season == seasons.Winter)
            //{
            //    Console.WriteLine($"The monthes of {season} are : December , January and February.");
            //}
            #endregion
            #region Question 4
            permission userPer = new permission();
            //while(true)
            //{
            //    Console.WriteLine("Enter User Permission : ");
            //    string input = Console.ReadLine();
            //    if (input == "Read")
            //    {
            //        userPer |= permission.Read;
            //    }
            //    else if (input == "Write")
            //    {
            //        userPer |= permission.Write;
            //    }
            //    else if (input == "Execute")
            //    {
            //        userPer |= permission.Execute;
            //    }
            //    else if (input == "Delete")
            //    {
            //        userPer |= permission.Delete;
            //    }
            //    else if (input == "Exit")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Permission");
            //        continue;
            //    }
            //    Console.WriteLine(userPer);
            //}
            //while (true)
            //{
            //    Console.WriteLine("Enter the user permession : ");
            //    char input = char.Parse(Console.ReadLine());
            //    if(input == 'r')
            //    {
            //        if(userPer.HasFlag(permission.Read))
            //        {
            //            Console.WriteLine("User has Read permission.");
            //        }
            //        else
            //        {
            //            userPer ^= permission.Read;
            //        }

            //    }
            //    else if (input == 'w')
            //    {
            //        if (userPer.HasFlag(permission.Write))
            //        {
            //            Console.WriteLine("User has Write permission.");
            //        }
            //        else
            //        {
            //            userPer ^= permission.Write;
            //        }
            //    }
            //    else if (input == 'e')
            //    {
            //        if (userPer.HasFlag(permission.Execute))
            //        {
            //            Console.WriteLine("User has Execute permission.");
            //        }
            //        else
            //        {
            //            userPer ^= permission.Execute;
            //        }
            //    }
            //    else if (input == 'd')
            //    {
            //        if (userPer.HasFlag(permission.Delete))
            //        {
            //            Console.WriteLine("User has Delete permission.");
            //        }
            //        else
            //        {
            //            userPer ^= permission.Delete;
            //        }
            //    }
            //    else if (input == 'x')
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Permission");
            //    }
            //    Console.WriteLine(userPer);
            //}
            #endregion
            #region Question 5
            //Console.WriteLine("Enter the color name : ");
            //RGB color;
            //Enum.TryParse<RGB>(Console.ReadLine(),out color);

            //string res = color switch
            //{
            //    RGB.Red => "The color is Red.",
            //    RGB.Green => "The color is Green.",
            //    RGB.Blue => "The color is Blue.",
            //    _ => "Invalid color."
            //};
            //Console.WriteLine(res);
            #endregion
            #region Question 6
            //Point p = new Point();
            //p.X = 10;
            //p.Y = 10;
            //Console.WriteLine(p.ToString());
            //Point p2 = new Point();
            //p2.X = 20;
            //p2.Y = 30;
            //Console.WriteLine(p2);
            //int distance = (int)Math.Sqrt(Math.Pow(p2.X - p.X, 2) + Math.Pow(p2.Y - p.Y, 2));
            //Console.WriteLine($"The distance between the two points is {distance} units.");
            #endregion
            #region Question 7
            //Same Question number 2
            #endregion
            //------------------------------------------------------------
            #region Question 8
            Employee emp = new Employee(1 , "AbdelRaham" , 5000 , Gender.Male , "security");
            Console.WriteLine(emp.ToString());
            #endregion
        }
    }
}
