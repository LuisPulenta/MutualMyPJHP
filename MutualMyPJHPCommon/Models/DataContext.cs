namespace MutualMyPJHPCommon.Models
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public System.Data.Entity.DbSet<MutualMyPJHPCommon.Models.Jubilacion> Jubilacions { get; set; }

        public System.Data.Entity.DbSet<MutualMyPJHPCommon.Models.Usuario> Usuarios { get; set; }
    }
}