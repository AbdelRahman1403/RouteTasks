using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06.Question2.Interfaces
{
    public interface IUserData
    {
        public int ID { set; }
        public string UserName { set; }
        public string Password { set; }
    }
}
