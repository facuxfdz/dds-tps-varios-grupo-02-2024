using Correo.Entities.Empleados;
using Correo.Envios;

namespace Correo.Entities.Sucursales;

/*
 *
 * DECISIONES DE DISEÑO:
 * - La clase sucursal no necesita toda la informacion de un envio, sin embargo tiene la informacion de los caminos donde se encuentra involucrada.
 *   Cuando hablamos de "involucrado" nos referimos a que la sucursal es el origen o destino de un envio.
 */

public class Sucursal
{
    private int _numero;
    private string _domicilio;
    private string _localidad;
    private List<CaminoEnvio> _enviados = [];
    private List<CaminoEnvio> _enviosRecibidos = [];
    private List<Empleado> _empleados = [];
    
    public Sucursal(int numero, string domicilio, string localidad)
    {
        _numero = numero;
        _domicilio = domicilio;
        _localidad = localidad;
    }
    
    public void AddCamino(CaminoEnvio camino)
    {
        if (camino.SucursalOrigen.Numero == this._numero)
        {
            _enviados.Add(camino);
            Console.WriteLine($"Nuevo camino agregado a la sucursal ({this._numero})\nDestino: {camino.SucursalDestino._domicilio}");
        }
        else
        {
            _enviosRecibidos.Add(camino);
            Console.WriteLine($"Nuevo camino recibido en la sucursal ({this._numero})\nOrigen: {camino.SucursalOrigen._domicilio}");
        }
        
    }
    
    public void AddEmpleado(Empleado empleado)
    {
        _empleados.Add(empleado);
        Console.WriteLine($"Empleado {empleado.Nombre} fue agregado a la sucursal {this._numero}");
    }
    
    public int Numero => _numero;
    public string Domicilio => _domicilio;
    public string Localidad => _localidad;
    public List<CaminoEnvio> Enviados => _enviados;
    public List<CaminoEnvio> EnviosRecibidos => _enviosRecibidos;
    public List<Empleado> Empleados => _empleados;
}