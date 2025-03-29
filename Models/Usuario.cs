using System.Runtime.Serialization;

namespace soap_service.Models;

[DataContract]
public class Usuario
{
    [DataMember] 
    public int Id { get; set; }
    [DataMember] 
    public string? Nombre { get; set; }
    [DataMember]
    public string? Apellido { get; set; }
    [DataMember] 
    public string? CorreoElectronico { get; set; }
}