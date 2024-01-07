using Microsoft.EntityFrameworkCore;

class WSDb : DbContext
{
    public WSDb(DbContextOptions<WSDb> options)
        :base(options) {}

    public DbSet<Reading> readings => Set<Reading>();
}