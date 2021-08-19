using System;
namespace pil_backend_darwoft.Entities
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int IdBoss { get; set; }
    }
}
