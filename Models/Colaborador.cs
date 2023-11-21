using System.Data.Entity;

namespace TallerCamilaCote.Models
{
    public class Colaborador
    {
        public int colaborador_id { get; set; }
        public string Rut { get; set; }
        public int Nombre { get; set; }
        public int pago_id { get; set; }
        public string Telefono { get;}
        public string Cuenta { get; set; }
    }

    public class ColabDBContext : DbContext
    {
        public ColabDBContext() { }

        public DbSet<Colaborador> Colaboradores { get; set; }
    }
}
