using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRESTAPI.Models
{
    [Table("Registros")]
    public class Registro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegistroId { get; set; }
        [Column(TypeName = "DATETIME")]
        public string FechaEntrada { get; set; } = DateTime.Now.ToString();
        [Column(TypeName = "DATETIME")]
        public string FechaSalida { get; set; }


        [ForeignKey("ClienteId")]
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
