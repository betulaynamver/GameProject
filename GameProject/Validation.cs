using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Validation : IUserValidationService
    {
        public void Edevlet(User user)
        {
            Console.WriteLine("Kişi doğrulaması yapılmıştır.");
        }
    }
}
