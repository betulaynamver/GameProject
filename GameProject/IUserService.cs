using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserService
    {
        void Add(User user);
        void Delete(User user);
        void Update(User user);
    }
}
