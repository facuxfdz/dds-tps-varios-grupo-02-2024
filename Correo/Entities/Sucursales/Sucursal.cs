using Correo.Entities.Empleados;
using Correo.Envios;

namespace Correo.Entities.Sucursales;

public class Sucursal
{
    private int _numero;
    private string _domicilio;
    private string _localidad;
    private List<Envio> _envios = [];
    private List<Empleado> _empleados = [];
    
    public Sucursal(int numero, string domicilio, string localidad)
    {
        _numero = numero;
        _domicilio = domicilio;
        _localidad = localidad;
    }
    
    public void AddEnvio(Envio envio)
    {
        _envios.Add(envio);
    }
    
    
    public void AddEmpleado(Empleado empleado)
    {
        _empleados.Add(empleado);
    }
    
    public int Numero => _numero;
    public string Domicilio => _domicilio;
    public string Localidad => _localidad;
    public List<Envio> Envios => _envios;
    public List<Empleado> Empleados => _empleados;
}