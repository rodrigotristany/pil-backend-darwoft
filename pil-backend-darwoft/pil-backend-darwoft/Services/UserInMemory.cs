using System;
using System.Collections.Generic;
using pil_backend_darwoft.Entities;

namespace pil_backend_darwoft.Services
{
    public class UserInMemory : IUserRepository
    {
        private User user;

        public UserInMemory()
        {
            user = new User()
            {
                Username = "Rodrigo"
            };
        }

        public User GetUser(int userId)
        {
            return user;
        }
    }
}
