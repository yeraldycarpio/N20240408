using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N20240408.EntidadesDeNegocio
{
    public class PersonasN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nomnbre es obligatorio")]
        [StringLength(60)]
        [DisplayName("Nombre")]
        public string NombreN { get; set; }

        [Required(ErrorMessage ="El apellido es obligario")]
        [StringLength(60)]
        [DisplayName("Apellidos")]
        public string ApellidoN { get; set; }

        [Required(ErrorMessage ="La fecha de nacimiento es requerida")]
        [DisplayName("FechaDeNacimiento")]
        public DateTime FechaNacimientoN { get; set; }

        [Required(ErrorMessage = "El sueldo es obligatorio")]
        [DisplayName("Sueldo")]
        public decimal SueldoN { get; set; }

        [Required(ErrorMessage = "El estatus es Obligatorio")]
        [DisplayName("Estatus")]
        public byte EstatusN { get; set; }

        public string ComentarioN { get; set; }

    }
}
