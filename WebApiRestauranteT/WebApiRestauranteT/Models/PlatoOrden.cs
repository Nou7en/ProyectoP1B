using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiRestauranteT.Models
{
    public class PlatoOrden
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPlatoOrden { get; set; }
        public int idPlato { get; set; }
        public int cantidad { get; set; } 

    }
}
