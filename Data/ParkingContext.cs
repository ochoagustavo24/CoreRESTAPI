using CoreRESTAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreRESTAPI.Data
{
    public class ParkingContext: DbContext
    {
        public ParkingContext(DbContextOptions<ParkingContext> options): base(options){ }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Registro> Registros { get; set; }

    }
}
