using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRESTAPI.Models
{
    public class Registro
    {
        public int RegistroId { get; set; }
        public string FechaEntrada { get; set; } = DateTime.Now.ToString();
        public string FechaSalida { get; set; }

        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }
    }
}
