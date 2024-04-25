using Correo.Entities.Empleados;
using Correo.Envios;
using Correo.Envios.Participantes;

namespace Correo.Entities.Envios.Tipos;

public class Telegrama : Envio
{
    private string _texto;
    private TelegramaTipo _tipo;

    public Telegrama(float precio, string codigoRastreo, string texto, TelegramaTipo tipo, Participante destinatario,
        Participante remitente) : base(precio, codigoRastreo, destinatario, remitente)
    {
        _texto = texto;
        _tipo = tipo;
    }

    public string Texto => _texto;
    public TelegramaTipo Tipo => _tipo;
}