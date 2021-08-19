using System;
namespace pil_backend_darwoft.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int IdTypeUser { get; set; }

        public virtual Client Client { get; set; }
    }
}
