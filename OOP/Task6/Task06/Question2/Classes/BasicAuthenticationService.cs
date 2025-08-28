using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Task06.Question2.Interfaces;

namespace Task06.Question2.Classes
{
    public class BasicAuthenticationService : IAuthenticationServices , IUserData
    {
        private int id;
        private string? userName;
        private string? password;
        private UserAthur userautherClass;
        public int ID {
            set 
            {
                id = value < 10 ? value : 10;
            } 
        }
        public string UserName { 
            set
            {
                userName = value is null ? "Unknown" : value;
            }
        }
        public string Password { 
            set {
                password = value is null ? "Error" : value;
            }
        }
        public UserAthur userauthor {
            set
            {
                userautherClass |= value;
            }
        }

        public bool AuthenticateUser(string username, string password)
        {
            return username == userName && password == this.password;
        }

        public bool AuthorizeUser(string username, UserAthur role)
        {
            return (username == this.userName) && userautherClass.HasFlag(role);
        }

        public void SetUserRole(int userId, UserAthur role)
        {
            // Set or edit permission: if userId matches, set the role
            if(this.id != userId)
            {
                Console.WriteLine("There is not correct");
                return;
            }
            else
            {
                userautherClass |= role;
            }
        }
        public override string ToString()
        {
            return $"User ID : {id}\nUser Name : {userName} and his role is : {userautherClass}";
        }
    }
}
