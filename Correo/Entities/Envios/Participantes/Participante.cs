namespace Correo.Envios.Participantes;

public class Participante
{
    private string _nombre;
    private string _direccion;
    private int _codigoPostal;
    private string _localidad;
    private ParticipanteTipo _tipo;

    public Participante(string nombre, string direccion, int codigoPostal, string localidad, ParticipanteTipo tipo)
    {
        _nombre = nombre;
        _direccion = direccion;
        _codigoPostal = codigoPostal;
        _localidad = localidad;
        _tipo = tipo;
    }
}