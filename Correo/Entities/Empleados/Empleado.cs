namespace Correo.Entities.Empleados;

public class Empleado
{
    private string _nombre;
    private EmpleadoTipo _tipo;
    
    public Empleado(string nombre, EmpleadoTipo tipo)
    {
        _nombre = nombre;
        _tipo = tipo;
    }
    
    public string Nombre => _nombre;
    public EmpleadoTipo Tipo => _tipo;
}