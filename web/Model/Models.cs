using Microsoft.EntityFrameworkCore;

namespace Models {

    public class Regiseter
    {
        public int Id { get; set; }
    }

    public class sqlsvr : DbContext
    {
        public sqlsvr(DbContextOptions<sqlsvr> options): base(options)
        {
        }

        public sqlsvr()
        {
        }

        public DbSet<Regiseter> Regiseter { get; set; }
    }
}