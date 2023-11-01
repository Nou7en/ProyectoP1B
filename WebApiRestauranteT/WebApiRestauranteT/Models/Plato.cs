using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiRestauranteT.Models
{
    public class Plato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPlato { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        

    }
}
