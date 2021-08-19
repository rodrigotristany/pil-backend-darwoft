using System;
using System.Collections.Generic;
using pil_backend_darwoft.Entities;

namespace pil_backend_darwoft.Services
{
    public interface IUserRepository
    {
        User GetUser(int userId);
    }
}
