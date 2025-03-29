using System.ServiceModel;
using System.Collections.Generic;
using soap_service.Models;

namespace soap_service.Services.IServices;

[ServiceContract]
public interface ITiendaService
{
    // Métodos para Usuario
    [OperationContract]
    Usuario GetUsuarioById(int id);

    [OperationContract]
    IEnumerable<Usuario> GetAllUsuarios();

    [OperationContract]
    void AddUsuario(Usuario usuario);

    [OperationContract]
    void UpdateUsuario(Usuario usuario);

    [OperationContract]
    void DeleteUsuario(int id);

    // Métodos para Catalogo
    [OperationContract]
    Catalogo GetCatalogoById(int id);

    [OperationContract]
    IEnumerable<Catalogo> GetAllCatalogos();

    [OperationContract]
    void AddCatalogo(Catalogo catalogo);

    [OperationContract]
    void UpdateCatalogo(Catalogo catalogo);

    [OperationContract]
    void DeleteCatalogo(int id);

    // Métodos para Compras
    [OperationContract]
    Compras GetCompraById(int id);

    [OperationContract]
    IEnumerable<Compras> GetAllCompras();

    [OperationContract]
    void AddCompra(Compras compra);

    [OperationContract]
    void UpdateCompra(Compras compra);

    [OperationContract]
    void DeleteCompra(int id);
}