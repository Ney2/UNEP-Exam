public class ApplicationDbContext : DbContext
{
    public DbSet<Staff> Staff { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }
}
