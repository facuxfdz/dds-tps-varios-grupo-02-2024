namespace Correo.Envios.Participantes;

public class Participante
{
    private string _nombre;
    private string _direccion;
    private string _codigoPostal;
    private string _localidad;
    private ParticipanteTipo _tipo;

    public Participante(string nombre, string direccion, string codigoPostal, string localidad, ParticipanteTipo tipo)
    {
        _nombre = nombre;
        _direccion = direccion;
        _codigoPostal = codigoPostal;
        _localidad = localidad;
        _tipo = tipo;
    }
    
    public string Nombre => _nombre;
    public string Direccion => _direccion;
    public string CodigoPostal => _codigoPostal;
    public string Localidad => _localidad;
    public ParticipanteTipo Tipo => _tipo;
}