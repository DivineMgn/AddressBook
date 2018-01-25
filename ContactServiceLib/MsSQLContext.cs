using System.Data.Entity;

namespace ContactServiceLib
{
    internal class MsSQLContext : DbContext
    {
        public virtual DbSet<Contact> Contacts { get; set; }

        public MsSQLContext() : base("MsSQL") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<MsSQLContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
