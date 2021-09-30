using System.Collections.Generic;

namespace CoreRESTAPI.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Identificacion { get; set; }
    }
}
