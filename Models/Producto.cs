using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaAdministrador.Models

{
    public class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Id es requerida")]
        public int IdCategoria { get; set; }
        [Required(ErrorMessage = "El IdCategoria es requerida")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "El Precio es requerida")]
        public string Imagen { get; set; }

        public string producto { get; set; }


    }
}
    
