using Microsoft.EntityFrameworkCore;
using RottenOnions.Domain.Entities;

namespace RottenOnions.Infrastructure;

public class RottenOnionsDbContext(DbContextOptions<RottenOnionsDbContext> options) : DbContext(options)
{
    public DbSet<Movie> Movies { get; set; }

    public DbSet<Serie> Series { get; set; }

    public DbSet<Comment> Comments { get; set; }

    public DbSet<Notification> Notifications { get; set; }
}
