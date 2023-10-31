using System.ComponentModel.DataAnnotations;

namespace WebApiRestauranteT.Models
{
    public class Plato
    {
        [Key]
        public int idPlato { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }

    }
}
