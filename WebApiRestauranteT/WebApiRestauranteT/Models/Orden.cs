using System.ComponentModel.DataAnnotations;

namespace WebApiRestauranteT.Models
{
    public class Orden
    {
        [Key]
        public int id { get; set; }
        public int numOrden { get; set; }
        public int idMesa { get; set; }
        public Plato plato { get; set; }
        public double precio { get; set; }


    }
}
