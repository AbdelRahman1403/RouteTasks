using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06.Question2.Interfaces
{
    [Flags]
    public enum UserAthur
    {
        Admin = 1,
        NormalUser = 2,
        VIBUser = 4
    };
    public interface IAuthenticationServices
    {
        public bool AuthenticateUser(string username, string password);
        public bool AuthorizeUser(string username, UserAthur role);
        public void SetUserRole(int userId, UserAthur role);
        public UserAthur userauthor { set; }
    }
}
