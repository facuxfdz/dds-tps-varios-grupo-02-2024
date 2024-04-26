using Correo.Entities.Empleados;
using Correo.Entities.Sucursales;

namespace Correo.Envios;

/*
    DECISIONES DE DISEÑO:
    - El atributo _cartero es de tipo Empleado, pero especificamente es Cartero y esto es asegurado a nivel de aplicacion. En la clase que orqueste el caso de uso.
    - El cartero es empleado de la sucursal, por lo que a nivel de aplicacion se asegura que el cartero pertenece a la sucursal. 
 */

public class CaminoEnvio
{
    private DateTimeOffset _fecha;
    private EnvioEstado _envioEstado;
    private Sucursal _sucursalOrigen;
    private Sucursal? _sucursalDestino;
    private string _domicilioDestino;
    private Empleado _cartero;

    public CaminoEnvio(EnvioEstado envioEstado, Sucursal sucursalOrigen, Sucursal? sucursalDestino, DateTimeOffset fecha, string domicilioDestino, Empleado cartero)
    {
        _envioEstado = envioEstado;
        _sucursalOrigen = sucursalOrigen;
        _sucursalDestino = sucursalDestino;
        _fecha = fecha;
        _domicilioDestino = domicilioDestino;
        _cartero = cartero;
    }
    
    public DateTimeOffset Fecha => _fecha;
    public EnvioEstado EnvioEstado => _envioEstado;
    public Sucursal SucursalOrigen => _sucursalOrigen;
    public Sucursal? SucursalDestino => _sucursalDestino;
    public string DomicilioDestino => _domicilioDestino;
    public Empleado Cartero => _cartero;
    
}