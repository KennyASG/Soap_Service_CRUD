using Microsoft.EntityFrameworkCore;
using soap_service.Models;


namespace soap_service.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base( options)
    {
    }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Catalogo> Catalogos { get; set; }
    public DbSet<Compras> Compras { get; set; }
}