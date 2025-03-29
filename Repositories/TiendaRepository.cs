using soap_service.Data;
using soap_service.Models;
using soap_service.Repositories.IRepository;

namespace soap_service.Repositories;

public class TiendaRepository : ITiendaRepository
{
    private readonly ApplicationDbContext _context;

    public TiendaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    // Métodos para Usuario
    public Usuario GetUsuarioById(int id)
    {
        return _context.Usuarios.Find(id);
    }

    public IEnumerable<Usuario> GetAllUsuarios()
    {
        return _context.Usuarios.ToList();
    }

    public void AddUsuario(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
    }

    public void UpdateUsuario(Usuario usuario)
    {
        _context.Usuarios.Update(usuario);
        _context.SaveChanges();
    }

    public void DeleteUsuario(int id)
    {
        var usuario = _context.Usuarios.Find(id);
        if (usuario != null)
        {
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }
    }

    // Métodos para Catalogo
    public Catalogo GetCatalogoById(int id)
    {
        return _context.Catalogos.Find(id);
    }

    public IEnumerable<Catalogo> GetAllCatalogos()
    {
        return _context.Catalogos.ToList();
    }

    public void AddCatalogo(Catalogo catalogo)
    {
        _context.Catalogos.Add(catalogo);
        _context.SaveChanges();
    }

    public void UpdateCatalogo(Catalogo catalogo)
    {
        _context.Catalogos.Update(catalogo);
        _context.SaveChanges();
    }

    public void DeleteCatalogo(int id)
    {
        var catalogo = _context.Catalogos.Find(id);
        if (catalogo != null)
        {
            _context.Catalogos.Remove(catalogo);
            _context.SaveChanges();
        }
    }

    // Métodos para Compras
    public Compras GetCompraById(int id)
    {
        return _context.Compras.Find(id);
    }

    public IEnumerable<Compras> GetAllCompras()
    {
        return _context.Compras.ToList();
    }

    public void AddCompra(Compras compra)
    {
        try
        {
            compra.FechaCompra = DateTime.SpecifyKind(compra.FechaCompra, DateTimeKind.Utc);
            _context.Compras.Add(compra);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.InnerException?.Message); 
            throw;
        }
    }


    public void UpdateCompra(Compras compra)
    {
        _context.Compras.Update(compra);
        _context.SaveChanges();
    }

    public void DeleteCompra(int id)
    {
        var compra = _context.Compras.Find(id);
        if (compra != null)
        {
            _context.Compras.Remove(compra);
            _context.SaveChanges();
        }
    }
}