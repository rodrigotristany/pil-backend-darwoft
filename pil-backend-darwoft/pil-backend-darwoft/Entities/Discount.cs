using System;
namespace pil_backend_darwoft.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Discount1 { get; set; }
        public DateTime? Since { get; set; }
        public DateTime? Until { get; set; }
    }
}
