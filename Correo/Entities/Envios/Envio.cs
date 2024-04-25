using Correo.Envios.Participantes;

namespace Correo.Envios;

/*
 * DECISIONES DE DISEÑO:
 * - Los caminos van siendo agregados al envio a medida que se van realizando.
 *   Si el camino es hacia el domicilio del destinatario, se marca como entregado.
 *   Si no, se muestra la dirección de entrega.
 */

public abstract class Envio
{
    private float _precio;
    private string _codigoRastreo;
    private bool _entregado;
    private Participante _destinatario;
    private Participante _remitente;
    private List<CaminoEnvio> _caminos;

    public Envio(float precio, string codigoRastreo, Participante destinatario, Participante remitente)
    {
        _precio = precio;
        _codigoRastreo = codigoRastreo;
        _destinatario = destinatario;
        _remitente = remitente;
        _caminos = new List<CaminoEnvio>();
        _entregado = false;
    }
    
    public void AddCamino(CaminoEnvio camino)
    {
        _caminos.Add(camino);
        if (camino.DomicilioDestino == _destinatario.Direccion)
        {
            _entregado = true;
            Console.WriteLine($"El envio fue entregado exitosamente al destinatario: {_destinatario.Nombre}.\nDireccion de entrega: {_destinatario.Direccion}\n");
        }else {
            Console.WriteLine($"El envio se encuentra en camino hacia la sucursal: {camino.SucursalDestino!.Numero}.\nDireccion de entrega: {camino.DomicilioDestino}\n");
        }
    }
    public float Precio => _precio;
    public string CodigoRastreo => _codigoRastreo;
    public bool Entregado => _entregado;

    public Participante Destinatario => _destinatario;
    public Participante Remitente => _remitente;
    public List<CaminoEnvio> Caminos => _caminos;
}