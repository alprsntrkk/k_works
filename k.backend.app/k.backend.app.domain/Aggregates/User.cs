using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k.backend.app.domain.Aggregates
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}