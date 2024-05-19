namespace PokeApi.Entities;

public class Pokemon
{
    public int Orden { get; set; }
    public string Nombre { get; set; }
    public ICollection<Movimiento> Movimientos { get; set; }
    public string ArteOficialUrl { get; set; }
}