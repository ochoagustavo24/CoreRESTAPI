using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRESTAPI.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Column(TypeName = "VARCHAR(200)")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Column(TypeName = "VARCHAR(200)")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Column(TypeName = "VARCHAR(50)")]
        public string Identificacion { get; set; }

    }
}
