using System.Runtime.Serialization;

namespace soap_service.Models;

[DataContract]
public class Catalogo
{
    [DataMember] 
    public int Id { get; set; }
    [DataMember] 
    public string? NombreProducto { get; set; }
    [DataMember] 
    public string? Descripcion { get; set; }
    [DataMember] 
    public decimal Precio { get; set; }
}