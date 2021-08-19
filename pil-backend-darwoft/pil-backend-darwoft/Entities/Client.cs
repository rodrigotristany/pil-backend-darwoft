using System;
namespace pil_backend_darwoft.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Amount { get; set; }

        public virtual User IdNavigation { get; set; }
    }
}
