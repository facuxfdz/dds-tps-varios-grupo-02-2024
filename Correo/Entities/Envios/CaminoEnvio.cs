using Correo.Entities.Empleados;
using Correo.Entities.Sucursales;

namespace Correo.Envios;

public class CaminoEnvio
{
    private DateTimeOffset _fecha;  // UTC
    private EnvioEstado _envioEstado;
    private Sucursal _sucursalOrigen;
    private Sucursal _sucursalDestino;
    private string _domicilioDestino;
    private Empleado _cartero; // TODO como asegurar que sea cartero y no administrativo? Problema de la capa de datos o qué?

    public CaminoEnvio(EnvioEstado envioEstado, Sucursal sucursalOrigen, Sucursal sucursalDestino)
    {
        _envioEstado = envioEstado;
        _sucursalOrigen = sucursalOrigen;
        _sucursalDestino = sucursalDestino;
    }
    
}