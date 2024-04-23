using Correo.Entities.Empleados;
using Correo.Entities.Envios.Tipos;
using Correo.Entities.Sucursales;

namespace Correo.Menu;

public static class CreateMenu
{
    public static void Show()
    {
        Console.WriteLine("1. Crear empleado");
        Console.WriteLine("2. Crear sucursal");
        Console.WriteLine("3. Crear envio");
        Console.WriteLine("4. Salir");
    }
    
    public static Empleado CreateEmpleado()
    {
        Console.WriteLine("Nombre:");
        var nombre = Console.ReadLine();
        
        Console.WriteLine("Tipo:");
        var tipo = Console.ReadLine();
        
        var t = Enum.Parse<EmpleadoTipo>(tipo);
        
        return new Empleado(nombre, t);
    }
    
    public static Sucursal CreateSucursal()
    {
        Console.WriteLine("Numero:");
        var numero = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Domicilio:");
        var domicilio = Console.ReadLine();
        
        Console.WriteLine("Localidad:");
        var localidad = Console.ReadLine();
        
        return new Sucursal(numero, domicilio, localidad);
    }
    
    public static void CreateEnvio(Sucursal sucursal)
    {
        Console.WriteLine("Precio:");
        var precio = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Codigo de rastreo:");
        var codigoRastreo = Console.ReadLine();
        
        Console.WriteLine("Importe:");
        var importe = float.Parse(Console.ReadLine());
        
        sucursal.AddEnvio(new Giro(precio, codigoRastreo, importe));
    }
}
