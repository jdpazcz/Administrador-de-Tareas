using System.ComponentModel.DataAnnotations;

namespace TODOLIST_AGA.Models
{
    public class ParametrosEntrada
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Completa el campo")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Completa el campo")]
        public string? Actividad { get; set; }

        [Required(ErrorMessage = "Completa el campo")]
        public string? Estatus { get; set; }


    }
}
