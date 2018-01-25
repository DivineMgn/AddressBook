using System.Data.Entity;

namespace ContactServiceLibrary.MsSQLService
{
    class MsSQLContext : DbContext
    {
        public virtual DbSet<MsSQLContactType> Contacts { get; set; }

        public MsSQLContext() : base("MsSQL") { }
    }
}
