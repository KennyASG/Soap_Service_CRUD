using soap_service.Models;
using System.Collections.Generic;
using soap_service.Repositories.IRepository;
using soap_service.Services.IServices;

namespace soap_service.Services;

public class TiendaService : ITiendaService
{
    private readonly ITiendaRepository _tiendaRepository;

    public TiendaService(ITiendaRepository tiendaRepository)
    {
        _tiendaRepository = tiendaRepository;
    }

    // Métodos para Usuario
    public Usuario GetUsuarioById(int id)
    {
        return _tiendaRepository.GetUsuarioById(id);
    }

    public IEnumerable<Usuario> GetAllUsuarios()
    {
        return _tiendaRepository.GetAllUsuarios();
    }

    public void AddUsuario(Usuario usuario)
    {
        _tiendaRepository.AddUsuario(usuario);
    }

    public void UpdateUsuario(Usuario usuario)
    {
        _tiendaRepository.UpdateUsuario(usuario);
    }

    public void DeleteUsuario(int id)
    {
        _tiendaRepository.DeleteUsuario(id);
    }

    // Métodos para Catalogo
    public Catalogo GetCatalogoById(int id)
    {
        return _tiendaRepository.GetCatalogoById(id);
    }

    public IEnumerable<Catalogo> GetAllCatalogos()
    {
        return _tiendaRepository.GetAllCatalogos();
    }

    public void AddCatalogo(Catalogo catalogo)
    {
        _tiendaRepository.AddCatalogo(catalogo);
    }

    public void UpdateCatalogo(Catalogo catalogo)
    {
        _tiendaRepository.UpdateCatalogo(catalogo);
    }

    public void DeleteCatalogo(int id)
    {
        _tiendaRepository.DeleteCatalogo(id);
    }

    // Métodos para Compras
    public Compras GetCompraById(int id)
    {
        return _tiendaRepository.GetCompraById(id);
    }

    public IEnumerable<Compras> GetAllCompras()
    {
        return _tiendaRepository.GetAllCompras();
    }

    public void AddCompra(Compras compra)
    {
        _tiendaRepository.AddCompra(compra);
    }

    public void UpdateCompra(Compras compra)
    {
        _tiendaRepository.UpdateCompra(compra);
    }

    public void DeleteCompra(int id)
    {
        _tiendaRepository.DeleteCompra(id);
    }
}