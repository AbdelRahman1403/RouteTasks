using System.Drawing;
using Task06.Question1.Classes;
using Task06.Question2.Classes;
using Task06.Question2.Interfaces;
namespace Task06
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Part 1
            // Question 1 : 
            /// The primary purpose of interface is define the blueprint of the class.

            // Question 2 :
            /// The access modifier (Protected) is not allowed for interface

            // Question 3 :
            /// No , the interface cannot contain fields.
            /// 
            // Question 4 :
            ///Yes, interfaces can inherit from multiple interfaces
            ///
            // Question 5 :
            /// To inheirit from an interface , we use (:) colon . 
            /// 
            // Question 6 :
            ///NO , interface cannot contain static methods.
            ///
            // Question 7 :
            /// All members of an interfaces are public by default and cannot have any access modifiers.
            /// 
            // Question 8 :
            ///To allow multiple classes to implement the same interface
            ///
            // Question 9 :
            ///interface doesn't support constructors
            ///
            // Question 10 :
            ///By separating interface names with commas
            #endregion
            #region Part 2
            // Question 1 :
            #region Question 1
            //myRectangle rectangle = new myRectangle();
            //rectangle.Length = 5;
            //rectangle.Width = 10;
            //rectangle.DisplayShapeInfo();

            //myCyrcle cyrcle = new myCyrcle();
            //cyrcle.Radius = 7;
            //cyrcle.DisplayShapeInfo(); 
            #endregion
            #region Question 2
            BasicAuthenticationService emp01 = new BasicAuthenticationService();
            emp01.ID = 1;
            emp01.UserName = "AbdelRahman Ahmed";
            emp01.userauthor = UserAthur.Admin;
            emp01.Password = "12345";
            Console.WriteLine(emp01);
            emp01.SetUserRole(10, UserAthur.VIBUser);
            Console.WriteLine(emp01);
            Console.WriteLine(emp01.AuthenticateUser("AbdelRahman Ahmed", "12345"));
            Console.WriteLine(emp01.AuthorizeUser("AbdelRahman Ahmed", UserAthur.VIBUser));
            #endregion
            #region Question 3

            #endregion
            #endregion

        }
    }
}
