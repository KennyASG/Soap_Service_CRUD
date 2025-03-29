using soap_service.Models;

namespace soap_service.Repositories.IRepository;

public interface ITiendaRepository
{
    
    Usuario GetUsuarioById(int id);
    IEnumerable<Usuario> GetAllUsuarios();
    void AddUsuario(Usuario usuario);
    void UpdateUsuario(Usuario usuario);
    void DeleteUsuario(int id);
    
    Catalogo GetCatalogoById(int id);
    IEnumerable<Catalogo> GetAllCatalogos();
    void AddCatalogo(Catalogo catalogo);
    void UpdateCatalogo(Catalogo catalogo);
    void DeleteCatalogo(int id);
    
    Compras GetCompraById(int id);
    IEnumerable<Compras> GetAllCompras();
    void AddCompra(Compras compra);
    void UpdateCompra(Compras compra);
    void DeleteCompra(int id);
}