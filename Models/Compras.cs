using System.Runtime.Serialization;

namespace soap_service.Models;

[DataContract]
public class Compras
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public int UsuarioId { get; set; }

    [DataMember]
    public int CatalogoId { get; set; }

    [DataMember]
    public DateTime FechaCompra { get; set; }

    [DataMember]
    public int Cantidad { get; set; }
}