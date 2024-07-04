namespace DefaultNamespace;

public class LibraryContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("");
    }
}
