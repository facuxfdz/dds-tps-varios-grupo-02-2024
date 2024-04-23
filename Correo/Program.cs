using Correo.Entities.Empleados;
using Correo.Entities.Envios.Tipos;
using Correo.Entities.Sucursales;
using Correo.Envios;

var empleado1 = new Empleado("Juan", EmpleadoTipo.Administrativo);
var empleado2 = new Empleado("Pedro", EmpleadoTipo.Cartero);

var sucursal = new Sucursal(1, "Av. Siempreviva 742", "Springfield");

sucursal.AddEmpleado(empleado1);
sucursal.AddEmpleado(empleado2);

var envio1 = new Giro(100.0f, "123", 50.0f);

sucursal.AddEnvio(envio1);

Console.WriteLine($"Sucursal {sucursal.Numero}");
Console.WriteLine($"Domicilio: {sucursal.Domicilio}");
Console.WriteLine($"Localidad: {sucursal.Localidad}");

Console.WriteLine("Empleados:");
foreach (var empleado in sucursal.Empleados)
{
    Console.WriteLine($"- {empleado.Nombre} ({empleado.Tipo})");
}

Console.WriteLine("Envios:");
foreach (var envio in sucursal.Envios)
{
    Console.WriteLine($"- {envio.Precio} - {envio.CodigoRastreo} - {envio.Entregado}");
}