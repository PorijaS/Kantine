
/* Unmerged change from project 'Kantine (net6.0-maccatalyst)'
Before:
using System;
using Kantine.Model;
After:
using Kantine.Model;
using System;
*/

/* Unmerged change from project 'Kantine (net6.0-ios)'
Before:
using System;
using Kantine.Model;
After:
using Kantine.Model;
using System;
*/

/* Unmerged change from project 'Kantine (net6.0-windows10.0.19041.0)'
Before:
using System;
using Kantine.Model;
After:
using Kantine.Model;
using System;
*/
using Kantine.Model;

namespace Kantine.Services
{
    public class UserService
    {
        static UserService _instance;

        public static UserService instance
        {
            get
            {
                _instance ??= new UserService();

                return _instance;
            }
        }

        public readonly User User1 = new User
        {
            Email = "porijashiraz@live.dk"
        };

        public List<User> GetUsers()
        {
            return new List<User>
            {
                User1
            };
        }
    }


}

