using CoreGbMSE.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreGbMSE.Data
{
    public class CoreGbMseDbContext : DbContext
    {
        public CoreGbMseDbContext(DbContextOptions<CoreGbMseDbContext> options):base(options)
        {
        }

        public virtual DbSet<Filial> Filials { get; set; }
        public virtual DbSet<Personnel> Personnels { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Otdel> Otdels { get; set; }
        public virtual DbSet<TaskWork> TaskWork { get; set; }
    }
}
