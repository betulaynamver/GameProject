using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserManager : IUserService
    {
        public void Add(User user)
        {
            Console.WriteLine(user.UserFirstName + user.UserLastName + " added");
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.UserFirstName + user.UserLastName + " deleted");
        }

        public void Update(User user)
        {
            Console.WriteLine(user.UserFirstName + user.UserLastName + " updated");
        }
    }
}
