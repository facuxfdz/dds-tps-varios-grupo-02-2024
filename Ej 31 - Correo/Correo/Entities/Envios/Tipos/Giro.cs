using Correo.Envios;
using Correo.Envios.Participantes;

namespace Correo.Entities.Envios.Tipos;

public class Giro : Envio
{
    private float _importe;

    public Giro(float precio, string codigoRastreo, float importe, Participante destinatario, Participante remitente) : base(precio, codigoRastreo, destinatario, remitente)
    {
        _importe = importe;
    }

    public float Importe => _importe;
}