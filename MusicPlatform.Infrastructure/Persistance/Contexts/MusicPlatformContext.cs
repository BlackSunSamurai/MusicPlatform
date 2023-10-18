using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicPlatform.Domain;
using MusicPlatform.Domain.Authentification;

namespace MusicPlatform.Infrastructure.Persistance.Contexts;

public class MusicPlatformContext : IdentityDbContext<User,Role,int>
{
    public MusicPlatformContext(DbContextOptions<MusicPlatformContext> options) : base(options) { }

    public DbSet<Album>  Albums  { get; set; }
    
    public DbSet<Artist> Artists { get; set; }
    
    public DbSet<Song>   Songs   { get; set; }
}