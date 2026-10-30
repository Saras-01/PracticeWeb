using Microsoft.EntityFrameworkCore;
using PracticeWeb.Models;
namespace PracticeWeb.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Student> Students => Set<Student>();
}