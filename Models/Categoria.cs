using System.ComponentModel.DataAnnotations;

namespace CafeteriaAdministrador.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Id es requerida")]
        public string Nombre { get; set; }

    }
}
