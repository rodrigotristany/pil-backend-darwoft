using System;
using System.Collections.Generic;
using System.Linq;
using pil_backend_darwoft.DBContexts;
using pil_backend_darwoft.Entities;

namespace pil_backend_darwoft.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly DarwoftMarketContext _context;

        public UserRepository(DarwoftMarketContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<User> GetUser(int userId)
        {
            return _context.Users
                .Where(u => u.Id == userId);
        }
    }
}
