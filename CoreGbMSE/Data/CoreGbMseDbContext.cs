using CoreGbMSE.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreGbMSE.Data
{
    public class CmsDbContext : DbContext
    {
        public CmsDbContext(DbContextOptions<CmsDbContext> options):base(options)
        {
        }

        public virtual DbSet<Filial> Filials { get; set; }
        public virtual DbSet<Personnel> Personnels { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Otdel> Otdels { get; set; }
        public virtual DbSet<TaskWork> TaskWork { get; set; }
        public virtual DbSet<TaskType> TaskType { get; set; }

    }
}
