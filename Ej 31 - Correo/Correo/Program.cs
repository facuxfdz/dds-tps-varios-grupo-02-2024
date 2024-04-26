using Correo.Entities.Empleados;
using Correo.Entities.Envios.Tipos;
using Correo.Entities.Sucursales;
using Correo.Envios;
using Correo.Envios.Participantes;

var empleado1 = new Empleado("Juan", EmpleadoTipo.Administrativo);
var empleado2 = new Empleado("Pedro", EmpleadoTipo.Cartero);
var empleado3 = new Empleado("Maria", EmpleadoTipo.Administrativo);
var empleado4 = new Empleado("Jose", EmpleadoTipo.Cartero);
var empleado5 = new Empleado("Lucia", EmpleadoTipo.Cartero);

var sucursal1 = new Sucursal(1, "Av. Siempreviva 742", "Springfield");
var sucursal2 = new Sucursal(2, "Av. Alumnos 745", "Glew");
var sucursal3 = new Sucursal(3, "Av. Alumnos 1700", "Glew");

sucursal1.AddEmpleado(empleado1);
sucursal1.AddEmpleado(empleado2);
sucursal2.AddEmpleado(empleado3);
sucursal2.AddEmpleado(empleado4);
sucursal3.AddEmpleado(empleado5);

var destinatario = new Participante("Homero", "MiCasa 1234", "B1845", "Glew",ParticipanteTipo.Persona);
var remitente = new Participante("Bart", "Calle Falsa 123", "B1845", "Glew",ParticipanteTipo.Persona);
var envio1 = new Giro(100.0f, "123", 50.0f, destinatario, remitente);

var camino1 = new CaminoEnvio(EnvioEstado.EnTransito, sucursal1, sucursal2, DateTimeOffset.Now, sucursal2.Domicilio, empleado2);
envio1.AddCamino(camino1);
var camino2 = new CaminoEnvio(EnvioEstado.EnTransito, sucursal2, sucursal3, DateTimeOffset.Now, sucursal3.Domicilio, empleado4);
envio1.AddCamino(camino2);
var caminoFinal = new CaminoEnvio(EnvioEstado.ParaEntregar, sucursal3, null, DateTimeOffset.Now, destinatario.Direccion, empleado5);
envio1.AddCamino(caminoFinal);