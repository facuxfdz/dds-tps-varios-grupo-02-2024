using PokeApi.Infrastructure;

bool salir = false;

while (!salir)
{
    Console.WriteLine("Bienvenido a la Pokedex");
    Console.WriteLine("1. Buscar Pokemon");
    Console.WriteLine("2. Buscar Pokemones por movimiento");
    Console.WriteLine("9. Salir");

    var opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            BuscarPokemon();
            break;
        case "2":
            BuscarPokemonesPorMovimiento();
            break;
        case "9":
            salir = true;
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
    Console.WriteLine();
    Console.WriteLine();
}


void BuscarPokemon()
{
    try
    {
        Console.WriteLine("Ingrese el nombre del pokemon a buscar");
        var nombre = Console.ReadLine();
        var pokeApi = new PokeApiRest();
        var pokemon = pokeApi.GetPokemon(nombre.ToLower());
        Console.WriteLine();
        Console.WriteLine("Información del pokemon");
        Console.WriteLine($"Nombre: {pokemon.Nombre}");
        Console.WriteLine($"Orden: {pokemon.Orden}");
        Console.WriteLine($"Arte oficial: {pokemon.ArteOficialUrl}");
        Console.WriteLine("Movimientos:");
        Console.WriteLine($"- {string.Join(" - ", pokemon.Movimientos.Select(m => m.Nombre))}");
    }
    catch (Exception e)
    {
        Console.WriteLine("El pokemon no existe");
    }
}

void BuscarPokemonesPorMovimiento()
{
    try
    {
        Console.WriteLine("Ingrese el nombre del movimiento a buscar");
        var nombre = Console.ReadLine();
        var pokeApi = new PokeApiRest();
        var pokemones = pokeApi.GetPokemonesConMovimiento(nombre.ToLower());
        Console.WriteLine();
        Console.WriteLine($"Pokemones que aprenden {nombre}");
        Console.WriteLine($"- {string.Join(" - ", pokemones.Select(p => p.Nombre))}");
    }
    catch (Exception e)
    {
        Console.WriteLine("El movimiento no existe");
    }
}